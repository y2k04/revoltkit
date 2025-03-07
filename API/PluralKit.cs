using RevoltKit.API.Models;

namespace RevoltKit.API
{
    static class PluralKit // TODO: Turn into its own solution
    {
        readonly static string ApiURL = "https://api.pluralkit.me/v2";
        readonly static string UserAgent = "RevoltPK/1.0";
        readonly static HttpClient client = new();

        #region System
        public static Models.System? GetSystem(string systemID)
        { // GET /systems/:id
            return null;
        }

        public static Models.System? UpdateSystem(Models.System system)
        { // PATCH /systems/:id
            return null;
        }

        public static Models.Settings.SystemSettings? GetSystemSettings(string systemID)
        { // GET /systems/:id/settings
            return null;
        }

        public static Models.Settings.SystemSettings? UpdateSystemSettings(Models.Settings.SystemSettings settings)
        { // PATCH /systems/:id/settings
            return null;
        }

        public static Models.Settings.SystemGuildSettings? GetSystemGuildSettings(string guildID)
        { // GET /systems/@me/guilds/:id
            return null;
        }

        public static Models.Settings.SystemGuildSettings? UpdateSystemGuildSettings(Models.Settings.SystemGuildSettings settings)
        { // PATCH /systems/@me/guilds/:id
            return null;
        }

        public static Models.Settings.AutoProxySettings? GetSystemAutoProxySettings(string guildID/*, string channelID*/)
        { // GET /systems/@me/autoproxy
            return null;
        }

        public static Models.Settings.AutoProxySettings? UpdateSystemAutoProxySettings(Models.Settings.AutoProxySettings settings)
        { // PATCH /systems/@me/autoproxy
            return null;
        }
        #endregion
        #region Members
        public static Models.Member[]? GetSystemMembers(string systemID)
        { // GET /systems/:id/members
            return null;
        }

        public static Models.Member? CreateMember(Models.Member member)
        { // POST /members
            return null;
        }

        public static Models.Member? GetMember(string memberID)
        { // GET /members/:id
            return null;
        }

        public static Models.Member? UpdateMember(Models.Member member)
        { // PATCH /members/:id
            return null;
        }

        public static int? DeleteMember(string memberID)
        { // DELETE /members/:id
            return null;
        }

        public static Models.Group[]? GetMemberGroups(string memberID)
        { // GET /members/:id/groups
            return null;
        }

        public static int? AddMemberToGroups(string memberID, string[] groupIDs)
        { // POST /members/:id/groups/add
            return null;
        }

        public static int? RemoveMemberFromGroups(string memberID, string[] groupIDs)
        { // POST /members/:id/groups/remove
            return null;
        }
        
        public static int? RemoveMemberFromAllGroups(string memberID)
        { // POST /members/:id/groups/overwrite
            return null;
        }

        public static Models.Settings.MemberGuildSettings? GetMemberGuildSettings(string memberID, string guildID)
        { // GET /members/{memberRef}/guilds/{guild_id}
            return null;
        }

        public static Models.Settings.MemberGuildSettings? UpdateMemberGuildSettings(Models.Settings.MemberGuildSettings settings, string guildID)
        { // PATCH /members/{memberRef}/guilds/{guild_id}
            return null;
        }
        #endregion
        #region Groups
        public static Models.Group[]? GetSystemGroups(string systemID, bool with_members = false)
        { // GET /systems/:id/groups
            return null;
        }

        public static Models.Group? CreateGroup(Models.Group group)
        { // POST /groups
            return null;
        }

        public static Models.Group? GetGroup(string groupID)
        { // GET /groups/:id
            return null;
        }

        public static Models.Group? UpdateGroup(Models.Group group)
        { // PATCH /groups/:id
            return null;
        }

        public static int? DeleteGroup(string groupID)
        { // DELETE /groups/:id
            return null;
        }

        public static Models.Member[]? GetGroupMembers(string groupID)
        { // GET /groups/:id/members
            return null;
        }

        public static int? AddMembersToGroup(string groupID, Models.Member[] members)
        { // POST /groups/:id/members/add
            return null;
        }

        public static int? OverwriteGroupMembers(string groupID, Models.Member[] members)
        { // POST /groups/:id/members/overwrite
            return null;
        }
        #endregion
        #region Switches
        public static Models.Switch? GetSystemSwitches(string systemID, DateTime before, int limit = 100)
        { // GET /systems/:id/switches
            return null;
        }

        public static Models.Switch? GetCurrentSystemFronters(string systemID)
        { // GET /systems/:id/fronters
            return null;
        }

        public static Models.Switch? CreateSwitch(string systemID, DateTime timestamp, string[] members)
        { // POST /systems/:id/switches
            return null;
        }

        public static Models.Switch? GetSwitch(string systemID, string switchID)
        { // GET /systems/{systemRef}/switches/{switchRef}
            return null;
        }

        public static Models.Switch? UpdateSwitch(string systemID, string switchID, DateTime timestamp)
        { // PATCH /systems/{systemRef}/switches/{switchRef}
            return null;
        }

        public static Models.Switch? UpdateSwitchMembers(string systemID, string switchID, string[] members)
        { // PATCH /systems/{systemRef}/switches/{switchRef}/members
            return null;
        }

        public static int? DeleteSwitch(string systemID, string switchID)
        { // DELETE /systems/{systemRef}/switches/{switchRef}
            return null;
        }
        #endregion
        #region Misc
        public static Models.Message? GetProxiedMessageInfo(string messageID)
        { // GET /messages/:id
            return null;
        }
        #endregion
    }
}
