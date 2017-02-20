namespace LIBSYS
{
    partial class frmMostPopularBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMostPopularBooks));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioBtn12month = new System.Windows.Forms.RadioButton();
            this.radioBut6Months = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.IssueReminderLbl = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.reminderCanButt = new System.Windows.Forms.Button();
            this.OverdueButPrint = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(515, 24);
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
            // radioBtn12month
            // 
            this.radioBtn12month.AutoSize = true;
            this.radioBtn12month.Location = new System.Drawing.Point(146, 235);
            this.radioBtn12month.Name = "radioBtn12month";
            this.radioBtn12month.Size = new System.Drawing.Size(102, 17);
            this.radioBtn12month.TabIndex = 61;
            this.radioBtn12month.TabStop = true;
            this.radioBtn12month.Text = "12 month Period";
            this.radioBtn12month.UseVisualStyleBackColor = true;
            // 
            // radioBut6Months
            // 
            this.radioBut6Months.AutoSize = true;
            this.radioBut6Months.Location = new System.Drawing.Point(146, 199);
            this.radioBut6Months.Name = "radioBut6Months";
            this.radioBut6Months.Size = new System.Drawing.Size(97, 17);
            this.radioBut6Months.TabIndex = 60;
            this.radioBut6Months.TabStop = true;
            this.radioBut6Months.Text = "6 Month Period";
            this.radioBut6Months.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(104, 269);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(304, 97);
            this.listView1.TabIndex = 59;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // IssueReminderLbl
            // 
            this.IssueReminderLbl.AutoSize = true;
            this.IssueReminderLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IssueReminderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueReminderLbl.Location = new System.Drawing.Point(146, 151);
            this.IssueReminderLbl.Name = "IssueReminderLbl";
            this.IssueReminderLbl.Size = new System.Drawing.Size(205, 33);
            this.IssueReminderLbl.TabIndex = 58;
            this.IssueReminderLbl.Text = "Popular Books";
            // 
            // pic
            // 
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(129, 12);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(253, 119);
            this.pic.TabIndex = 57;
            this.pic.TabStop = false;
            // 
            // reminderCanButt
            // 
            this.reminderCanButt.Location = new System.Drawing.Point(293, 393);
            this.reminderCanButt.Name = "reminderCanButt";
            this.reminderCanButt.Size = new System.Drawing.Size(75, 23);
            this.reminderCanButt.TabIndex = 56;
            this.reminderCanButt.Text = "Cancel";
            this.reminderCanButt.UseVisualStyleBackColor = true;
            // 
            // OverdueButPrint
            // 
            this.OverdueButPrint.Location = new System.Drawing.Point(129, 393);
            this.OverdueButPrint.Name = "OverdueButPrint";
            this.OverdueButPrint.Size = new System.Drawing.Size(75, 23);
            this.OverdueButPrint.TabIndex = 55;
            this.OverdueButPrint.Text = "Print";
            this.OverdueButPrint.UseVisualStyleBackColor = true;
            this.OverdueButPrint.Click += new System.EventHandler(this.OverdueButPrint_Click);
            // 
            // frmMostPopularBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 470);
            this.Controls.Add(this.radioBtn12month);
            this.Controls.Add(this.radioBut6Months);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.IssueReminderLbl);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.reminderCanButt);
            this.Controls.Add(this.OverdueButPrint);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMostPopularBooks";
            this.Text = "LIBSYS-Most Popular Books";
            this.Load += new System.EventHandler(this.frmMostPopularBooks_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioBtn12month;
        private System.Windows.Forms.RadioButton radioBut6Months;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label IssueReminderLbl;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button reminderCanButt;
        private System.Windows.Forms.Button OverdueButPrint;
    }
}