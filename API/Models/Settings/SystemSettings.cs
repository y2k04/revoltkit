using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevoltKit.API.Models.Settings
{
    class SystemSettings
    {
        public string timezone = "UTC";
        public bool pings_enabled, member_default_private, group_default_private, show_private_info;
        public int? latch_timeout;
        public readonly int
            member_limit = 1000,
            group_limit = 250;
    }
}
