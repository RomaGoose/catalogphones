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
    public partial class iphone : Form
    {
        public iphone()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainform mainsus = new mainform();
            mainsus.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filtr.phoneClick(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iphone_Load(object sender, EventArgs e)
        {

        }
    }
}
