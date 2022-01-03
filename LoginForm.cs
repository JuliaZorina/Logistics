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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.passwordField.AutoSize = false;
            this.passwordField.Size = new Size(this.passwordField.Size.Width, 35);
        }

        public static string id;
        private void loginButton_Click(object sender, EventArgs e)
        {
            string conString = "server=localhost;user id=root;database=persons;persistsecurityinfo=True;password=root";
            string loginQuery = "SELECT * FROM persons WHERE pLogin= '" + this.loginField.Text + "' and pPassword = '" + this.passwordField.Text + "'";
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(loginQuery, conn);
            MySqlDataReader reader;
            int count = 0;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    count += 1;
                }
                conn.Close();
                if (count >= 1)
                {
                    MessageBox.Show("Authenticated User");
                    string sql = "SELECT pPersonID FROM persons WHERE pLogin= '" + this.loginField.Text + "' and pPassword = '" + this.passwordField.Text + "'";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    conn.Open();
                    id = command.ExecuteScalar().ToString();
                    CreateOrderForm cform = new CreateOrderForm();
                    cform.Show();
                    this.Hide();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("User not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Get the Values due to" + ex);
            }

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            RegistrationForm rform = new RegistrationForm();
            rform.Show();
            this.Hide();
        }
    }
}
