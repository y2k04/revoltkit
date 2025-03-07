namespace RevoltKit.User
{
    public class System
    {
        public string
            Name,
            Timezone;
        public List<SystemMember> Members = [];
        public SystemMember Fronter;
        public bool AutoProxyEnabled = false;

        public System(string name)
        {
            Name = name;
        }

        public bool ToggleAutoProxy()
        {
            if (Fronter == null)
                Fronter = Members[0];
            AutoProxyEnabled = AutoProxyEnabled ? false : true;
            return AutoProxyEnabled;
        }
    }
}
