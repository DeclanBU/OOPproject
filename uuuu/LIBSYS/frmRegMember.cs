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
    public partial class frmRegMember : Form
    {

        private Form parent;

        public frmRegMember()
        {
            InitializeComponent();
        }

        public frmRegMember(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmRegMember_Load(object sender, EventArgs e)
        {
            txtMemId.Text = Member.nextMemberId().ToString("0000");
        }

        private void btnRegMem_Click(object sender, EventArgs e)
        {
            //validate Data


            //instantiate Stock Object
            Member myMember = new Member(Convert.ToInt32(txtMemId.Text), txtRegSurname.Text, txtRegForename.Text, dateTimePicker1.Text, txtRegStreet.Text, txtRegtown.Text, cboCounty.Text, txtEmail.Text, txtRegTel.Text);

            //insert members into table
            myMember.regMem();

            //Display confirmation message
            MessageBox.Show("Member " + txtMemId.Text + " Registered", "Confirmation",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI

            txtRegSurname.Text = "";
            txtRegForename.Text = "";
            dateTimePicker1.Text = "";
            txtRegStreet.Text = "";
            txtRegtown.Text = "";
            cboCounty.Text = "";
            txtEmail.Text = "";
            txtRegTel.Text = "";
            txtMemId.Text = Member.nextMemberId().ToString("0000");
            txtRegSurname.Focus();




        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cboCounty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDob_Click(object sender, EventArgs e)
        {

        }

        private void streetlbl_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblTown_Click(object sender, EventArgs e)
        {

        }

        private void lblEircode_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void grpContactDetailsRegMem_Enter(object sender, EventArgs e)
        {

        }

        private void txtRegStreet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegtown_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegEirCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegForename_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblForename_Click(object sender, EventArgs e)
        {

        }

        private void txtRegSurname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
