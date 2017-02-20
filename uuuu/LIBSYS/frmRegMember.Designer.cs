namespace LIBSYS
{
    partial class frmRegMember
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegMember));
            this.txtRegSurname = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtRegForename = new System.Windows.Forms.TextBox();
            this.btnRegMem = new System.Windows.Forms.Button();
            this.grpContactDetailsRegMem = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtRegTel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPersonTitle = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.txtRegStreet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRegtown = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.streetlbl = new System.Windows.Forms.Label();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRegcancel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pic = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.grpContactDetailsRegMem.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRegSurname
            // 
            this.txtRegSurname.Location = new System.Drawing.Point(129, 227);
            this.txtRegSurname.Name = "txtRegSurname";
            this.txtRegSurname.Size = new System.Drawing.Size(132, 20);
            this.txtRegSurname.TabIndex = 0;
            this.txtRegSurname.TextChanged += new System.EventHandler(this.txtRegSurname_TextChanged);
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(36, 195);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(63, 16);
            this.lblForename.TabIndex = 1;
            this.lblForename.Text = "Foreame";
            this.lblForename.Click += new System.EventHandler(this.lblForename_Click);
            // 
            // txtRegForename
            // 
            this.txtRegForename.Location = new System.Drawing.Point(129, 191);
            this.txtRegForename.Name = "txtRegForename";
            this.txtRegForename.Size = new System.Drawing.Size(132, 20);
            this.txtRegForename.TabIndex = 2;
            this.txtRegForename.TextChanged += new System.EventHandler(this.txtRegForename_TextChanged);
            // 
            // btnRegMem
            // 
            this.btnRegMem.Location = new System.Drawing.Point(343, 374);
            this.btnRegMem.Name = "btnRegMem";
            this.btnRegMem.Size = new System.Drawing.Size(120, 33);
            this.btnRegMem.TabIndex = 4;
            this.btnRegMem.Text = "Submit";
            this.btnRegMem.UseVisualStyleBackColor = true;
            this.btnRegMem.Click += new System.EventHandler(this.btnRegMem_Click);
            // 
            // grpContactDetailsRegMem
            // 
            this.grpContactDetailsRegMem.Controls.Add(this.radioButton1);
            this.grpContactDetailsRegMem.Controls.Add(this.txtRegTel);
            this.grpContactDetailsRegMem.Controls.Add(this.label2);
            this.grpContactDetailsRegMem.Controls.Add(this.label1);
            this.grpContactDetailsRegMem.Controls.Add(this.txtEmail);
            this.grpContactDetailsRegMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContactDetailsRegMem.Location = new System.Drawing.Point(343, 227);
            this.grpContactDetailsRegMem.Name = "grpContactDetailsRegMem";
            this.grpContactDetailsRegMem.Size = new System.Drawing.Size(285, 110);
            this.grpContactDetailsRegMem.TabIndex = 5;
            this.grpContactDetailsRegMem.TabStop = false;
            this.grpContactDetailsRegMem.Text = "Contact Details:";
            this.grpContactDetailsRegMem.Enter += new System.EventHandler(this.grpContactDetailsRegMem_Enter);
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 269);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Surname";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cboPersonTitle
            // 
            this.cboPersonTitle.FormattingEnabled = true;
            this.cboPersonTitle.Items.AddRange(new object[] {
            "Mr",
            "Mrs ",
            "Miss"});
            this.cboPersonTitle.Location = new System.Drawing.Point(129, 148);
            this.cboPersonTitle.Name = "cboPersonTitle";
            this.cboPersonTitle.Size = new System.Drawing.Size(51, 21);
            this.cboPersonTitle.TabIndex = 8;
            this.cboPersonTitle.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Title";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.Location = new System.Drawing.Point(36, 273);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(82, 16);
            this.lblDob.TabIndex = 11;
            this.lblDob.Text = "Date Of Birth";
            this.lblDob.Click += new System.EventHandler(this.lblDob_Click);
            // 
            // txtRegStreet
            // 
            this.txtRegStreet.Location = new System.Drawing.Point(129, 306);
            this.txtRegStreet.Name = "txtRegStreet";
            this.txtRegStreet.Size = new System.Drawing.Size(132, 20);
            this.txtRegStreet.TabIndex = 3;
            this.txtRegStreet.TextChanged += new System.EventHandler(this.txtRegStreet_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Street";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtRegtown
            // 
            this.txtRegtown.Location = new System.Drawing.Point(129, 347);
            this.txtRegtown.Name = "txtRegtown";
            this.txtRegtown.Size = new System.Drawing.Size(132, 20);
            this.txtRegtown.TabIndex = 3;
            this.txtRegtown.TextChanged += new System.EventHandler(this.txtRegtown_TextChanged);
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(38, 347);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(41, 16);
            this.lblTown.TabIndex = 10;
            this.lblTown.Text = "Town";
            this.lblTown.Click += new System.EventHandler(this.lblTown_Click);
            // 
            // streetlbl
            // 
            this.streetlbl.AutoSize = true;
            this.streetlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetlbl.Location = new System.Drawing.Point(36, 306);
            this.streetlbl.Name = "streetlbl";
            this.streetlbl.Size = new System.Drawing.Size(43, 16);
            this.streetlbl.TabIndex = 10;
            this.streetlbl.Text = "Street";
            this.streetlbl.Click += new System.EventHandler(this.streetlbl_Click);
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
            this.cboCounty.Location = new System.Drawing.Point(129, 386);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(101, 21);
            this.cboCounty.TabIndex = 12;
            this.cboCounty.SelectedIndexChanged += new System.EventHandler(this.cboCounty_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "County";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnRegcancel
            // 
            this.btnRegcancel.Location = new System.Drawing.Point(508, 374);
            this.btnRegcancel.Name = "btnRegcancel";
            this.btnRegcancel.Size = new System.Drawing.Size(120, 33);
            this.btnRegcancel.TabIndex = 14;
            this.btnRegcancel.Text = "Cancel";
            this.btnRegcancel.UseVisualStyleBackColor = true;
            this.btnRegcancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // pic
            // 
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(343, 27);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(277, 163);
            this.pic.TabIndex = 16;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(371, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(8, 8);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 33);
            this.label5.TabIndex = 34;
            this.label5.Text = "Register";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtMemId
            // 
            this.txtMemId.Location = new System.Drawing.Point(129, 103);
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.Size = new System.Drawing.Size(100, 20);
            this.txtMemId.TabIndex = 35;
            // 
            // frmRegMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 457);
            this.Controls.Add(this.txtMemId);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboPersonTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.grpContactDetailsRegMem);
            this.Controls.Add(this.txtRegStreet);
            this.Controls.Add(this.txtRegtown);
            this.Controls.Add(this.btnRegMem);
            this.Controls.Add(this.txtRegForename);
            this.Controls.Add(this.lblForename);
            this.Controls.Add(this.txtRegSurname);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRegMember";
            this.Text = "LIBSYS-Register Member ";
            this.Load += new System.EventHandler(this.frmRegMember_Load);
            this.grpContactDetailsRegMem.ResumeLayout(false);
            this.grpContactDetailsRegMem.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegSurname;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtRegForename;
        private System.Windows.Forms.Button btnRegMem;
        private System.Windows.Forms.GroupBox grpContactDetailsRegMem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtRegTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPersonTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.TextBox txtRegStreet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRegtown;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label streetlbl;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnRegcancel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMemId;
    }
}