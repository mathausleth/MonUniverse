using System.Data;

namespace MonUniverse.MonUniverseFunction
{
    public static class MonUniverseDatabase
    {
        private static Dictionary<Enums.Datas, DataTable> TABLES = [];

        public static void LoadCorellationDatabase()
        {

        }

        public static void LoadTrustedDatabase()
        {

        }

        public static void LoadViewDatabase()
        {

        }

        public static void LoadNotificationsDatabase()
        {

        }
        public static DataTable LoadFileAsTable(string filerpath)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Content", typeof(string));

            foreach (string line in File.ReadLines(filerpath))
            {
                dataTable.Rows.Add(line);
            }
            return dataTable;
        }
    }
}