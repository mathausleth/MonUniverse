namespace MonUniverse.MonUniverseData.Tables
{
    public class DnsCache
    {
        public string Hash { get; set; }
        public string HostName { get; set; }
        public string IP { get; set; }

        public DnsCache(string hash, string hostname, string ip)
        {
            Hash = hash;
            HostName = hostname;
            IP = ip;
        }
    }
}