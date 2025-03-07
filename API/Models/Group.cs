using RevoltKit.API.Models.Privacy;

namespace RevoltKit.API.Models
{
    class Group
    {
        public string id, uuid, system, name;
        public string? display_name, description, icon, banner, color;
        public GroupPrivacy? privacy;
    }
}
