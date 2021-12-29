using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Map : Form
    {

        public Map()
        {
            InitializeComponent();
        }

       
        private void button35_Click(object sender, EventArgs e)
        {
            CargoPlace form1 = new CargoPlace();
            form1.Show();
            this.Hide();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Application form2 = new Application();
            form2.Show();
            this.Hide();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Orders form4 = new Orders();
            form4.Show();
            this.Hide();
        }

        private void Map_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            

        }

        private void Map_Load(object sender, EventArgs e)
        {
            var curDir = Directory.GetCurrentDirectory();
            wb.Url = new Uri(String.Format("file:///{0}/2GIS.html", curDir));
            

        }
    }
}
