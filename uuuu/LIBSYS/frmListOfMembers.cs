using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBSYS
{
    public partial class frmListOfMembers : Form
    {
        private Form parent;
        public frmListOfMembers()
        {
            InitializeComponent();
        }
        public frmListOfMembers(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmListOfMembers_Load(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegcancel_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sent To Printer");
        }
    }
}
