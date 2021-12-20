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
    public partial class CreateOrderForm : Form
    {
        public CreateOrderForm()
        {
            InitializeComponent();
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            if ((int.Parse(lengthTextBox.Text) > 80) || (int.Parse(widthTextBox.Text) > 80) || (int.Parse(heigthTextBox.Text) > 60))
            {
                MessageBox.Show("Мы не можем принять заказ, из-за несоответствия требованиям.");
            }

            else
            {
                double weigth = 200 * double.Parse(weightTextBox.Text);
                MessageBox.Show($"Стоимость вашей доставки: {Math.Round(weigth, 2)} рублей.");

                string connectString = "server=localhost;user id=root;database=persons;persistsecurityinfo=True;password=root";
                string insertDataQuery = "INSERT INTO orders (oName,oWeigth,oAddress,oLength,oWidth,oHeigth,oCost,oPersonID) values ('" + this.nameTextBox.Text + "'," +
                    "'" + this.weightTextBox.Text + "','" + this.addressTextBox.Text + "','" + this.lengthTextBox.Text + "','" + this.widthTextBox.Text + "'," +
                    "'" + this.heigthTextBox.Text + "','" + Math.Round(weigth, 2) + "','" + LoginForm.id + "')";
                MySqlConnection conn = new MySqlConnection(connectString);
                MySqlCommand cmd = new MySqlCommand(insertDataQuery, conn);
                MySqlDataReader dataReader;
                try
                {
                    conn.Open();
                    dataReader = cmd.ExecuteReader();
                    MessageBox.Show("The order has been successfully placed.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The order was not created." + ex);
                }
                nameTextBox.Text = null; weightTextBox.Text = null; addressTextBox.Text = null; 
                lengthTextBox.Text = null; widthTextBox.Text = null; heigthTextBox.Text = null;

            }
        }

        private void myOrdersButton_Click(object sender, EventArgs e)
        {
            MyOrders mform = new MyOrders();
            mform.Show();
            this.Hide();
        }
    }
}
