using MonUniverse.MonUniverseRessources;
using System.Diagnostics;
using System.ServiceProcess;

namespace MonUniverse.MonUniverseEngine
{
    internal static class Check
    {
        static readonly Dictionary<Enums.InstallPath, bool> ALLPATHS = new Dictionary<Enums.InstallPath, bool>
        {
            {Enums.InstallPath.DISK, false },
            {Enums.InstallPath.FOLDER, false },
            {Enums.InstallPath.DATABASES, false },
            {Enums.InstallPath.LISTS, false },
            {Enums.InstallPath.CONNECTIONS, false },
            {Enums.InstallPath.IPINFOS, false }
        };
        static readonly Dictionary<Enums.InstallDatabases, bool> ALLDATABASES = new Dictionary<Enums.InstallDatabases, bool>
        {
            {Enums.InstallDatabases.NOTIFICATIONS, false },
            {Enums.InstallDatabases.TRUSTED, false },
            {Enums.InstallDatabases.VIEW, false }
        };
        static readonly Dictionary<Enums.InstallFiles, bool> ALLFILES = new Dictionary<Enums.InstallFiles, bool>
        {
            {Enums.InstallFiles.CACHEHOSTNAMELIST, false },
            {Enums.InstallFiles.CONNECTIONIPLIST, false },
            {Enums.InstallFiles.DNSCACHE, false },
            {Enums.InstallFiles.HOSTNAMEREQUESTLIST, false },
            {Enums.InstallFiles.TRUSTEDHOSTNAMELIST, false }
        };
        static bool lastCheck_Sysmon = false;
        static bool lastCheck_TCPView = false;
        public static bool VerifyAllPath()
        {
            foreach (KeyValuePair<Enums.InstallPath, string> path in Config.ALLPATHS)
            {
                Debug.Write(path.Value);
                ALLPATHS[path.Key] = Directory.Exists(path.Value);
                Debug.WriteLine(ALLPATHS[path.Key]);
            }
            return !ALLPATHS.ContainsValue(false);
        }

        public static bool VerifyAllFiles()
        {
            foreach (KeyValuePair<Enums.InstallFiles, string> path in Config.ALLFILES)
            {
                Debug.Write(path.Value);
                ALLFILES[path.Key] = File.Exists(path.Value);
                Debug.WriteLine(ALLFILES[path.Key]);
            }

            foreach (KeyValuePair<Enums.InstallDatabases, string> path in Config.ALLDATABASES)
            {
                Debug.Write(path.Value);
                ALLDATABASES[path.Key] = File.Exists(path.Value);
                Debug.WriteLine(ALLDATABASES[path.Key]);
            }
            return !ALLFILES.ContainsValue(false);
        }

        public static bool VerifySysmon()
        {
            bool haveSysmon64 = ServiceController.GetServices().Any(s => s.ServiceName.Equals("Sysmon64", StringComparison.OrdinalIgnoreCase));
            bool haveSysmon = ServiceController.GetServices().Any(s => s.ServiceName.Equals("Sysmon", StringComparison.OrdinalIgnoreCase));
            bool haveDriver = File.Exists(@"C:\Windows\System32\drivers\SysmonDrv.sys");
            bool haveEventLog = EventLog.Exists("Microsoft-Windows-Sysmon/Operational");
            return (haveSysmon64 || haveSysmon) && haveDriver && haveEventLog;
        }

        public static bool VerifyTCPView()
        {
            return true;
        }

        public static bool VerifyDNSClient()
        {
            return true;
        }

        public static bool VerifyPowershell()
        {
            return true;
        }
    }
}
