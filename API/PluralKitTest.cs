using Newtonsoft.Json;

namespace RevoltKit.API
{
    static class PluralKitTest
    {
        public static Task Test()
        {
            for (; ; )
            {
                try
                {
                    Console.Write("> ");
                    var args = (Console.ReadLine() + " ").Split(' ');

                    switch (args[0].ToLower())
                    {
                        case "token":
                            PluralKit.Token = args[1];
                            PluralKit.Init();
                            Console.WriteLine("Set PluralKit token.\n");
                            break;
                        case "system":
                            System(args);
                            break;
                        case "member":
                            Member(args);
                            break;
                        case "group":
                            Group(args);
                            break;
                        case "switch":
                            Switch(args);
                            break;
                        case "autoproxy":
                            AutoProxy(args);
                            break;
                        case "config":
                            Config(args);
                            break;
                        default:
                            Console.WriteLine(args);
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e}");
                }
            }
        }

        static void System(string[] args)
        {
            if (!IsTokenSet())
                return;

            switch (args[1].ToLower())
            {
                default:
                    Console.WriteLine(JsonConvert.SerializeObject(PluralKit.GetSystem(args[1]), Formatting.Indented));
                    break;
            }
        }

        static void Member(string[] args)
        {
            if (!IsTokenSet())
                return;

            switch (args[1].ToLower())
            {
            }
        }

        static void Group(string[] args)
        {
            if (!IsTokenSet())
                return;

            switch (args[1].ToLower())
            {
            }
        }

        static void Switch(string[] args)
        {
            if (!IsTokenSet())
                return;

            switch (args[1].ToLower())
            {
            }
        }

        static void AutoProxy(string[] args)
        {
            if (!IsTokenSet())
                return;

            switch (args[1].ToLower())
            {
            }
        }

        static void Config(string[] args)
        {
            if (!IsTokenSet())
                return;

            switch (args[1].ToLower())
            {
                default:
                    Console.WriteLine(JsonConvert.SerializeObject(PluralKit.GetSystemSettings(args[1]), Formatting.Indented));
                    break;
            }
        }

        static bool IsTokenSet()
        {
            var result = string.IsNullOrEmpty(PluralKit.Token);
            if (result)
                Console.WriteLine("Error: Token not set.\n");
            return !result;
        }
    }
}
