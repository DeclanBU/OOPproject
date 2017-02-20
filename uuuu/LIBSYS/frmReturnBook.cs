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
    public partial class frmReturnBook : Form
    {
        private Form parent;
        public frmReturnBook()
        {
            InitializeComponent();
        }
        public frmReturnBook(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void frmReturnBook_Load(object sender, EventArgs e)
        {

        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Returned Book recorded");
        }
    }
}
