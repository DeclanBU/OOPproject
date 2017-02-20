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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void mwemberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void regMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmRegMember(this).Show();
        }

        private void updateMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmUpdateMember(this).Show();
        }

        private void deRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmDeregMember(this).Show();
        }

        private void listOfMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmListOfMembers(this).Show();
        }

      
        private void catologueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmRegisterABook(this).Show();
        }

        private void removeBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmRemoveBook(this).Show();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void bookSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmBookSearch(this).Show();

        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLoanBook(this).Show();
        }

        private void returnBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmReturnBook(this).Show();
        }

        private void issueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmIssueReminder(this).Show();
        }

        private void booksOverdueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmBookOverdue(this).Show();
        }

        private void mostPopularBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Hide();
            new frmMostPopularBooks(this).Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
