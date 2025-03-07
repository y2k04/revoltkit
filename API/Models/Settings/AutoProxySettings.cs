using RevoltKit.API.Models.Enums;

namespace RevoltKit.API.Models.Settings
{
    class AutoProxySettings
    {
        public string? guild_id, channel_id;
        public AutoProxyMode autoproxy_mode;
        public string? autoproxy_member;
        public DateTime? last_latch_timestamp;
    }
}
