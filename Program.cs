using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using RevoltKit.Helpers;
using RevoltKit.User;
using RevoltSharp;
using RevoltSharp.Commands;
using System.Runtime.InteropServices;

namespace RevoltKit
{
    class Program
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleCtrlHandler(ConsoleEventDelegate callback, bool add);
        private delegate bool ConsoleEventDelegate(int eventType);
        static ConsoleEventDelegate handler = new(ConsoleEventCallback);
        
        public static Dictionary<string, User.System> Systems = []; // TODO: remove when API client ready
        static string testDataFile = @$"{Directory.GetCurrentDirectory()}\systems.json"; // TODO: remove when API client ready

        static RevoltClient client = new RevoltClient(ClientMode.WebSocket, new () { ApiUrl = "https://api.revolt.chat/" });
        static CommandService commandSVC = new();
        static ServiceCollection services = new();
        static CommandHandler commandHandler;
        static ServiceProvider? svcProvider;

        static void Main()
        {
            if (string.IsNullOrEmpty(Config.Token))
            {
                Console.WriteLine("Error: 'RevoltKit_BotToken' is not set or is empty.\n\nPress any key to exit...");
                Console.ReadKey();
                Environment.Exit(1);
            }
            SetConsoleCtrlHandler(handler, true);
            svcProvider = services.BuildServiceProvider();
            commandHandler = new CommandHandler(client, commandSVC, svcProvider);
            StartClient().GetAwaiter().GetResult();
        }

        static async Task StartClient()
        {
            client.OnMessageRecieved += Client_OnMessageRecieved;
            client.LoginAsync(Config.Token, AccountType.Bot).GetAwaiter().GetResult();
            LoadData(); // TODO: remove when API client ready
            await client.StartAsync();
            await Task.Delay(-1);
        }

        static void LoadData() // TODO: remove when API client ready
        {
            if (File.Exists(testDataFile))
                Systems = JsonConvert.DeserializeObject<Dictionary<string, User.System>>(File.ReadAllText(testDataFile));
        }

        static void SaveData() // TODO: remove when API client ready
        {
            File.WriteAllText(testDataFile, JsonConvert.SerializeObject(Systems));
        }

        static async void Client_OnMessageRecieved(Message message) // TODO: Rewrite to use API
        {
            if (Systems.ContainsKey(message.AuthorId))
            {
                if (!message.Content.StartsWith(Config.Prefix) && Systems[message.AuthorId].AutoProxyEnabled)
                {
                    SystemMember member = Systems[message.AuthorId].Fronter;
                    await message.DeleteAsync();
                    await message.Channel.SendMessageAsync(message.Content, masquerade: new(member.Name, member.AvatarURL, member.Colour));
                }
            }
        }

        static bool ConsoleEventCallback(int eventType)
        {
            if (eventType == 2)
            {
                client.StopAsync().GetAwaiter().GetResult();
                SaveData(); // Debug, remove on release
            }
            return false;
        }
    }
}