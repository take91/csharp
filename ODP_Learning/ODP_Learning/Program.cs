using System;
using System.Data.OleDb;
using Oracle.ManagedDataAccess.Client;
namespace ODP_Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "data source=topcredu;user id=scott; password=tiger;Provider=OraOleDB.Oracle";

            OleDbConnection Conn = new OleDbConnection(str);
            OleDbCommand Comm = new OleDbCommand();
            Comm.Connection = Conn;

            try
            {
                Conn.Open();
                Comm.CommandText = "SELECT ENAME FROM EMP";
                OleDbDataReader reader = Comm.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(reader.GetOrdinal("ENAME")));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Conn.Close();
            }
        }
    }
}
