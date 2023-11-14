using lansman.Debugging;

namespace lansman
{
    public class lansmanConsts
    {
        public const string LocalizationSourceName = "lansman";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "37ee7976152c4c888544c5a4c7a5489c";
    }
}
