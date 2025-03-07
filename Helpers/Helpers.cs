using RevoltSharp;
using RevoltSharp.Commands;

namespace RevoltKit.Helpers
{
    public static class Helpers
    {
        public static async Task TemporaryReply(CommandContext Context, string message, int delayMs = 5000)
        {
            var reply = await Context.Channel.SendMessageAsync(message, replies: [ new MessageReply(Context.Message.Id, true) ]);
            //await Context.Message.DeleteAsync();
            //await Task.Delay(delayMs);
            //await reply.DeleteAsync();
        }
    }
}
