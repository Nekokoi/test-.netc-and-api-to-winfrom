namespace testquadra
{
    partial class mainuser
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.จดการขอมลToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.จดการขอมลสนคาToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ขอมลโดยรวมToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1015, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.จดการขอมลToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1015, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // จดการขอมลToolStripMenuItem
            // 
            this.จดการขอมลToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.จดการขอมลสนคาToolStripMenuItem,
            this.ขอมลโดยรวมToolStripMenuItem});
            this.จดการขอมลToolStripMenuItem.Name = "จดการขอมลToolStripMenuItem";
            this.จดการขอมลToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.จดการขอมลToolStripMenuItem.Text = "จัดการข้อมูล";
            // 
            // จดการขอมลสนคาToolStripMenuItem
            // 
            this.จดการขอมลสนคาToolStripMenuItem.Name = "จดการขอมลสนคาToolStripMenuItem";
            this.จดการขอมลสนคาToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.จดการขอมลสนคาToolStripMenuItem.Text = "จัดการข้อมูลสินค้า";
            // 
            // ขอมลโดยรวมToolStripMenuItem
            // 
            this.ขอมลโดยรวมToolStripMenuItem.Name = "ขอมลโดยรวมToolStripMenuItem";
            this.ขอมลโดยรวมToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ขอมลโดยรวมToolStripMenuItem.Text = "ข้อมูลโดยรวม";
            this.ขอมลโดยรวมToolStripMenuItem.Click += new System.EventHandler(this.ขอมลโดยรวมToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 599);
            this.panel1.TabIndex = 2;
            // 
            // mainuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 666);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainuser";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem จดการขอมลToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem จดการขอมลสนคาToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ขอมลโดยรวมToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}

