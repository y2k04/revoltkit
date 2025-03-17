namespace RevoltKit
{
    public static class Config
    {
        public static readonly string Token = Environment.GetEnvironmentVariable("RevoltKit_BotToken");
        public static readonly string Prefix = "pk;";
    }
}
