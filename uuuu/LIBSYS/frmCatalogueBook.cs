using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace LIBSYS
{
   
    public partial class frmRegisterABook : Form
    {
        private Form parent;
        public frmRegisterABook()
        {
            InitializeComponent();
        }
        public frmRegisterABook(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void frmCatalogueBook_Load(object sender, EventArgs e)
        {
            //set next book id
            txtBookId.Text = Book.nextBookId().ToString("0000");

            //load Genres
            loadGenres();
        }


        private void regBookSmitBut_Click(object sender, EventArgs e)
        {
            //validate Data


            //instantiate Stock Object
            Book myBook = new Book(Convert.ToInt32(txtBookId.Text), txtTitle.Text, authorTxt.Text, isbnTxt.Text,cboGenres.Text.Substring(0,2));


            //Insert Book into stock table
            myBook.regBook();

            //Display confirmation message
            MessageBox.Show("BOOKS " + txtBookId.Text + " Registered", "Confirmation",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            txtTitle.Text = "";
            authorTxt.Text = "";
            isbnTxt.Text = "";
            cboGenres.SelectedIndex = -1;


            txtBookId.Text = Book.nextBookId().ToString("0000");
            txtTitle.Focus();
            MessageBox.Show("Register Sucessful");
        }

        private void regBookCanButt_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void txtRegBook_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIsbn_Click(object sender, EventArgs e)
        {

        }

        public void loadGenres()
        {
            //connect to DB
            OracleConnection conn = new OracleConnection(DBconnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT * FROM Genres ORDER BY description";

            //Execute SQL Query
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr=  cmd.ExecuteReader();

            while (dr.Read())
            {
                cboGenres.Items.Add(dr.GetString(0) + " " + dr.GetString(1));
            }

            //close db
            conn.Close();
        }

        
    }
}
