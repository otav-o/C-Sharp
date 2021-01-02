using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public abstract class DataAccessBaseClass
    {
        public virtual string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String");
            return "testConnectionString";
        }

        public abstract void LoadData(string sql);
        // declared as abstract and without code: similar as interface
        // to implement this we have to use override

        public abstract void SaveData(string sql);
        // there is no code here because the logic can be different
    }
}
