namespace LIBSYS
{
    partial class frmRegisterABook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterABook));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regBookNamelbl = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.regBookAuthoelbl = new System.Windows.Forms.Label();
            this.authorTxt = new System.Windows.Forms.TextBox();
            this.txtIsbn = new System.Windows.Forms.Label();
            this.isbnTxt = new System.Windows.Forms.TextBox();
            this.regBookSmitBut = new System.Windows.Forms.Button();
            this.regBookCanButt = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.cboGenres = new System.Windows.Forms.ComboBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(452, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            // 
            // regBookNamelbl
            // 
            this.regBookNamelbl.AutoSize = true;
            this.regBookNamelbl.Location = new System.Drawing.Point(65, 255);
            this.regBookNamelbl.Name = "regBookNamelbl";
            this.regBookNamelbl.Size = new System.Drawing.Size(66, 13);
            this.regBookNamelbl.TabIndex = 1;
            this.regBookNamelbl.Text = "Book Name:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(178, 252);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtRegBook_TextChanged);
            // 
            // regBookAuthoelbl
            // 
            this.regBookAuthoelbl.AutoSize = true;
            this.regBookAuthoelbl.Location = new System.Drawing.Point(65, 297);
            this.regBookAuthoelbl.Name = "regBookAuthoelbl";
            this.regBookAuthoelbl.Size = new System.Drawing.Size(41, 13);
            this.regBookAuthoelbl.TabIndex = 3;
            this.regBookAuthoelbl.Text = "Author:";
            // 
            // authorTxt
            // 
            this.authorTxt.Location = new System.Drawing.Point(178, 290);
            this.authorTxt.Name = "authorTxt";
            this.authorTxt.Size = new System.Drawing.Size(100, 20);
            this.authorTxt.TabIndex = 4;
            // 
            // txtIsbn
            // 
            this.txtIsbn.AutoSize = true;
            this.txtIsbn.Location = new System.Drawing.Point(65, 335);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(27, 13);
            this.txtIsbn.TabIndex = 5;
            this.txtIsbn.Text = "Isbn";
            this.txtIsbn.Click += new System.EventHandler(this.txtIsbn_Click);
            // 
            // isbnTxt
            // 
            this.isbnTxt.Location = new System.Drawing.Point(178, 328);
            this.isbnTxt.Name = "isbnTxt";
            this.isbnTxt.Size = new System.Drawing.Size(100, 20);
            this.isbnTxt.TabIndex = 6;
            // 
            // regBookSmitBut
            // 
            this.regBookSmitBut.Location = new System.Drawing.Point(40, 442);
            this.regBookSmitBut.Name = "regBookSmitBut";
            this.regBookSmitBut.Size = new System.Drawing.Size(75, 23);
            this.regBookSmitBut.TabIndex = 7;
            this.regBookSmitBut.Text = "Register";
            this.regBookSmitBut.UseVisualStyleBackColor = true;
            this.regBookSmitBut.Click += new System.EventHandler(this.regBookSmitBut_Click);
            // 
            // regBookCanButt
            // 
            this.regBookCanButt.Location = new System.Drawing.Point(178, 442);
            this.regBookCanButt.Name = "regBookCanButt";
            this.regBookCanButt.Size = new System.Drawing.Size(75, 23);
            this.regBookCanButt.TabIndex = 8;
            this.regBookCanButt.Text = "Cancel";
            this.regBookCanButt.UseVisualStyleBackColor = true;
            this.regBookCanButt.Click += new System.EventHandler(this.regBookCanButt_Click);
            // 
            // pic
            // 
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(90, 27);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(253, 119);
            this.pic.TabIndex = 20;
            this.pic.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(113, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 33);
            this.label5.TabIndex = 35;
            this.label5.Text = "Register Book";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(65, 373);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(36, 13);
            this.genreLabel.TabIndex = 39;
            this.genreLabel.Text = "Genre";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(65, 403);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(37, 13);
            this.LblStatus.TabIndex = 41;
            this.LblStatus.Text = "Status";
            this.LblStatus.Visible = false;
            // 
            // txtBookId
            // 
            this.txtBookId.Enabled = false;
            this.txtBookId.Location = new System.Drawing.Point(178, 216);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(100, 20);
            this.txtBookId.TabIndex = 42;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(178, 403);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 43;
            // 
            // cboGenres
            // 
            this.cboGenres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenres.FormattingEnabled = true;
            this.cboGenres.Location = new System.Drawing.Point(182, 362);
            this.cboGenres.Name = "cboGenres";
            this.cboGenres.Size = new System.Drawing.Size(150, 21);
            this.cboGenres.TabIndex = 44;
          
            // 
            // frmRegisterABook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 532);
            this.Controls.Add(this.cboGenres);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.regBookCanButt);
            this.Controls.Add(this.regBookSmitBut);
            this.Controls.Add(this.isbnTxt);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.authorTxt);
            this.Controls.Add(this.regBookAuthoelbl);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.regBookNamelbl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRegisterABook";
            this.Text = "Register A Book";
            this.Load += new System.EventHandler(this.frmCatalogueBook_Load);
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
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label regBookAuthoelbl;
        private System.Windows.Forms.TextBox authorTxt;
        private System.Windows.Forms.Label txtIsbn;
        private System.Windows.Forms.TextBox isbnTxt;
        private System.Windows.Forms.Button regBookSmitBut;
        private System.Windows.Forms.Button regBookCanButt;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ComboBox cboGenres;
    }
}