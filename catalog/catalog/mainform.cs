using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace catalog
{
    public partial class mainform : Form
    {
        int price = 0;
        public mainform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iphone iphonesus = new iphone();
            iphonesus.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            samsung samsungsus = new samsung();
            samsungsus.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Filtr filtrsus = new Filtr();
            filtrsus.ShowDialog();
        }

        private void mainform_Load(object sender, EventArgs e)
        {

        }
    }
}
