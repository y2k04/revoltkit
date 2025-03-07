namespace RevoltKit.API.Models
{
    class Message
    {
        public DateTime timestamp;
        public string id, original, sender, channel, guild;
        public System? system;
        public Member? member;
    }
}
