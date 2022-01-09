using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        int index = 1;
        private void refreshOrders_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                panel1.Controls[i].Enabled = false;
                panel1.Controls[i].Dispose();
                i--;
            }
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
                    newOrder.Multiline = true;
                    string bufer = "Имя заказа: " + reader["oName"].ToString() + "; Адрес: " + reader["oAddress"].ToString() + 
                        "; Стоимость заказа: " + reader["oCost"].ToString() + " рублей;" + " Статус заказа: " + reader["oStatus"].ToString();
                    newOrder.Text = bufer;
                    newOrder.ReadOnly = true;
                    newOrder.Width = 700;
                    newOrder.Height = 30;
                    if (index > 1)
                    {
                        newOrder.Location = new Point(oldbbox.Location.X, oldbbox.Location.Y + oldbbox.Height + 15);
                    }
                    else
                    {
                        newOrder.Location = new Point(19, 12);
                    }
                    panel1.Controls.Add(newOrder);
                    oldbbox = newOrder;
                    index++;
                }
                conn.Close();
                index = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Get the Values due to" + ex);
            }  
        }
    }
}