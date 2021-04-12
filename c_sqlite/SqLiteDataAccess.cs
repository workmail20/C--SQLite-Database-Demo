using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Linq;
using Dapper;
using System.Threading.Tasks;

namespace c_sqlite
{
    public class SqLiteDataAccess
    {
        public static List<PersonModel> LoadPersons()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PersonModel>("select * from Persons", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SavePerson(PersonModel person)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Persons (FirstName, SecondName) values (@FirstName, @SecondName)", person);
            }

        }

        private static string LoadConnectionString(string id = "Default")
        {
            return "Data Source =.\\main_db.db; Version = 3;";
        }
    }
}
