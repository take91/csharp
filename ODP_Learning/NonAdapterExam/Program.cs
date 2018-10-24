using System;
using System.Data.OleDb;
namespace NonAdapterExam
{
    class Program
    {
        static OleDbConnection cn;

        static void Main(string[] args)
        {
            OleCn();
            Openning();

            Console.WriteLine("The Original Table");
            Output();

            Console.WriteLine("Added Table");
            Adding();
            Output();

            Console.WriteLine("Modified Table");
            Modifying();
            Output();

            Console.WriteLine("Deleted Table");
            Deleting();
            Output();

            Closing();
        }

        public static void OleCn()
        {
            string str = "data source=topcredu;user id=scott; password=tiger;Provider=OraOleDB.Oracle";
            cn = new OleDbConnection(str);
        }

        public static void Openning() { cn.Open(); }
        public static void Output()
        {
            string sql = "SELECT empno id, ename name FROM emp";
            OleDbCommand cmd = new OleDbCommand(sql, cn);
            OleDbDataReader dr = cmd.ExecuteReader();

            Console.Write("\n");
            while (dr.Read())
            {
                Console.WriteLine("{0,-10}\t{1,-10}", dr[0].ToString().Trim(), dr[1].ToString().Trim());
            }
            Console.Write("\n");
            dr.Close();
        }

        public static void Adding()
        {
            try
            {
                string sqladd = "INSERT INTO emp(empno,ename) VALUES(8900,'홍길길')";
                OleDbCommand cmdAdd = new OleDbCommand(sqladd, cn);

                int rowsadded = cmdAdd.ExecuteNonQuery();
                Console.WriteLine("Number of rows added: " + rowsadded);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }


        public static void Modifying()
        {
            try
            {
                string sqlmodify = "UPDATE emp SET ename = '홍낄낄' WHERE empno=8900";
                OleDbCommand cmdupdate = new OleDbCommand(sqlmodify, cn);
                int rows = cmdupdate.ExecuteNonQuery();
                Console.WriteLine("Number of rows modified: " + rows);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }


        public static void Deleting()
        {
            try
            {
                string sqldelete = "DELETE FROM emp WHERE empno=8900";
                OleDbCommand cmddelete = new OleDbCommand(sqldelete, cn);
                int rows = cmddelete.ExecuteNonQuery();
                Console.WriteLine("Number of rows deleted: " + rows);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void Closing()
        {
            cn.Close();
        }

    }
}
