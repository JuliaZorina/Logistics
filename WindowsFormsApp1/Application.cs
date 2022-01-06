using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Application : Form
    {
        public Application()
        {
            InitializeComponent();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            CargoPlace form1 = new CargoPlace();
            form1.Show();
            this.Hide();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Orders form4 = new Orders();
            form4.Show();
            this.Hide();
        }

        int index = 1;
        List<string> idList = new List<string>();

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < panel2.Controls.Count; i++)
            {
                panel2.Controls[i].Enabled = false;
                panel2.Controls[i].Dispose();
                i--;
            }
            string conString = "server=localhost;user id=root;database=persons;persistsecurityinfo=True;password=root";
            string orderQuery = "SELECT * FROM orders WHERE oStatus= 'Заказ обрабатывается'";
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(orderQuery, conn);
            MySqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                TextBox oldbbox = myOrdersTextBox;
                while (reader.Read())
                {
                    TextBox newOrder = new TextBox();
                    newOrder.Multiline = true;
                    string bufer = "Имя заказа: " + reader["oName"].ToString() + "; Адрес: " + reader["oAddress"].ToString() +
                        "; Стоимость заказа: " + reader["oCost"].ToString() + " рублей;" + " Вес: " + reader["oWeigth"].ToString() + " кг.";
                    newOrder.Text = bufer;
                    idList.Add(reader["oOrderID"].ToString());
                    newOrder.Name = "Order" + index;
                    newOrder.ReadOnly = true;
                    newOrder.Width = 350;
                    newOrder.Height = 30;
                    if (index > 1)
                    {
                        newOrder.Location = new Point(oldbbox.Location.X, oldbbox.Location.Y + oldbbox.Height + 15);
                    }
                    else
                    {
                        newOrder.Location = new Point(19, 12);
                    }
                    panel2.Controls.Add(newOrder);
                    oldbbox = newOrder;

                    Button acceptButton = new Button();
                    acceptButton.Width = 100;
                    acceptButton.Height = 30;
                    acceptButton.Location = new Point(newOrder.Location.X + newOrder.Width + 5, newOrder.Location.Y);
                    acceptButton.Name = index.ToString();
                    acceptButton.Text = "Принять заказ";
                    acceptButton.Click += acceptButtonOnClick;
                    panel2.Controls.Add(acceptButton);

                    Button rejectButton = new Button();
                    rejectButton.Width = 100;
                    rejectButton.Height = 30;
                    rejectButton.Location = new Point(acceptButton.Location.X + acceptButton.Width + 5, acceptButton.Location.Y);
                    rejectButton.Name = index.ToString();
                    rejectButton.Text = "Отказаться";
                    rejectButton.Click += rejectButtonOnClick;
                    panel2.Controls.Add(rejectButton);

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

        private void acceptButtonOnClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            string conString = "server=localhost;user id=root;database=persons;persistsecurityinfo=True;password=root";
            string orderQuery = "UPDATE orders SET oStatus = 'Заказ принят в доставку' WHERE oOrderID= '" + idList[int.Parse(button.Name) - 1] + "'";
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(orderQuery, conn);
            MySqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("Заказ принят.");
                Application form2 = new Application();
                form2.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The order was not accepted." + ex);
            }
        }

        private void rejectButtonOnClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            string conString = "server=localhost;user id=root;database=persons;persistsecurityinfo=True;password=root";
            string orderQuery = "DELETE FROM orders WHERE oOrderID= '" + idList[int.Parse(button.Name) - 1] + "'";
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(orderQuery, conn);
            MySqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("Заказ удалён.");
                Application form2 = new Application();
                form2.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The order was not rejected." + ex);
            }
        }

    }
}