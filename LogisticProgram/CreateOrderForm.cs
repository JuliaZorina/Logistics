using LogLibrary;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace LogisticProgram
{
    public partial class CreateOrderForm : Form
    {
        private readonly FormsViewModel_CreateOrderForm viewModel = new FormsViewModel_CreateOrderForm();
        public CreateOrderForm()
        {
            InitializeComponent();

            nameTextBox.DataBindings.Add("Text", viewModel, nameof(FormsViewModel_CreateOrderForm.NameTextBox));
            weightTextBox.DataBindings.Add("Text", viewModel, nameof(FormsViewModel_CreateOrderForm.WeightTextBox));
            addressTextBox.DataBindings.Add("Text", viewModel, nameof(FormsViewModel_CreateOrderForm.AddressTextBox));
            lengthTextBox.DataBindings.Add("Text", viewModel, nameof(FormsViewModel_CreateOrderForm.LengthTextBox));
            widthTextBox.DataBindings.Add("Text", viewModel, nameof(FormsViewModel_CreateOrderForm.WidthTextBox));
            heigthTextBox.DataBindings.Add("Text", viewModel, nameof(FormsViewModel_CreateOrderForm.HeigthTextBox));
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                nameTextBox.Text = viewModel.GetName().ToString();
                weightTextBox.Text = viewModel.GetWeight().ToString();
                addressTextBox.Text = viewModel.GetAddress().ToString();
                lengthTextBox.Text = viewModel.GetLength().ToString();
                widthTextBox.Text = viewModel.GetWidth().ToString();
                heigthTextBox.Text = viewModel.GetHeigth().ToString();

                if ((int.Parse(lengthTextBox.Text) > 80) || (int.Parse(widthTextBox.Text) > 80) || (int.Parse(heigthTextBox.Text) > 60))
                {
                    MessageBox.Show("Мы не можем принять заказ, из-за несоответствия требованиям.");
                }

                else
                {
                    var orderID = Guid.NewGuid().ToString();
                    double weigth = 200 * double.Parse(weightTextBox.Text);
                    MessageBox.Show($"Стоимость вашей доставки: {Math.Round(weigth, 2)} рублей.");

                    string connectString = "server=localhost;user id=root;database=persons;persistsecurityinfo=True;password=root";
                    string insertDataQuery = "INSERT INTO orders (oName,oWeigth,oAddress,oLength,oWidth,oHeigth,oCost,oPersonID,oStatus,oOrderID) values ('" + this.nameTextBox.Text + "'," +
                        "'" + this.weightTextBox.Text + "','" + this.addressTextBox.Text + "','" + this.lengthTextBox.Text + "','" + this.widthTextBox.Text + "'," +
                        "'" + this.heigthTextBox.Text + "','" + Math.Round(weigth, 2) + "','" + LoginForm.id + "','" + "Заказ обрабатывается" + "','" + orderID + "')";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
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