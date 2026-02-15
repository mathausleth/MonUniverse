namespace MonUniverse.MonUniverseData.Tables
{
    public class ExeCorellation
    {
        public string Id { get; set; } = string.Empty;
        public string Hash { get; set; } = string.Empty;
        public string Exe { get; set; } = string.Empty;

        public ExeCorellation(string id, string hash, string exe)
        {
            Id = id;
            Hash = hash;
            Exe = exe;
        }
    }
}