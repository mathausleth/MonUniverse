namespace MonUniverse.MonUniverseData.Tables
{
    internal class Corellation
    {
        public string Exesr { get; set; } //from Corellation by Hash
        public string IP { get; set; } = string.Empty;
        public string HostNameInfo { get; set; } = string.Empty;
        public string HostNames { get; set; } //from DnsCache by IP
        public string ASN { get; set; } = string.Empty;
        
        public static BindingSource getA()
        {
            HashSet<Tuple<string, string>> liste = [];
            var rows = from exes in DataTables.requestsLog
                       select new
                       {
                           Exe = exes?.Exe,
                           IP = exes?.DestinationIp,
                       };
            var next = from exes in DataTables.exeCorellation.DefaultIfEmpty()
                       join ips in DataTables.ipCorellation.DefaultIfEmpty()
                       on exes?.Hash equals ips?.Hash
                       select new
                       {
                           Exe = exes?.Exe,
                           IP = ips?.IP,
                       };
            foreach (var item in rows)
            {
                liste.Add(new Tuple<string, string>(item.Exe, item.IP));
            }
            foreach (var item in next)
            {
                liste.Add(new Tuple<string, string>(item.Exe, item.IP));
            }
            var s = from allip in liste
                    join ips in DataTables.ipCorellation.DefaultIfEmpty()
                    on allip.Item2 equals ips?.IP
                    into gS
                    from ase in gS.DefaultIfEmpty()
                    join cache in DataTables.dnsCache.DefaultIfEmpty()
                    on allip.Item2 equals cache?.IP
                    into gT
                    from asea in gT.DefaultIfEmpty()
                    select new
                    {
                        Exe = allip.Item1,
                        Ip = allip.Item2,
                        Asked = asea?.HostName,
                        Resolv = ase?.HostName,
                        ASN = ase?.ASNumber
                    };
            BindingSource src = new BindingSource();
            src.DataSource = s;
            return src;
        }
    }
}