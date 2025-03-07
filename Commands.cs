using RevoltSharp.Commands;
using static RevoltKit.Helpers.Helpers;

namespace RevoltKit
{
    public sealed class Commands : ModuleBase // TODO: Rewrite to use API
    {
        #region System Commands (1 of 25)
        [Command("system new")]
        public async Task NewSystem([Remainder] string name)
        {
            Program.Systems.Add(Context.Message.AuthorId, new(name));
            await TemporaryReply(Context, $"Created system '{name}'.");
            return;
        }
        #endregion
        #region Member Commands (1 of 24)
        [Command("member new")] // TODO: Rewrite to use API
        public async Task NewSystemMember([Remainder] string name)
        {
            Program.Systems[Context.Message.AuthorId].Members.Add(new(name));
            await TemporaryReply(Context, $"Added '{name}' to system '{Program.Systems[Context.Message.AuthorId].Name}'.");
            return;
        }
        #endregion
        #region Group Commands (0 of 17)
        #endregion
        #region Switching Commands (0 of 7)
        #endregion
        #region Autoproxy Commands (1 of 4)
        [Command("autoproxy"), Alias("ap")] // TODO: Rewrite to use API
        public async Task ToggleAutoProxy()
        {
            var userID = Context.Message.AuthorId;
            if (Program.Systems.ContainsKey(userID))
            {
                if (Program.Systems[userID].Members.Count != 0)
                    await TemporaryReply(Context, $"{(Program.Systems[userID].ToggleAutoProxy() ? "Enabled" : "Disabled")} autoproxy.");
                else
                    await TemporaryReply(Context, "Error: No members have been added.");
            }
            else
                await TemporaryReply(Context, "Error: No system is configured.");
            return;
        }
        #endregion
        #region Config Commands (0 of 14)
        #endregion
        #region Server Owner Commands (0 of 12)
        #endregion
        #region Utility Commands (0 of 12)
        #endregion
    }
}
