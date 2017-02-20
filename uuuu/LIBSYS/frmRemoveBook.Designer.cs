namespace LIBSYS
{
    partial class frmRemoveBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemoveBook));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.regBookCanButt = new System.Windows.Forms.Button();
            this.regBookSmitBut = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.regBookGenreLbl = new System.Windows.Forms.Label();
            this.regBookTxtBox = new System.Windows.Forms.TextBox();
            this.regBookAuthoelbl = new System.Windows.Forms.Label();
            this.regBookTxtLbl = new System.Windows.Forms.TextBox();
            this.regBookNamelbl = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(316, 24);
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
            this.label5.Location = new System.Drawing.Point(40, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 33);
            this.label5.TabIndex = 45;
            this.label5.Text = "Remove Book";
            // 
            // pic
            // 
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(23, 52);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(253, 119);
            this.pic.TabIndex = 44;
            this.pic.TabStop = false;
            // 
            // regBookCanButt
            // 
            this.regBookCanButt.Location = new System.Drawing.Point(178, 376);
            this.regBookCanButt.Name = "regBookCanButt";
            this.regBookCanButt.Size = new System.Drawing.Size(75, 23);
            this.regBookCanButt.TabIndex = 43;
            this.regBookCanButt.Text = "Cancel";
            this.regBookCanButt.UseVisualStyleBackColor = true;
            // 
            // regBookSmitBut
            // 
            this.regBookSmitBut.Location = new System.Drawing.Point(40, 376);
            this.regBookSmitBut.Name = "regBookSmitBut";
            this.regBookSmitBut.Size = new System.Drawing.Size(75, 23);
            this.regBookSmitBut.TabIndex = 42;
            this.regBookSmitBut.Text = "Remove";
            this.regBookSmitBut.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 317);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 41;
            // 
            // regBookGenreLbl
            // 
            this.regBookGenreLbl.AutoSize = true;
            this.regBookGenreLbl.Location = new System.Drawing.Point(52, 320);
            this.regBookGenreLbl.Name = "regBookGenreLbl";
            this.regBookGenreLbl.Size = new System.Drawing.Size(39, 13);
            this.regBookGenreLbl.TabIndex = 40;
            this.regBookGenreLbl.Text = "Genre:";
            // 
            // regBookTxtBox
            // 
            this.regBookTxtBox.Location = new System.Drawing.Point(136, 280);
            this.regBookTxtBox.Name = "regBookTxtBox";
            this.regBookTxtBox.Size = new System.Drawing.Size(100, 20);
            this.regBookTxtBox.TabIndex = 39;
            // 
            // regBookAuthoelbl
            // 
            this.regBookAuthoelbl.AutoSize = true;
            this.regBookAuthoelbl.Location = new System.Drawing.Point(52, 280);
            this.regBookAuthoelbl.Name = "regBookAuthoelbl";
            this.regBookAuthoelbl.Size = new System.Drawing.Size(41, 13);
            this.regBookAuthoelbl.TabIndex = 38;
            this.regBookAuthoelbl.Text = "Author:";
            // 
            // regBookTxtLbl
            // 
            this.regBookTxtLbl.Location = new System.Drawing.Point(136, 238);
            this.regBookTxtLbl.Name = "regBookTxtLbl";
            this.regBookTxtLbl.Size = new System.Drawing.Size(100, 20);
            this.regBookTxtLbl.TabIndex = 37;
            // 
            // regBookNamelbl
            // 
            this.regBookNamelbl.AutoSize = true;
            this.regBookNamelbl.Location = new System.Drawing.Point(52, 238);
            this.regBookNamelbl.Name = "regBookNamelbl";
            this.regBookNamelbl.Size = new System.Drawing.Size(66, 13);
            this.regBookNamelbl.TabIndex = 36;
            this.regBookNamelbl.Text = "Book Name:";
            // 
            // frmRemoveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 447);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.regBookCanButt);
            this.Controls.Add(this.regBookSmitBut);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.regBookGenreLbl);
            this.Controls.Add(this.regBookTxtBox);
            this.Controls.Add(this.regBookAuthoelbl);
            this.Controls.Add(this.regBookTxtLbl);
            this.Controls.Add(this.regBookNamelbl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRemoveBook";
            this.Text = "frmRemoveBook";
            this.Load += new System.EventHandler(this.frmRemoveBook_Load);
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
        private System.Windows.Forms.Button regBookCanButt;
        private System.Windows.Forms.Button regBookSmitBut;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label regBookGenreLbl;
        private System.Windows.Forms.TextBox regBookTxtBox;
        private System.Windows.Forms.Label regBookAuthoelbl;
        private System.Windows.Forms.TextBox regBookTxtLbl;
        private System.Windows.Forms.Label regBookNamelbl;
    }
}