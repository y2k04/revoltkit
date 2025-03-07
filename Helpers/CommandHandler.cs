using Optionals;
using RevoltSharp;
using RevoltSharp.Commands;

namespace RevoltKit.Helpers
{
    public class CommandHandler
    {
        RevoltClient client;
        CommandService service;
        IServiceProvider provider;

        public CommandHandler(RevoltClient _client, CommandService _service, IServiceProvider _provider)
        {
            client = _client;
            service = _service;
            provider = _provider;

            Task.Run(async () =>
            {
                await service.AddModuleAsync<Commands>(provider);
                client.OnMessageRecieved += Client_OnMessageRecieved;
                service.OnCommandExecuted += Service_OnCommandExecuted;
            });
        }

        private async void Client_OnMessageRecieved(Message msg)
        {
            if (msg.Content.StartsWith(Config.Prefix) && !msg.Author.IsBot)
            {
                UserMessage Message = (UserMessage)msg;
                int argPos = 0;
                if (Message.HasStringPrefix(Config.Prefix, ref argPos) || !Message.HasMentionPrefix(client.CurrentUser, ref argPos))
                {
                    var ctx = new CommandContext(client, Message);
                    var result = await service.ExecuteAsync(ctx, argPos, provider, MultiMatchHandling.Best);
                }
            }
            return;
        }

        private void Service_OnCommandExecuted(Optional<CommandInfo> commandinfo, CommandContext context, IResult result)
        {
            if (result.IsSuccess)
                Console.WriteLine("Success command: " + commandinfo.Value.Name);
            else
            {
                if (!commandinfo.HasValue)
                    return;
                context.Channel.SendMessageAsync("Error: " + result.ErrorReason);
            }
        }
    }
}
