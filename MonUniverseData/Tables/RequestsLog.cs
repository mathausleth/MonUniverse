namespace MonUniverse.MonUniverseData.Tables
{
    public class RequestsLog
    {
        public string DestinationIp { get; set; } = string.Empty;
        public string DestinationPort { get; set; } = string.Empty;
        public string Exe { get; set; } = string.Empty;
        public string FullPath { get; set; } = string.Empty;
        public string Hash { get; set; } = string.Empty;

        public RequestsLog(string destIp, string destPort, string exe, string fullPath, string hash)
        {
            DestinationIp = destIp;
            DestinationPort = destPort;
            Exe = exe;
            FullPath = fullPath;
            Hash = hash;
        }
    }
}