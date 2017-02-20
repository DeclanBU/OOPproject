namespace LIBSYS
{
    partial class frmReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturnBook));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.loanBookTxtBox = new System.Windows.Forms.TextBox();
            this.ReturnBookIDLbl = new System.Windows.Forms.Label();
            this.btnRegcancel = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(536, 24);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 33);
            this.label5.TabIndex = 47;
            this.label5.Text = "Return Book";
            // 
            // pic
            // 
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(261, 37);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(253, 119);
            this.pic.TabIndex = 46;
            this.pic.TabStop = false;
            // 
            // loanBookTxtBox
            // 
            this.loanBookTxtBox.Location = new System.Drawing.Point(238, 205);
            this.loanBookTxtBox.Name = "loanBookTxtBox";
            this.loanBookTxtBox.Size = new System.Drawing.Size(100, 20);
            this.loanBookTxtBox.TabIndex = 49;
            // 
            // ReturnBookIDLbl
            // 
            this.ReturnBookIDLbl.AutoSize = true;
            this.ReturnBookIDLbl.Location = new System.Drawing.Point(119, 205);
            this.ReturnBookIDLbl.Name = "ReturnBookIDLbl";
            this.ReturnBookIDLbl.Size = new System.Drawing.Size(77, 13);
            this.ReturnBookIDLbl.TabIndex = 48;
            this.ReturnBookIDLbl.Text = "Enter Book ID:";
            // 
            // btnRegcancel
            // 
            this.btnRegcancel.Location = new System.Drawing.Point(260, 281);
            this.btnRegcancel.Name = "btnRegcancel";
            this.btnRegcancel.Size = new System.Drawing.Size(120, 33);
            this.btnRegcancel.TabIndex = 56;
            this.btnRegcancel.Text = "CANCEL";
            this.btnRegcancel.UseVisualStyleBackColor = true;
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Location = new System.Drawing.Point(95, 281);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(120, 33);
            this.btnReturnBook.TabIndex = 55;
            this.btnReturnBook.Text = "CONFIRM";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // frmReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 477);
            this.Controls.Add(this.btnRegcancel);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.loanBookTxtBox);
            this.Controls.Add(this.ReturnBookIDLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmReturnBook";
            this.Text = "Return Book";
            this.Load += new System.EventHandler(this.frmReturnBook_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.TextBox loanBookTxtBox;
        private System.Windows.Forms.Label ReturnBookIDLbl;
        private System.Windows.Forms.Button btnRegcancel;
        private System.Windows.Forms.Button btnReturnBook;
    }
}