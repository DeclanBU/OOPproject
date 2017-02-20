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
    public partial class frmDeregMember : Form
    {
        private MenuStrip menuStrip1;
        private ToolStripMenuItem backToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private IContainer components;
        private Label label5;
        private GroupBox groupBox1;
        private PictureBox pic;
        private Button btnRegcancel;
        private Label label10;
        private ComboBox cboCounty;
        private Label lblDob;
        private Label streetlbl;
        private Label label7;
        private Label lblTown;
        private Label lblEircode;
        private Label label4;
        private ComboBox cboPersonTitle;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private GroupBox grpContactDetailsRegMem;
        private RadioButton radioButton1;
        private TextBox txtRegTel;
        private Label label2;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtRegStreet;
        private TextBox txtRegtown;
        private TextBox txtRegEirCode;
        private Button btnRegMem;
        private TextBox txtRegForename;
        private Label lblForename;
        private TextBox txtRegSurname;
        private Form parent;

        public frmDeregMember()
        {
            InitializeComponent();
        }

        public frmDeregMember(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeregMember));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnRegcancel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.lblDob = new System.Windows.Forms.Label();
            this.streetlbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblEircode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPersonTitle = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.grpContactDetailsRegMem = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtRegTel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRegStreet = new System.Windows.Forms.TextBox();
            this.txtRegtown = new System.Windows.Forms.TextBox();
            this.txtRegEirCode = new System.Windows.Forms.TextBox();
            this.btnRegMem = new System.Windows.Forms.Button();
            this.txtRegForename = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtRegSurname = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.grpContactDetailsRegMem.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(654, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 33);
            this.label5.TabIndex = 57;
            this.label5.Text = "DeRegister";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(354, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(8, 8);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pic
            // 
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(326, 37);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(277, 163);
            this.pic.TabIndex = 55;
            this.pic.TabStop = false;
            // 
            // btnRegcancel
            // 
            this.btnRegcancel.Location = new System.Drawing.Point(491, 384);
            this.btnRegcancel.Name = "btnRegcancel";
            this.btnRegcancel.Size = new System.Drawing.Size(120, 33);
            this.btnRegcancel.TabIndex = 54;
            this.btnRegcancel.Text = "Cancel";
            this.btnRegcancel.UseVisualStyleBackColor = true;
            this.btnRegcancel.Click += new System.EventHandler(this.btnRegcancel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 53;
            this.label10.Text = "County";
            // 
            // cboCounty
            // 
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Items.AddRange(new object[] {
            "Cork",
            "Carlow",
            "Tipperary",
            "Waterford",
            "Kerry",
            "Sligo",
            "Galway",
            "Louth",
            "Dublin",
            "Meath",
            "WestMeath",
            "Clare",
            "Longford",
            "Mayo",
            "Wexford",
            "Monaghan",
            "Limerick",
            "Laois",
            "Kilkenny",
            "Kildare"});
            this.cboCounty.Location = new System.Drawing.Point(112, 407);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(101, 21);
            this.cboCounty.TabIndex = 52;
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.Location = new System.Drawing.Point(19, 283);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(82, 16);
            this.lblDob.TabIndex = 51;
            this.lblDob.Text = "Date Of Birth";
            // 
            // streetlbl
            // 
            this.streetlbl.AutoSize = true;
            this.streetlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetlbl.Location = new System.Drawing.Point(19, 316);
            this.streetlbl.Name = "streetlbl";
            this.streetlbl.Size = new System.Drawing.Size(43, 16);
            this.streetlbl.TabIndex = 49;
            this.streetlbl.Text = "Street";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 48;
            this.label7.Text = "Street";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(21, 348);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(41, 16);
            this.lblTown.TabIndex = 47;
            this.lblTown.Text = "Town";
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEircode.Location = new System.Drawing.Point(19, 381);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(55, 16);
            this.lblEircode.TabIndex = 50;
            this.lblEircode.Text = "Eircode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Title";
            // 
            // cboPersonTitle
            // 
            this.cboPersonTitle.FormattingEnabled = true;
            this.cboPersonTitle.Items.AddRange(new object[] {
            "Mr",
            "Mrs ",
            "Miss"});
            this.cboPersonTitle.Location = new System.Drawing.Point(112, 158);
            this.cboPersonTitle.Name = "cboPersonTitle";
            this.cboPersonTitle.Size = new System.Drawing.Size(51, 21);
            this.cboPersonTitle.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Surname";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(112, 279);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 20);
            this.dateTimePicker1.TabIndex = 43;
            // 
            // grpContactDetailsRegMem
            // 
            this.grpContactDetailsRegMem.Controls.Add(this.radioButton1);
            this.grpContactDetailsRegMem.Controls.Add(this.txtRegTel);
            this.grpContactDetailsRegMem.Controls.Add(this.label2);
            this.grpContactDetailsRegMem.Controls.Add(this.label1);
            this.grpContactDetailsRegMem.Controls.Add(this.txtEmail);
            this.grpContactDetailsRegMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContactDetailsRegMem.Location = new System.Drawing.Point(326, 237);
            this.grpContactDetailsRegMem.Name = "grpContactDetailsRegMem";
            this.grpContactDetailsRegMem.Size = new System.Drawing.Size(285, 110);
            this.grpContactDetailsRegMem.TabIndex = 42;
            this.grpContactDetailsRegMem.TabStop = false;
            this.grpContactDetailsRegMem.Text = "Contact Details:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(52, 80);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(164, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Subscribe To Newsletter";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtRegTel
            // 
            this.txtRegTel.Location = new System.Drawing.Point(101, 46);
            this.txtRegTel.Name = "txtRegTel";
            this.txtRegTel.Size = new System.Drawing.Size(132, 20);
            this.txtRegTel.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Telephone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(101, 20);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtRegStreet
            // 
            this.txtRegStreet.Location = new System.Drawing.Point(112, 316);
            this.txtRegStreet.Name = "txtRegStreet";
            this.txtRegStreet.Size = new System.Drawing.Size(132, 20);
            this.txtRegStreet.TabIndex = 40;
            // 
            // txtRegtown
            // 
            this.txtRegtown.Location = new System.Drawing.Point(112, 347);
            this.txtRegtown.Name = "txtRegtown";
            this.txtRegtown.Size = new System.Drawing.Size(132, 20);
            this.txtRegtown.TabIndex = 39;
            // 
            // txtRegEirCode
            // 
            this.txtRegEirCode.Location = new System.Drawing.Point(112, 377);
            this.txtRegEirCode.Name = "txtRegEirCode";
            this.txtRegEirCode.Size = new System.Drawing.Size(132, 20);
            this.txtRegEirCode.TabIndex = 38;
            // 
            // btnRegMem
            // 
            this.btnRegMem.Location = new System.Drawing.Point(326, 384);
            this.btnRegMem.Name = "btnRegMem";
            this.btnRegMem.Size = new System.Drawing.Size(120, 33);
            this.btnRegMem.TabIndex = 41;
            this.btnRegMem.Text = "Deregister";
            this.btnRegMem.UseVisualStyleBackColor = true;
            this.btnRegMem.Click += new System.EventHandler(this.btnRegMem_Click);
            // 
            // txtRegForename
            // 
            this.txtRegForename.Location = new System.Drawing.Point(112, 201);
            this.txtRegForename.Name = "txtRegForename";
            this.txtRegForename.Size = new System.Drawing.Size(132, 20);
            this.txtRegForename.TabIndex = 37;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(19, 205);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(63, 16);
            this.lblForename.TabIndex = 36;
            this.lblForename.Text = "Foreame";
            // 
            // txtRegSurname
            // 
            this.txtRegSurname.Location = new System.Drawing.Point(112, 237);
            this.txtRegSurname.Name = "txtRegSurname";
            this.txtRegSurname.Size = new System.Drawing.Size(132, 20);
            this.txtRegSurname.TabIndex = 35;
            // 
            // frmDeregMember
            // 
            this.ClientSize = new System.Drawing.Size(654, 456);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.btnRegcancel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboCounty);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.streetlbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.lblEircode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboPersonTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.grpContactDetailsRegMem);
            this.Controls.Add(this.txtRegStreet);
            this.Controls.Add(this.txtRegtown);
            this.Controls.Add(this.txtRegEirCode);
            this.Controls.Add(this.btnRegMem);
            this.Controls.Add(this.txtRegForename);
            this.Controls.Add(this.lblForename);
            this.Controls.Add(this.txtRegSurname);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDeregMember";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.grpContactDetailsRegMem.ResumeLayout(false);
            this.grpContactDetailsRegMem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmDeregMember_Load(object sender, EventArgs e)
        {

        }
           private void frmDeregMember_click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void backToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegcancel_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnRegMem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Degister SucessFul");
        }
    }
}
