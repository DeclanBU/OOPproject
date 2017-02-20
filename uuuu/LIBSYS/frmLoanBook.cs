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
    public partial class frmLoanBook : Form
    {
        private Form parent;
        public frmLoanBook()
        {
            InitializeComponent();
        }
        public frmLoanBook(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmLoanBook_Load(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void regBookCanButt_Click(object sender, EventArgs e)
        {

        }

        private void regBookSmitBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loan Sucessful");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void regBookGenreLbl_Click(object sender, EventArgs e)
        {

        }

        private void regBookTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void regBookAuthoelbl_Click(object sender, EventArgs e)
        {

        }

        private void regBookTxtLbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void regBookNamelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
