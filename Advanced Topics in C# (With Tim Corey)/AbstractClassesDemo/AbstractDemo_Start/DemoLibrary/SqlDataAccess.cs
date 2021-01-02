using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class SqlDataAccess : DataAccessBaseClass
    {
        public override string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String Directly from SQL DATA ACCESS");
            return "testConnectionString";
        }

        public override void LoadData(string sql)
        {
            Console.WriteLine("Loading Microsoft SQL Data");
        }

        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving data to Microsoft SQL Server");
        }
    }
}
