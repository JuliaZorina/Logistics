using System;
using System.Windows.Forms;
using LogLibrary;
using MySql.Data.MySqlClient;

namespace LogisticProgram
{
    public partial class RegistrationForm : Form
    {
        private readonly FormsViewModel_RegistrationForm viewModel = new FormsViewModel_RegistrationForm();

        public RegistrationForm()
        {
            InitializeComponent();

            nameTextBox.DataBindings.Add("Text", viewModel, nameof(FormsViewModel_RegistrationForm.NameTextBox));
            surenameTextBox.DataBindings.Add("Text", viewModel, nameof(FormsViewModel_RegistrationForm.SurenameTextBox));
            loginTextBox.DataBindings.Add("Text", viewModel, nameof(FormsViewModel_RegistrationForm.LoginTextBox));
            passwordTextBox.DataBindings.Add("Text", viewModel, nameof(FormsViewModel_RegistrationForm.PasswordTextBox));
        }

        private void registrateButton_Click(object sender, EventArgs e)
        {
            try
            {
                nameTextBox.Text = viewModel.GetName().ToString();
                surenameTextBox.Text = viewModel.GetSurename().ToString();
                loginTextBox.Text = viewModel.GetLogin().ToString();
                passwordTextBox.Text = viewModel.GetPassword().ToString();

                var id = Guid.NewGuid().ToString();
                string connectString = "server=localhost;user id=root;database=persons;persistsecurityinfo=True;password=root";
                string loginQuery = "SELECT * FROM persons WHERE pLogin= '" + this.loginTextBox.Text + "'";
                MySqlConnection conn1 = new MySqlConnection(connectString);
                MySqlCommand cmd1 = new MySqlCommand(loginQuery, conn1);
                MySqlDataReader reader;
                int count = 0;
                try
                {
                    conn1.Open();
                    reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {
                        count += 1;
                    }
                    conn1.Close();
                    if (count >= 1)
                    {
                        MessageBox.Show("Этот логин уже есть, придумайте новый");
                    }
                    else
                    {
                        //Добавить проверку пустых полей
                        string insertDataQuery = "INSERT INTO persons (pName,pSureName,pLogin,pPassword,pPersonID) values ('" + this.nameTextBox.Text + "'," +
                            "'" + this.surenameTextBox.Text + "','" + this.loginTextBox.Text + "','" + this.passwordTextBox.Text + "','" + id + "')";
                        MySqlConnection conn = new MySqlConnection(connectString);
                        MySqlCommand cmd = new MySqlCommand(insertDataQuery, conn);
                        MySqlDataReader dataReader;
                        try
                        {
                            conn.Open();
                            dataReader = cmd.ExecuteReader();
                            conn.Close();
                            MessageBox.Show("Person Register Successfully");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Unable to Insert the Data due to" + ex);
                        }

                        LoginForm lform = new LoginForm();
                        lform.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to Get the Values due to" + ex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}