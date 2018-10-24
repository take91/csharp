using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OracleTest
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = null;
        OleDbDataAdapter adapter = null;
        DataSet ds = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ds = new DataSet("emp");

                string conStr = "Provider=OraOLEDB.Oracle;data source=topcredu;User ID=scott;Password=tiger";
                conn = new OleDbConnection(conStr);
                conn.Open();

                OleDbCommand command = new OleDbCommand("insert into emp(empno,ename) values(4242,'FortyTwo')", conn);
                command.ExecuteNonQuery();

                adapter = new OleDbDataAdapter("select * from emp", conn);
                adapter.Fill(ds,"EMP");
                dataGridView1.DataSource = ds.Tables["EMP"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "emp Table Loading Error");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
