using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEviDAL
{
    public static class dataConnections// Static olması durumu, sınıfın instance ını oluşturmadan kullanılmasına olanak verir.
    {

        //MSSQLServer Bağlantı stringi
        public static string Get_MsSqlConnectionString
        {
            get{ return "Server=.;Database=KitapEviDB;Trusted_Connection=True;"; }
        }

        //Oracle Server Bağlantı stringi
        public static string Get_OracleConnectionString
        {
            get { return "Data Source=KitapEviORACLE;Integrated Security=yes;"; }
        }

        //MySql Server Bağlantı stringi
        public static string Get_MySqlConnectionString
        {
            get { return "Server=mySqlServerim;Database=kitapeviMySql;Uid=111;Pwd=111;"; }
        }


    }
}
