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
    public partial class frmBookOverdue : Form
    {
        private Form parent;
        public frmBookOverdue()
        {
            InitializeComponent();
        }
        public frmBookOverdue(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void OverdueButPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Send to Printer");
        }

        private void frmBookOverdue_Load(object sender, EventArgs e)
        {

        }
    }
}
