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
    public partial class frmMostPopularBooks : Form
    {
        private Form parent;
        public frmMostPopularBooks()
        {
            InitializeComponent();
        }
        public frmMostPopularBooks(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmMostPopularBooks_Load(object sender, EventArgs e)
        {

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
    }
}
