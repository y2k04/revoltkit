using RevoltKit.API.Models.Privacy;

namespace RevoltKit.API.Models
{
    class System
    {
        public string id, uuid;
        public string? name, description, tag, pronouns, avatar_url, banner, color;
        public DateTime created;
        public SystemPrivacy? privacy;
    }
}
