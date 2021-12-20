using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LogisticProgram
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void registrateButton_Click(object sender, EventArgs e)
        {
            var id = Guid.NewGuid().ToString();
            string connectString = "server=localhost;user id=root;database=persons;persistsecurityinfo=True;password=root";
            string insertDataQuery = "INSERT INTO persons (pName,pSureName,pLogin,pPassword,pPersonID) values ('" + this.nameTextBox.Text+"'," +
                "'"+this.surenameTextBox.Text + "','"+this.loginTextBox.Text + "','"+this.passwordTextBox.Text + "','" + id + "')";
            MySqlConnection conn = new MySqlConnection(connectString);
            MySqlCommand cmd = new MySqlCommand(insertDataQuery, conn);
            MySqlDataReader dataReader;
            try
            {
                conn.Open();
                dataReader = cmd.ExecuteReader();
                MessageBox.Show("Person Register Successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Unable to Insert the Data due to" + ex);
            }

            LoginForm lform = new LoginForm();
            lform.Show();
            this.Hide();
        }
    }
}
