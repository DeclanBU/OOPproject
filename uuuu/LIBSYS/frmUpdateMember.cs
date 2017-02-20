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
    public partial class frmUpdateMember : Form
    {

        private Form parent;

        public frmUpdateMember()
        {
            InitializeComponent();
            grpMemDetails.Visible = false;
            grdUpdate.Visible = false;
        }

        public frmUpdateMember(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmUpdateMember_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegcancel_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnRegMem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Updated");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            fillGrid();


            grdUpdate.Visible = true;
        }
        public void fillGrid()
        {

            int nextMemberId;

            //Create database connection string

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);


            //Define SQL query
            String strSQL = "SELECT * FROM Member WHERE SURNAME LIKE '" + surName.Text + "%'";
            // String strSQL = "SELECT * FROM STOCK";
            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
            myConn.Open();

            //create OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds, "Member");
            grdUpdate.DataSource = ds.Tables["Member"];

            //Close DB
            myConn.Close();
            //return ds;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
