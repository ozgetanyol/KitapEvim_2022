using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEviDAL
{
    public class KitapeviHelperSQL
    {
        //SqlConnection
        private static SqlConnection myConnection()
        {
            return new SqlConnection(dataConnections.Get_MsSqlConnectionString);
        }
        //Farklı Providerlar ile kullanımı
        private static SqlConnection myConnection(string myProvider)
        {

            switch (myProvider)
            {
                case "sql": return new SqlConnection(dataConnections.Get_MsSqlConnectionString); break;
                case "oracle": return new SqlConnection(dataConnections.Get_OracleConnectionString); break;
                default: return new SqlConnection(dataConnections.Get_MySqlConnectionString); break;
            }
        }


        //SqlCommand
        public static SqlCommand mySqlCommand(string mySqcScript,string myCommandType, SqlParameter[] myParameters)
        {
            SqlCommand cmd = new SqlCommand(mySqcScript, myConnection());
            //SqlCommand cmd = new SqlCommand(mySqcScript,myConnection("sql"));
            if (myCommandType=="sp")
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
            }

            if (myParameters != null)
            {
               cmd.Parameters.AddRange(myParameters);
            }

            return cmd;

        }

        //Execute Metodlar
        //SqlCommand, ExecuteNonQuery
        public static int myExecuteNonQuery(string spName, SqlParameter[] cmdParams, string myCommandType)
        {
            SqlCommand cmd = mySqlCommand(spName, myCommandType, cmdParams);
                
            cmd.Connection.Open();
            int donenSatir =cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            return donenSatir;
        }


        //SqlCommand, ExecuteScalar
        public static object myExecuteScalar(string spName, SqlParameter[] cmdParams, string myCommandType)
        {
            SqlCommand cmd = mySqlCommand(spName, myCommandType, cmdParams);
            cmd.Connection.Open();
            object donenDeger = cmd.ExecuteScalar();
            cmd.Connection.Close();
            return donenDeger;
        }

        //SqlCommand, ExecuteReader
        public static SqlDataReader myExecuteReader(string spName, SqlParameter[] cmdParams, string myCommandType)
        {
            SqlCommand cmd = mySqlCommand(spName, myCommandType, cmdParams);
            cmd.Connection.Open();
            SqlDataReader okuyucu = cmd.ExecuteReader();
            cmd.Connection.Close();
            return okuyucu;
        }



    }
}
