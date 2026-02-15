using MonUniverse.Enums;
using MonUniverse.MonUniverseData;
using MonUniverse.MonUniverseData.Tables;
using MonUniverse.MonUniverseFunction;
using System.Security.Policy;
using Windows.Networking;
namespace MonUniverse.MonUniverseUI
{
    public partial class MonUniverseUI
    {

        private void CorrelationButtonClick(object? sender, EventArgs e)
        {
            BindingSource src = new BindingSource();
            src.DataSource = Corellation.getA();
            DataForm df = new DataForm(src);
            df.Show();
        }

        private void TrustedDbButtonClick(object? sender, EventArgs e)
        {
            var rows = from exes in DataTables.exeCorellation.DefaultIfEmpty()
                       join ips in DataTables.ipCorellation.DefaultIfEmpty()
                       on exes?.Hash equals ips?.Hash
                       join cache in DataTables.dnsCache.DefaultIfEmpty()
                       on ips?.IP equals cache?.IP
                       select new {
                            Exe = exes?.Exe,
                            HostName = cache?.HostName,
                            DnsResult = ips?.HostName,
                            IP = ips?.IP,
                            ASNumber = ips?.ASNumber
                        };
            BindingSource src = new BindingSource();
            src.DataSource = rows;
            DataForm df = new DataForm(src);
            df.Show();
        }

        private void ViewDbButtonClick(object? sender, EventArgs e)
        {
            var rows = from exes in DataTables.requestsLog
                       join cache in DataTables.dnsCache
                       on exes.DestinationIp equals cache.IP
                       into gS
                       from cache in gS
                       join ips in DataTables.ipCorellation.DefaultIfEmpty()
                       on cache?.IP equals ips?.IP
                       into gT
                       from tt in gT.DefaultIfEmpty()
                       select new
                       {
                           Exe = exes?.Exe,
                           HostName = cache?.HostName,
                           DnsResult = tt?.HostName,
                           IP = cache?.IP,
                           Port = exes?.DestinationPort,
                           FullPath = exes?.FullPath
                       };
            BindingSource src = new BindingSource();
            src.DataSource = rows;
            DataForm df = new DataForm(src);
            df.Show();
        }

        private void ClearNotificationButtonClick(object? sender, EventArgs e)
        {

        }

        private void ShowListButtonsClick()
        {
            foreach (var item in showListButtons)
            {
                item.Value.Click += (object? sender, EventArgs e) =>
                {
                    BindingSource src = new BindingSource();
                    src.DataSource = MonUniverseFunction.MonUniverseDatabase.LoadFileAsTable(@$"D:\Mon\Files\{item.Key}.txt");
                    DataForm df = new DataForm(src);
                    df.Show();
                };
            }
        }
    }
}