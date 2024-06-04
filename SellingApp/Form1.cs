using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No report available yet");
        }

        private void sellProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Selling form = new Selling();
            form.Show();
        }

        private void manageProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
        }

        private void manageCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer form = new Customer();
            form.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
