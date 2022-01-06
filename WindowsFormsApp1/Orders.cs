using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Application form2 = new Application();
            form2.Show();
            this.Hide();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            CargoPlace form1 = new CargoPlace();
            form1.Show();
            this.Hide();
        }

        int index = 1;
        List<string> idList = new List<string>();

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < myOrdersTextBox.Controls.Count; i++)
            {
                myOrdersTextBox.Controls[i].Enabled = false;
                myOrdersTextBox.Controls[i].Dispose();
                i--;
            }
            string conString = "server=localhost;user id=root;database=persons;persistsecurityinfo=True;password=root";
            string orderQuery = "SELECT * FROM orders WHERE oStatus= 'Заказ принят в доставку' OR oStatus= 'Заказ доставляется' OR oStatus= 'Заказ доставлен'";
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
                    idList.Add(reader["oOrderID"].ToString());
                    newOrder.Name = "Order" + index;
                    newOrder.ReadOnly = true;
                    newOrder.Width = 600;
                    newOrder.Height = 30;
                    if (index > 1)
                    {
                        newOrder.Location = new Point(oldbbox.Location.X, oldbbox.Location.Y + oldbbox.Height + 45);
                    }
                    else
                    {
                        newOrder.Location = new Point(19, 12);
                    }
                    myOrdersTextBox.Controls.Add(newOrder);
                    oldbbox = newOrder;

                    Button condition1Button = new Button();
                    condition1Button.Width = 175;
                    condition1Button.Height = 30;
                    condition1Button.Location = new Point(newOrder.Location.X, newOrder.Location.Y + newOrder.Height + 5);
                    condition1Button.Name = index.ToString();
                    condition1Button.Text = "Заказ доставляется";
                    condition1Button.Click += condition1ButtonOnClick;
                    if (reader["oStatus"].ToString() == "Заказ доставляется") { condition1Button.BackColor = Color.Gray; }
                    myOrdersTextBox.Controls.Add(condition1Button);

                    Button condition2Button = new Button();
                    condition2Button.Width = 175;
                    condition2Button.Height = 30;
                    condition2Button.Location = new Point(condition1Button.Location.X + condition1Button.Width + 5, condition1Button.Location.Y);
                    condition2Button.Name = index.ToString();
                    condition2Button.Text = "Заказ доставлен";
                    condition2Button.Click += condition2ButtonOnClick;
                    if (reader["oStatus"].ToString() == "Заказ доставлен") { condition2Button.BackColor = Color.Gray; }
                    myOrdersTextBox.Controls.Add(condition2Button);

                    Button closeButton = new Button();
                    closeButton.Width = 175;
                    closeButton.Height = 30;
                    closeButton.Location = new Point(condition2Button.Location.X + condition2Button.Width + 5, condition2Button.Location.Y);
                    closeButton.Name = index.ToString();
                    closeButton.Text = "Закрыть заказ";
                    closeButton.Click += closeButtonOnClick;
                    myOrdersTextBox.Controls.Add(closeButton);

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

        
        private void condition1ButtonOnClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            string conString = "server=localhost;user id=root;database=persons;persistsecurityinfo=True;password=root";
            string orderQuery = "UPDATE orders SET oStatus = 'Заказ доставляется' WHERE oOrderID= '" + idList[int.Parse(button.Name) - 1] + "'";
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(orderQuery, conn);
            MySqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("Состояние заказа изменено.");
                Orders form4 = new Orders();
                form4.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The order was not accepted." + ex);
            }
        }

        private void condition2ButtonOnClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            string conString = "server=localhost;user id=root;database=persons;persistsecurityinfo=True;password=root";
            string orderQuery = "UPDATE orders SET oStatus = 'Заказ доставлен' WHERE oOrderID= '" + idList[int.Parse(button.Name) - 1] + "'";
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(orderQuery, conn);
            MySqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("Состояние заказа изменено.");
                Orders form4 = new Orders();
                form4.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The order was not accepted." + ex);
            }
        }

        private void closeButtonOnClick(object sender, EventArgs eventArgs)
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
                MessageBox.Show("Заказ закрыт.");
                Orders form4 = new Orders();
                form4.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The order was not rejected." + ex);
            }
        }

    }
}