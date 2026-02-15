namespace MonUniverse.MonUniverseRessources
{
    internal static class Config
    {
        public static readonly Dictionary<Enums.InstallPath, string> ALLPATHS = [];
        public static readonly Dictionary<Enums.InstallDatabases, string> ALLDATABASES = [];
        public static readonly Dictionary<Enums.InstallFiles, string> ALLFILES = [];
        static Config()
        {
            ALLPATHS.Add(Enums.InstallPath.DISK, "D:");
            ALLPATHS.Add(Enums.InstallPath.FOLDER, $"{ALLPATHS[Enums.InstallPath.DISK]}\\Mon");
            ALLPATHS.Add(Enums.InstallPath.DATABASES, $"{ALLPATHS[Enums.InstallPath.FOLDER]}\\Databases");
            ALLPATHS.Add(Enums.InstallPath.LISTS, $"{ALLPATHS[Enums.InstallPath.FOLDER]}\\Files");
            ALLPATHS.Add(Enums.InstallPath.CONNECTIONS, $"{ALLPATHS[Enums.InstallPath.FOLDER]}\\Folders\\Connections");
            ALLPATHS.Add(Enums.InstallPath.IPINFOS, $"{ALLPATHS[Enums.InstallPath.FOLDER]}\\Folders\\IpInfos");

            ALLDATABASES.Add(Enums.InstallDatabases.NOTIFICATIONS, $"{ALLPATHS[Enums.InstallPath.DATABASES]}\\NotificationsDatabase");
            ALLDATABASES.Add(Enums.InstallDatabases.TRUSTED, $"{ALLPATHS[Enums.InstallPath.DATABASES]}\\TrustedDatabase");
            ALLDATABASES.Add(Enums.InstallDatabases.VIEW, $"{ALLPATHS[Enums.InstallPath.DATABASES]}\\ViewDatabase");

            ALLFILES.Add(Enums.InstallFiles.CACHEHOSTNAMELIST, $"{ALLPATHS[Enums.InstallPath.LISTS]}\\CacheHostnameList.txt");
            ALLFILES.Add(Enums.InstallFiles.CONNECTIONIPLIST, $"{ALLPATHS[Enums.InstallPath.LISTS]}\\ConnectionIpList.txt");
            ALLFILES.Add(Enums.InstallFiles.DNSCACHE, $"{ALLPATHS[Enums.InstallPath.LISTS]}\\DnsCache.txt");
            ALLFILES.Add(Enums.InstallFiles.HOSTNAMEREQUESTLIST, $"{ALLPATHS[Enums.InstallPath.LISTS]}\\HostnameRequestList.txt");
            ALLFILES.Add(Enums.InstallFiles.TRUSTEDHOSTNAMELIST, $"{ALLPATHS[Enums.InstallPath.LISTS]}\\TrustedHostnameList.txt");
        }


       


        static string TCPview = "TCPview";


        static string Connections = "Connections";
        static string IpInfos = "IpInfos";



        public static string PathDisk()
        {
            return @"{Disque}:\";
        }
        public static string PathFolder()
        {
            //{ }\
            return @"{Disque}:\{Dossier}\";
        }
        //
        public static string PathSysmon()
        {
            //{ }\
            return @"{Disque}:\{Sysmon}\";
        }
        public static string PathSysmonEula()
        {
            //{ }\
            return @"{Disque}:\{Sysmon}\Eula.txt";
        }
        public static string PathSysmonConfig()
        {
            //{ }\
            return @"{Disque}:\{Sysmon}\config.xml";
        }
        //
        //public static string PathSysmon()
        //{
        //    //{ }\
        //    return @"{Disque}:\{Sysmon}\";
        //}
        //public static string PathSysmonEula()
        //{
        //    //{ }\
        //    return @"{Disque}:\{Sysmon}\Eula.txt";
        //}
        //
        public static string PathDatabasesFolder()
        {
            return @"{Disque}:\{Dossier}\{Databases}\";
        }
        public static string PathFilesFolder()
        {
            return @"{Disque}:\{Dossier}\{Files}\";
        }
        public static string PathDatabaseFolder()
        {
            return @"{Disque}:\{Dossier}\{Folders}\";
        }
        //
        public static string PathTrustedDatabase()
        {
            return @"{Disque}:\{Dossier}\{Folders}\{TrustedDb}";
        }
        public static string PathViewDatabase()
        {
            return @"{Disque}:\{Dossier}\{Folders}\{ViewDatabase}";
        }
        //
        public static string PathCacheHostnameFile()
        {
            return @"{Disque}:\{Dossier}\{Files}\{CacheHostnameList}.txt";
        }
        public static string PathConnectionIpFile()
        {
            return @"{Disque}:\{Dossier}\{Files}\{ConnectionIpList}.txt";
        }
        public static string PathDnsCacheFile()
        {
            return @"{Disque}:\{Dossier}\{Files}\{DnsCache}.txt";
        }
        public static string PathHostnameRequestFile()
        {
            return @"{Disque}:\{Dossier}\{Files}\{HostnameRequestList}.txt";
        }
        public static string PathTrustedHostnameFile()
        {
            return @"{Disque}:\{Dossier}\{Files}\{TrustedHostnameList}.txt";
        }
    }
}