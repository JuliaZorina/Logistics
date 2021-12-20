using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticProgram
{
    public partial class MyOrders : Form
    {

        public MyOrders()
        {
            InitializeComponent();
            
            
        }

        private void toCreateOrderForm_Click(object sender, EventArgs e)
        {
            CreateOrderForm cform = new CreateOrderForm();
            cform.Show();
            this.Hide();
        }

        private void refreshOrders_Click(object sender, EventArgs e)
        {
            string conString = "server=localhost;user id=root;database=persons;persistsecurityinfo=True;password=root";
            string orderQuery = "SELECT * FROM orders WHERE oPersonID= '" + LoginForm.id + "'";
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(orderQuery, conn);
            MySqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                TextBox oldbbox = myOrdersTextBox;
                List<string> info = new List<string>();
                while (reader.Read())
                {
                    TextBox newOrder = new TextBox();
                    conn.Open();
                    string bufer = cmd.ExecuteScalar().ToString();
                    conn.Close();
                    newOrder.Text = bufer;
                    newOrder.ReadOnly = true;
                    newOrder.Width = 600;
                    newOrder.Height = 30;
                    newOrder.Location = new Point(oldbbox.Location.X, oldbbox.Location.Y + oldbbox.Height + 10);
                    this.Controls.Add(newOrder);
                    oldbbox = newOrder;
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Get the Values due to" + ex);
            }

            
        }
    }
}
