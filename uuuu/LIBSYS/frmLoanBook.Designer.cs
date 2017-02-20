namespace LIBSYS
{
    partial class frmLoanBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoanBook));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regBookNamelbl = new System.Windows.Forms.Label();
            this.regBookTxtLbl = new System.Windows.Forms.TextBox();
            this.loanBookIDLbl = new System.Windows.Forms.Label();
            this.loanBookTxtBox = new System.Windows.Forms.TextBox();
            this.loanBookSmitBut = new System.Windows.Forms.Button();
            this.regBookCanButt = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.loanBookcomboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(489, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // regBookNamelbl
            // 
            this.regBookNamelbl.AutoSize = true;
            this.regBookNamelbl.Location = new System.Drawing.Point(108, 180);
            this.regBookNamelbl.Name = "regBookNamelbl";
            this.regBookNamelbl.Size = new System.Drawing.Size(93, 13);
            this.regBookNamelbl.TabIndex = 36;
            this.regBookNamelbl.Text = "Member Surname:";
            this.regBookNamelbl.Click += new System.EventHandler(this.regBookNamelbl_Click);
            // 
            // regBookTxtLbl
            // 
            this.regBookTxtLbl.Location = new System.Drawing.Point(227, 180);
            this.regBookTxtLbl.Name = "regBookTxtLbl";
            this.regBookTxtLbl.Size = new System.Drawing.Size(100, 20);
            this.regBookTxtLbl.TabIndex = 37;
            this.regBookTxtLbl.TextChanged += new System.EventHandler(this.regBookTxtLbl_TextChanged);
            // 
            // loanBookIDLbl
            // 
            this.loanBookIDLbl.AutoSize = true;
            this.loanBookIDLbl.Location = new System.Drawing.Point(108, 224);
            this.loanBookIDLbl.Name = "loanBookIDLbl";
            this.loanBookIDLbl.Size = new System.Drawing.Size(49, 13);
            this.loanBookIDLbl.TabIndex = 38;
            this.loanBookIDLbl.Text = "Book ID:";
            this.loanBookIDLbl.Click += new System.EventHandler(this.regBookAuthoelbl_Click);
            // 
            // loanBookTxtBox
            // 
            this.loanBookTxtBox.Location = new System.Drawing.Point(227, 224);
            this.loanBookTxtBox.Name = "loanBookTxtBox";
            this.loanBookTxtBox.Size = new System.Drawing.Size(100, 20);
            this.loanBookTxtBox.TabIndex = 39;
            this.loanBookTxtBox.TextChanged += new System.EventHandler(this.regBookTxtBox_TextChanged);
            // 
            // loanBookSmitBut
            // 
            this.loanBookSmitBut.Location = new System.Drawing.Point(111, 280);
            this.loanBookSmitBut.Name = "loanBookSmitBut";
            this.loanBookSmitBut.Size = new System.Drawing.Size(75, 23);
            this.loanBookSmitBut.TabIndex = 42;
            this.loanBookSmitBut.Text = "SUBMIT";
            this.loanBookSmitBut.UseVisualStyleBackColor = true;
            this.loanBookSmitBut.Click += new System.EventHandler(this.regBookSmitBut_Click);
            // 
            // regBookCanButt
            // 
            this.regBookCanButt.Location = new System.Drawing.Point(252, 280);
            this.regBookCanButt.Name = "regBookCanButt";
            this.regBookCanButt.Size = new System.Drawing.Size(75, 23);
            this.regBookCanButt.TabIndex = 43;
            this.regBookCanButt.Text = "CANCEL";
            this.regBookCanButt.UseVisualStyleBackColor = true;
            this.regBookCanButt.Click += new System.EventHandler(this.regBookCanButt_Click);
            // 
            // pic
            // 
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(224, 12);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(253, 119);
            this.pic.TabIndex = 44;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 33);
            this.label5.TabIndex = 45;
            this.label5.Text = "Loan Book";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // loanBookcomboBox
            // 
            this.loanBookcomboBox.FormattingEnabled = true;
            this.loanBookcomboBox.Location = new System.Drawing.Point(227, 180);
            this.loanBookcomboBox.Name = "loanBookcomboBox";
            this.loanBookcomboBox.Size = new System.Drawing.Size(121, 21);
            this.loanBookcomboBox.TabIndex = 46;
            // 
            // frmLoanBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 423);
            this.Controls.Add(this.loanBookcomboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.regBookCanButt);
            this.Controls.Add(this.loanBookSmitBut);
            this.Controls.Add(this.loanBookTxtBox);
            this.Controls.Add(this.loanBookIDLbl);
            this.Controls.Add(this.regBookTxtLbl);
            this.Controls.Add(this.regBookNamelbl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLoanBook";
            this.Text = "Loan Book";
            this.Load += new System.EventHandler(this.frmLoanBook_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label regBookNamelbl;
        private System.Windows.Forms.TextBox regBookTxtLbl;
        private System.Windows.Forms.Label loanBookIDLbl;
        private System.Windows.Forms.TextBox loanBookTxtBox;
        private System.Windows.Forms.Button loanBookSmitBut;
        private System.Windows.Forms.Button regBookCanButt;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox loanBookcomboBox;
    }
}