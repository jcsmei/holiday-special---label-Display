using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace holiday_special
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string Disney = "Disney: 3 Days 2 Nights for $899";
            lblOutput.Text = Disney;

        }

        private void btnHonolulu_Click(object sender, EventArgs e)
        {
            const string Honolulu = "Honolulu: One Week for $1,199";
            lblOutput.Text = Honolulu;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
