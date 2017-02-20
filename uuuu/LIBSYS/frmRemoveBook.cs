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
    public partial class frmRemoveBook : Form
    {
        private Form parent;
        public frmRemoveBook()
        {
            InitializeComponent();
        }
        public frmRemoveBook(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void frmRemoveBook_Load(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }
    }
}
