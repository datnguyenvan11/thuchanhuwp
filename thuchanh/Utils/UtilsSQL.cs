using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuchanh.Utils
{
    class UtilsSQL
    {
        private const string DatabaseName = "thuchanh.db";

        private static UtilsSQL _instance;
        public SQLiteConnection Connection { get; }

        public static UtilsSQL GetIntances()
        {
            if (_instance == null)
            {
                _instance = new UtilsSQL();
            }
            return _instance;
        }

        private UtilsSQL()
        {
            Connection = new SQLiteConnection(DatabaseName);
            CreateTables();
        }

        private void CreateTables()
        {
            string sql = @"CREATE TABLE IF NOT EXISTS Contact (Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,Name VARCHAR( 140 ),Phone VARCHAR( 140 ) UNIQUE);";
            using (var statement = Connection.Prepare(sql))
            {
                statement.Step();
            }
        }
    }
}
