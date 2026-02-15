using Microsoft.Data.Sqlite;
using MonUniverse.MonUniverseData.Tables;
using System.ComponentModel;
namespace MonUniverse.MonUniverseData
{
    internal class DataTables
    {
        public static BindingList<DnsCache> dnsCache = new BindingList<DnsCache>();
        public static BindingList<ExeCorellation> exeCorellation = new BindingList<ExeCorellation>();
        public static BindingList<IpCorellation> ipCorellation = new BindingList<IpCorellation>();
        public static BindingList<RequestsLog> requestsLog = new BindingList<RequestsLog>();
        public static BindingList<Corellation> corellations = new BindingList<Corellation>();

        static DataTables()
        {
            LoadExeCorellation();
            LoadIpCorellation();
            LoadDnsCache();
            LoadRequestsLog();
            //foreach (IpCorellation item in ipCorellation)
            //{
            //    corellations.Add(new Corellation(item));
            //}
        }

        public static void LoadExeCorellation()
        {
            string connectionString = "Data Source=D:\\Mon\\Databases\\TrustedDatabase";
            using var connection = new SqliteConnection(connectionString);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"SELECT Id, Hash, Exe FROM ExeCorellation";
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetString(reader.GetOrdinal("Id"));
                string hash = reader.GetString(reader.GetOrdinal("Hash"));
                string exe = reader.GetString(reader.GetOrdinal("Exe"));
                ExeCorellation line = new ExeCorellation(id, hash, exe);
                exeCorellation.Add(line);
            }
        }

        public static void LoadIpCorellation()
        {
            string connectionString = "Data Source=D:\\Mon\\Databases\\TrustedDatabase";
            using var connection = new SqliteConnection(connectionString);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"SELECT ASNumber, Hash, HostName, IP FROM IpCorellation";
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                string asn = reader.GetString(reader.GetOrdinal("ASNumber"));
                string hash = reader.GetString(reader.GetOrdinal("Hash"));
                string hostname = reader.GetString(reader.GetOrdinal("HostName"));
                string ip = reader.GetString(reader.GetOrdinal("IP"));
                IpCorellation line = new IpCorellation(asn, hash, hostname, ip);
                ipCorellation.Add(line);
            }
        }

        public static void LoadDnsCache()
        {
            string connectionString = "Data Source=D:\\Mon\\Databases\\ViewDatabase";
            using var connection = new SqliteConnection(connectionString);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"SELECT Hash, HostName, IP FROM DnsCache";
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                string hash = reader.GetString(reader.GetOrdinal("Hash"));
                string hostname = reader.GetString(reader.GetOrdinal("HostName"));
                string ip = reader.GetString(reader.GetOrdinal("IP"));
                DnsCache line = new DnsCache(hash, hostname, ip);
                dnsCache.Add(line);
            }
        }

        public static void LoadRequestsLog()
        {
            string connectionString = "Data Source=D:\\Mon\\Databases\\ViewDatabase";
            using var connection = new SqliteConnection(connectionString);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"SELECT DestinationIP, DestinationPort, Exe, FullPath, Hash FROM RequestsLog";
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                string destIp = reader.GetString(reader.GetOrdinal("DestinationIP"));
                string destPort = reader.GetString(reader.GetOrdinal("DestinationPort"));
                string exe = reader.GetString(reader.GetOrdinal("Exe"));
                string fullpath = reader.GetString(reader.GetOrdinal("FullPath"));
                string hash = reader.GetString(reader.GetOrdinal("Hash"));
                RequestsLog line = new RequestsLog(destIp, destPort, exe, fullpath, hash);
                requestsLog.Add(line);
            }
        }
    }
}