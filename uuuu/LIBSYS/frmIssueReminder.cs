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
    
    public partial class frmIssueReminder : Form
    {
        private Form parent;
        public frmIssueReminder()
        {
            InitializeComponent();
        }
        public frmIssueReminder(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }


        private void frmIssueReminder_Load(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void regBookSmitBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Issue Reminder");
        }
    }
}
