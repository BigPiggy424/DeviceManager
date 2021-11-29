using DeviceManagement.Debugging;

namespace DeviceManagement
{
    public class DeviceManagementConsts
    {
        public const string LocalizationSourceName = "DeviceManagement";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "08708dc0a16846cda5c7694d1e8a6c8c";
    }
}
