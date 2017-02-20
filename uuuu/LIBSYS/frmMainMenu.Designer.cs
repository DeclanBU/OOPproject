namespace LIBSYS
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mwemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catologueBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.issueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksOverdueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostPopularBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pic = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mwemberToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.loansToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(415, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mwemberToolStripMenuItem
            // 
            this.mwemberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regMemberToolStripMenuItem,
            this.updateMemberToolStripMenuItem,
            this.deRegisterToolStripMenuItem,
            this.listOfMembersToolStripMenuItem});
            this.mwemberToolStripMenuItem.Name = "mwemberToolStripMenuItem";
            this.mwemberToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.mwemberToolStripMenuItem.Text = "Membership";
            this.mwemberToolStripMenuItem.Click += new System.EventHandler(this.mwemberToolStripMenuItem_Click);
            // 
            // regMemberToolStripMenuItem
            // 
            this.regMemberToolStripMenuItem.Name = "regMemberToolStripMenuItem";
            this.regMemberToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.regMemberToolStripMenuItem.Text = "Reg member";
            this.regMemberToolStripMenuItem.Click += new System.EventHandler(this.regMemberToolStripMenuItem_Click);
            // 
            // updateMemberToolStripMenuItem
            // 
            this.updateMemberToolStripMenuItem.Name = "updateMemberToolStripMenuItem";
            this.updateMemberToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.updateMemberToolStripMenuItem.Text = "Update Member";
            this.updateMemberToolStripMenuItem.Click += new System.EventHandler(this.updateMemberToolStripMenuItem_Click);
            // 
            // deRegisterToolStripMenuItem
            // 
            this.deRegisterToolStripMenuItem.Name = "deRegisterToolStripMenuItem";
            this.deRegisterToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.deRegisterToolStripMenuItem.Text = "De-Register";
            this.deRegisterToolStripMenuItem.Click += new System.EventHandler(this.deRegisterToolStripMenuItem_Click);
            // 
            // listOfMembersToolStripMenuItem
            // 
            this.listOfMembersToolStripMenuItem.Name = "listOfMembersToolStripMenuItem";
            this.listOfMembersToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.listOfMembersToolStripMenuItem.Text = "List Of Members";
            this.listOfMembersToolStripMenuItem.Click += new System.EventHandler(this.listOfMembersToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catologueBookToolStripMenuItem,
            this.removeBookToolStripMenuItem,
            this.bookSearchToolStripMenuItem});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // catologueBookToolStripMenuItem
            // 
            this.catologueBookToolStripMenuItem.Name = "catologueBookToolStripMenuItem";
            this.catologueBookToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.catologueBookToolStripMenuItem.Text = "Catologue Book";
            this.catologueBookToolStripMenuItem.Click += new System.EventHandler(this.catologueBookToolStripMenuItem_Click);
            // 
            // removeBookToolStripMenuItem
            // 
            this.removeBookToolStripMenuItem.Name = "removeBookToolStripMenuItem";
            this.removeBookToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.removeBookToolStripMenuItem.Text = "Remove Book";
            this.removeBookToolStripMenuItem.Click += new System.EventHandler(this.removeBookToolStripMenuItem_Click);
            // 
            // bookSearchToolStripMenuItem
            // 
            this.bookSearchToolStripMenuItem.Name = "bookSearchToolStripMenuItem";
            this.bookSearchToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.bookSearchToolStripMenuItem.Text = "Book Search";
            this.bookSearchToolStripMenuItem.Click += new System.EventHandler(this.bookSearchToolStripMenuItem_Click);
            // 
            // loansToolStripMenuItem
            // 
            this.loansToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnBookToolStripMenuItem,
            this.returnBookToolStripMenuItem1,
            this.issueToolStripMenuItem,
            this.booksOverdueToolStripMenuItem,
            this.mostPopularBooksToolStripMenuItem});
            this.loansToolStripMenuItem.Name = "loansToolStripMenuItem";
            this.loansToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.loansToolStripMenuItem.Text = "Loans";
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.returnBookToolStripMenuItem.Text = "Loan Book";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // returnBookToolStripMenuItem1
            // 
            this.returnBookToolStripMenuItem1.Name = "returnBookToolStripMenuItem1";
            this.returnBookToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.returnBookToolStripMenuItem1.Text = "Return Book";
            this.returnBookToolStripMenuItem1.Click += new System.EventHandler(this.returnBookToolStripMenuItem1_Click);
            // 
            // issueToolStripMenuItem
            // 
            this.issueToolStripMenuItem.Name = "issueToolStripMenuItem";
            this.issueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.issueToolStripMenuItem.Text = "Issue Reminder";
            this.issueToolStripMenuItem.Click += new System.EventHandler(this.issueToolStripMenuItem_Click);
            // 
            // booksOverdueToolStripMenuItem
            // 
            this.booksOverdueToolStripMenuItem.Name = "booksOverdueToolStripMenuItem";
            this.booksOverdueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.booksOverdueToolStripMenuItem.Text = "Books overdue";
            this.booksOverdueToolStripMenuItem.Click += new System.EventHandler(this.booksOverdueToolStripMenuItem_Click);
            // 
            // mostPopularBooksToolStripMenuItem
            // 
            this.mostPopularBooksToolStripMenuItem.Name = "mostPopularBooksToolStripMenuItem";
            this.mostPopularBooksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostPopularBooksToolStripMenuItem.Text = "Most popular Books";
            this.mostPopularBooksToolStripMenuItem.Click += new System.EventHandler(this.mostPopularBooksToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pic
            // 
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(50, 27);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(298, 169);
            this.pic.TabIndex = 45;
            this.pic.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 228);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mwemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catologueBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem issueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksOverdueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostPopularBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pic;
    }
}