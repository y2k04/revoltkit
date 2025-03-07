using RevoltSharp;

namespace RevoltKit.User
{
    public class SystemMember
    {
        public string
            Name,
            AvatarURL,
            BirthDate,
            Pronouns;
        public RevoltColor Colour;
        public bool IsPrimary;

        public SystemMember(string name)
        {
            Name = name;
        }
    }
}
