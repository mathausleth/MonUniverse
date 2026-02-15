namespace MonUniverse.MonUniverseData.Tables
{
    public class IpCorellation
    {
        public string ASNumber { get; set; } = string.Empty;
        public string Hash { get; set; } = string.Empty;
        public string HostName { get; set; } = string.Empty;
        public string IP { get; set; } = string.Empty;

        public IpCorellation (string asn, string hash, string hostname, string ip)
        {
            ASNumber = asn;
            Hash = hash;
            HostName = hostname;
            IP = ip;
        }
    }
}