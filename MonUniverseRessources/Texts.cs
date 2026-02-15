using MonUniverse.Enums;
using System.Text;

namespace MonUniverse.MonUniverseRessources
{
    internal class Texts
    {
        #region SETTINGS
        public static string CLEAR = "CLEAR";
        public static string START = "START";
        public static string SHUTDOWN = "STOP";
        public static string ZERO = "0";
        public static string ARROW = ">";
        public static string NOSTATUS = "-";
        public static string SEPARATOR = "|";
        public static string INIT = "Init";
        public static string CHECK = "Check";
        public static string RUN = "Run";
        public static string CLEAN = "Clean";
        public static string RESET = "Reset";
        public static string STOP = "Stop";
        public static string NOTRUNNING = "NOT RUNNING";
        public static string RUNNING = "RUNNING";
        public static string NOTIFICATIONS = "NOTIFICATIONS";
        //public static string RUNNING = "RUNNING";
        //public static string RUNNING = "RUNNING";
        #endregion
        public static readonly Dictionary<string, MonUniverseService.State> RUNSERVICESTEPS = new Dictionary<string, MonUniverseService.State>
        {
            { "CollectConnections", MonUniverseService.State.COLLECT_CONNECTIONS },
            { "CollectIps", MonUniverseService.State.COLLECT_IPS },
            { "ProcessCorellation", MonUniverseService.State.PROCESS_CORELLATION },
            { "ReadDnsCache", MonUniverseService.State.READ_DNS_CACHE },
            { "ReadAndClearLogs", MonUniverseService.State.READ_AND_CLEAR_LOGS },
            { "RefreshDnsCache", MonUniverseService.State.REFRESH_DNS_CACHE },
        };
        public static Dictionary<ListingButtons, string> TEXTFILES = new Dictionary<ListingButtons, string>
        {
            { ListingButtons.CacheHostNameList, "D:\\Mon\\Files\\CacheHostNameList.txt" },
            { ListingButtons.ConnectionIpList, "D:\\Mon\\Files\\ConnectionIpList.txt" },
            { ListingButtons.HostNameRequestList, "D:\\Mon\\Files\\HostNameRequestList.txt" },
            { ListingButtons.TrustedHostnameList, "D:\\Mon\\Files\\TrustedHostnameList.txt" },
        };
    }
}