namespace USytem.WIndows
{
    partial class ControlerWindow
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
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Zakładki = new System.Windows.Forms.TabControl();
            this.TaskPage = new System.Windows.Forms.TabPage();
            this.OrdersPage = new System.Windows.Forms.TabPage();
            this.HistoryPage = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.Zakładki.SuspendLayout();
            this.OrdersPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.createNewUserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.logoutToolStripMenuItem.Text = "Program";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem1.Text = "Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // createNewUserToolStripMenuItem
            // 
            this.createNewUserToolStripMenuItem.Name = "createNewUserToolStripMenuItem";
            this.createNewUserToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.createNewUserToolStripMenuItem.Text = "Create New User";
            this.createNewUserToolStripMenuItem.Click += new System.EventHandler(this.createNewUserToolStripMenuItem_Click);
            // 
            // Zakładki
            // 
            this.Zakładki.CausesValidation = false;
            this.Zakładki.Controls.Add(this.TaskPage);
            this.Zakładki.Controls.Add(this.OrdersPage);
            this.Zakładki.Controls.Add(this.HistoryPage);
            this.Zakładki.ItemSize = new System.Drawing.Size(80, 25);
            this.Zakładki.Location = new System.Drawing.Point(0, 27);
            this.Zakładki.Name = "Zakładki";
            this.Zakładki.SelectedIndex = 0;
            this.Zakładki.Size = new System.Drawing.Size(800, 423);
            this.Zakładki.TabIndex = 1;
            // 
            // TaskPage
            // 
            this.TaskPage.Location = new System.Drawing.Point(4, 29);
            this.TaskPage.Name = "TaskPage";
            this.TaskPage.Padding = new System.Windows.Forms.Padding(3);
            this.TaskPage.Size = new System.Drawing.Size(792, 390);
            this.TaskPage.TabIndex = 0;
            this.TaskPage.Text = "Task";
            this.TaskPage.UseVisualStyleBackColor = true;
            this.TaskPage.Click += new System.EventHandler(this.TaskPage_Click);
            // 
            // OrdersPage
            // 
            this.OrdersPage.Controls.Add(this.richTextBox1);
            this.OrdersPage.Location = new System.Drawing.Point(4, 29);
            this.OrdersPage.Name = "OrdersPage";
            this.OrdersPage.Size = new System.Drawing.Size(792, 390);
            this.OrdersPage.TabIndex = 1;
            this.OrdersPage.Text = "Orders";
            this.OrdersPage.UseVisualStyleBackColor = true;
            this.OrdersPage.Click += new System.EventHandler(this.OrdersPage_Click);
            // 
            // HistoryPage
            // 
            this.HistoryPage.Location = new System.Drawing.Point(4, 29);
            this.HistoryPage.Name = "HistoryPage";
            this.HistoryPage.Size = new System.Drawing.Size(792, 390);
            this.HistoryPage.TabIndex = 2;
            this.HistoryPage.Text = "History";
            this.HistoryPage.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(65, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(304, 149);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // ControlerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Zakładki);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ControlerWindow";
            this.Text = "ControlerWindow";
            this.Load += new System.EventHandler(this.ControlerWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Zakładki.ResumeLayout(false);
            this.OrdersPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl Zakładki;
        private System.Windows.Forms.TabPage HistoryPage;
        private System.Windows.Forms.TabPage TaskPage;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage OrdersPage;
    }
}