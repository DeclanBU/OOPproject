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
    public partial class frmBookSearch : Form
    {
        private Form parent;
        public frmBookSearch()
        {
            InitializeComponent();
        }
        public frmBookSearch(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmBookSearch_Load(object sender, EventArgs e)
        {
           
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void regBookSmitBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Search");
        }
    }
}
