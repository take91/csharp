using System;
using Oracle.ManagedDataAccess.Client;
namespace Oracle
{
    class Program
    {
        static void Main(string[] args)
        {
            OracleConnection thisConnection = new OracleConnection(@"data source=topcredu;User ID=scott;Password=tiger");
            thisConnection.Open();
            OracleDataAdapter thisAdapter = new
            OracleDataAdapter("SELECT * from emp", thisConnection);
            OracleCommandBuilder thisBuilder = new OracleCommandBuilder(thisAdapter);
            Console.WriteLine("SQL SELECT Command is:\n{0}\n",
            thisAdapter.SelectCommand.CommandText);
            OracleCommand updateCommand = thisBuilder.GetUpdateCommand();
            Console.WriteLine("SQL UPDATE Command is:\n{0}\n",
            updateCommand.CommandText);
            OracleCommand insertCommand = thisBuilder.GetInsertCommand();
            Console.WriteLine("SQL INSERT Command is:\n{0}\n",
            insertCommand.CommandText);
            OracleCommand deleteCommand = thisBuilder.GetDeleteCommand();
            Console.WriteLine("SQL DELETE Command is:\n{0}", deleteCommand.CommandText);
            thisConnection.Close();
        }
    }
}
