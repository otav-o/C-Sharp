using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            SqliteDataAccess da = new SqliteDataAccess();

            DataAccessBaseClass da3 = new SqliteDataAccess();



            // DataAccessBaseClass da2 = new DataAccessBaseClass(); // no sense! Why would you instantiate from this class?


            List<DataAccessBaseClass> databases = new List<DataAccessBaseClass>()
            {
                new SqlDataAccess(),
                new SqliteDataAccess()
            };

            foreach (var db in databases)
            {
                db.LoadConnectionString("demo");
                db.LoadData("select * from table");
                db.SaveData("insert into table");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
