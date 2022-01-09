using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticProgram
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                string connectString = "server=localhost;user id=root;database=persons;persistsecurityinfo=True;password=root";
                //MySQl connection
                MySqlConnection conn = new MySqlConnection(connectString);
                MySqlDataAdapter madapter = new MySqlDataAdapter();
                madapter.SelectCommand = new MySqlCommand("Select * From personstable", conn);
                MySqlCommandBuilder cmd = new MySqlCommandBuilder(madapter);
                //Open the connection
                conn.Open();
                DataSet ds = new DataSet();
                MessageBox.Show("Connection with the MySQL DataBase Established");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection with the MySQL DataBase not Established" + ex);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

    }   
}
