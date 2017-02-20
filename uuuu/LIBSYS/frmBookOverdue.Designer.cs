namespace LIBSYS
{
    partial class frmBookOverdue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookOverdue));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.IssueReminderLbl = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.reminderCanButt = new System.Windows.Forms.Button();
            this.OverdueButPrint = new System.Windows.Forms.Button();
            this.radioBut24Late = new System.Windows.Forms.RadioButton();
            this.radioBtn7DaysLate = new System.Windows.Forms.RadioButton();
            this.radioBtn14days = new System.Windows.Forms.RadioButton();
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
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
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
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(59, 320);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(304, 97);
            this.listView1.TabIndex = 51;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // IssueReminderLbl
            // 
            this.IssueReminderLbl.AutoSize = true;
            this.IssueReminderLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IssueReminderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueReminderLbl.Location = new System.Drawing.Point(124, 145);
            this.IssueReminderLbl.Name = "IssueReminderLbl";
            this.IssueReminderLbl.Size = new System.Drawing.Size(216, 33);
            this.IssueReminderLbl.TabIndex = 50;
            this.IssueReminderLbl.Text = "Overdue Books";
            // 
            // pic
            // 
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(110, 12);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(253, 119);
            this.pic.TabIndex = 49;
            this.pic.TabStop = false;
            // 
            // reminderCanButt
            // 
            this.reminderCanButt.Location = new System.Drawing.Point(248, 437);
            this.reminderCanButt.Name = "reminderCanButt";
            this.reminderCanButt.Size = new System.Drawing.Size(75, 23);
            this.reminderCanButt.TabIndex = 48;
            this.reminderCanButt.Text = "Cancel";
            this.reminderCanButt.UseVisualStyleBackColor = true;
            // 
            // OverdueButPrint
            // 
            this.OverdueButPrint.Location = new System.Drawing.Point(89, 437);
            this.OverdueButPrint.Name = "OverdueButPrint";
            this.OverdueButPrint.Size = new System.Drawing.Size(75, 23);
            this.OverdueButPrint.TabIndex = 47;
            this.OverdueButPrint.Text = "Print";
            this.OverdueButPrint.UseVisualStyleBackColor = true;
            this.OverdueButPrint.Click += new System.EventHandler(this.OverdueButPrint_Click);
            // 
            // radioBut24Late
            // 
            this.radioBut24Late.AutoSize = true;
            this.radioBut24Late.Location = new System.Drawing.Point(106, 200);
            this.radioBut24Late.Name = "radioBut24Late";
            this.radioBut24Late.Size = new System.Drawing.Size(92, 17);
            this.radioBut24Late.TabIndex = 52;
            this.radioBut24Late.TabStop = true;
            this.radioBut24Late.Text = "24 Hours Late";
            this.radioBut24Late.UseVisualStyleBackColor = true;
            // 
            // radioBtn7DaysLate
            // 
            this.radioBtn7DaysLate.AutoSize = true;
            this.radioBtn7DaysLate.Location = new System.Drawing.Point(106, 236);
            this.radioBtn7DaysLate.Name = "radioBtn7DaysLate";
            this.radioBtn7DaysLate.Size = new System.Drawing.Size(106, 17);
            this.radioBtn7DaysLate.TabIndex = 53;
            this.radioBtn7DaysLate.TabStop = true;
            this.radioBtn7DaysLate.Text = "Over 7 days Late";
            this.radioBtn7DaysLate.UseVisualStyleBackColor = true;
            // 
            // radioBtn14days
            // 
            this.radioBtn14days.AutoSize = true;
            this.radioBtn14days.Location = new System.Drawing.Point(106, 276);
            this.radioBtn14days.Name = "radioBtn14days";
            this.radioBtn14days.Size = new System.Drawing.Size(114, 17);
            this.radioBtn14days.TabIndex = 54;
            this.radioBtn14days.TabStop = true;
            this.radioBtn14days.Text = "Over 14 Days Late";
            this.radioBtn14days.UseVisualStyleBackColor = true;
            // 
            // frmBookOverdue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 489);
            this.Controls.Add(this.radioBtn14days);
            this.Controls.Add(this.radioBtn7DaysLate);
            this.Controls.Add(this.radioBut24Late);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.IssueReminderLbl);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.reminderCanButt);
            this.Controls.Add(this.OverdueButPrint);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBookOverdue";
            this.Text = "frmBookOverdue";
            this.Load += new System.EventHandler(this.frmBookOverdue_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label IssueReminderLbl;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button reminderCanButt;
        private System.Windows.Forms.Button OverdueButPrint;
        private System.Windows.Forms.RadioButton radioBut24Late;
        private System.Windows.Forms.RadioButton radioBtn7DaysLate;
        private System.Windows.Forms.RadioButton radioBtn14days;
    }
}