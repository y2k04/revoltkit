using RevoltKit.API.Models.Enums;
using RevoltKit.API.Models.Privacy;

namespace RevoltKit.API.Models
{
    class Member
    {
        public string id, uuid, system, name;
        public string? display_name, color, birthday, pronouns, avatar_url,
            webhook_avatar_url, banner, description;
        public DateTime? created, last_message_timestamp;
        public int? message_count;
        public ProxyTag proxy_tags;
        public bool keep_proxy, tts;
        public bool? autoproxy_enabled;
        public MemberPrivacy privacy;
    }
}
