namespace LIBSYS
{
    partial class frmIssueReminder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueReminder));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IssueReminderLbl = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.reminderCanButt = new System.Windows.Forms.Button();
            this.regBookSmitBut = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
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
            this.menuStrip1.Size = new System.Drawing.Size(463, 24);
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
            // IssueReminderLbl
            // 
            this.IssueReminderLbl.AutoSize = true;
            this.IssueReminderLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IssueReminderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueReminderLbl.Location = new System.Drawing.Point(110, 152);
            this.IssueReminderLbl.Name = "IssueReminderLbl";
            this.IssueReminderLbl.Size = new System.Drawing.Size(220, 33);
            this.IssueReminderLbl.TabIndex = 45;
            this.IssueReminderLbl.Text = "Issue Reminder";
            // 
            // pic
            // 
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(92, 12);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(253, 119);
            this.pic.TabIndex = 44;
            this.pic.TabStop = false;
            // 
            // reminderCanButt
            // 
            this.reminderCanButt.Location = new System.Drawing.Point(270, 333);
            this.reminderCanButt.Name = "reminderCanButt";
            this.reminderCanButt.Size = new System.Drawing.Size(75, 23);
            this.reminderCanButt.TabIndex = 43;
            this.reminderCanButt.Text = "Cancel";
            this.reminderCanButt.UseVisualStyleBackColor = true;
            // 
            // regBookSmitBut
            // 
            this.regBookSmitBut.Location = new System.Drawing.Point(92, 333);
            this.regBookSmitBut.Name = "regBookSmitBut";
            this.regBookSmitBut.Size = new System.Drawing.Size(75, 23);
            this.regBookSmitBut.TabIndex = 42;
            this.regBookSmitBut.Text = "Send Reminder";
            this.regBookSmitBut.UseVisualStyleBackColor = true;
            this.regBookSmitBut.Click += new System.EventHandler(this.regBookSmitBut_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(66, 221);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(304, 97);
            this.listView1.TabIndex = 46;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frmIssueReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.IssueReminderLbl);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.reminderCanButt);
            this.Controls.Add(this.regBookSmitBut);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmIssueReminder";
            this.Text = "Issue Reminder";
            this.Load += new System.EventHandler(this.frmIssueReminder_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label IssueReminderLbl;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button reminderCanButt;
        private System.Windows.Forms.Button regBookSmitBut;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}