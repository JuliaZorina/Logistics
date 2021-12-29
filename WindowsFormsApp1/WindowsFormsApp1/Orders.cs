using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void button34_Click(object sender, EventArgs e)
        {
            Map form3 = new Map();
            form3.Show();
            this.Hide();
        }
 
        private void Orders_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
