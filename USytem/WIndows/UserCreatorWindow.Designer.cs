namespace USytem.WIndows
{
    partial class UserCreatorWindow
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ListaLewa = new System.Windows.Forms.ListView();
            this.Login = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.UpdateUser = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.permPriority = new System.Windows.Forms.CheckBox();
            this.permChangeOrders = new System.Windows.Forms.CheckBox();
            this.permCreateOrders = new System.Windows.Forms.CheckBox();
            this.permReplenishment = new System.Windows.Forms.CheckBox();
            this.permCreateUsers = new System.Windows.Forms.CheckBox();
            this.permAdmin = new System.Windows.Forms.CheckBox();
            this.permPassword = new System.Windows.Forms.TextBox();
            this.permLogin = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SearcherUserButton = new System.Windows.Forms.Button();
            this.SearcherUserTextField = new System.Windows.Forms.TextBox();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.ListaLewa);
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox4);
            this.splitContainer1.Panel2.Controls.Add(this.DeleteUserButton);
            this.splitContainer1.Panel2.Controls.Add(this.UpdateUser);
            this.splitContainer1.Panel2.Controls.Add(this.CreateButton);
            this.splitContainer1.Panel2.Controls.Add(this.textBox3);
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2.Controls.Add(this.permPriority);
            this.splitContainer1.Panel2.Controls.Add(this.permChangeOrders);
            this.splitContainer1.Panel2.Controls.Add(this.permCreateOrders);
            this.splitContainer1.Panel2.Controls.Add(this.permReplenishment);
            this.splitContainer1.Panel2.Controls.Add(this.permCreateUsers);
            this.splitContainer1.Panel2.Controls.Add(this.permAdmin);
            this.splitContainer1.Panel2.Controls.Add(this.permPassword);
            this.splitContainer1.Panel2.Controls.Add(this.permLogin);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.SearcherUserButton);
            this.splitContainer1.Panel2.Controls.Add(this.SearcherUserTextField);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 255;
            this.splitContainer1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.Yellow;
            this.textBox1.Location = new System.Drawing.Point(6, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(246, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "All Users";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ListaLewa
            // 
            this.ListaLewa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Login,
            this.Password});
            this.ListaLewa.Location = new System.Drawing.Point(6, 26);
            this.ListaLewa.Name = "ListaLewa";
            this.ListaLewa.Size = new System.Drawing.Size(245, 423);
            this.ListaLewa.TabIndex = 1;
            this.ListaLewa.UseCompatibleStateImageBehavior = false;
            this.ListaLewa.View = System.Windows.Forms.View.Details;
            this.ListaLewa.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // Login
            // 
            this.Login.Text = "Login";
            // 
            // Password
            // 
            this.Password.Text = "Password";
            this.Password.Width = 120;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(249, 448);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // UpdateUser
            // 
            this.UpdateUser.Location = new System.Drawing.Point(182, 223);
            this.UpdateUser.Name = "UpdateUser";
            this.UpdateUser.Size = new System.Drawing.Size(119, 25);
            this.UpdateUser.TabIndex = 15;
            this.UpdateUser.Text = "Update User";
            this.UpdateUser.UseVisualStyleBackColor = true;
            this.UpdateUser.Click += new System.EventHandler(this.UpdateUser_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(293, 223);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(119, 25);
            this.CreateButton.TabIndex = 14;
            this.CreateButton.Text = "Create User";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(287, 106);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(125, 20);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "Password";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(287, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(125, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "Login";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // permPriority
            // 
            this.permPriority.AutoSize = true;
            this.permPriority.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.permPriority.Location = new System.Drawing.Point(204, 178);
            this.permPriority.Name = "permPriority";
            this.permPriority.Size = new System.Drawing.Size(57, 17);
            this.permPriority.TabIndex = 11;
            this.permPriority.Text = "Priority";
            this.permPriority.UseVisualStyleBackColor = true;
            // 
            // permChangeOrders
            // 
            this.permChangeOrders.AutoSize = true;
            this.permChangeOrders.Location = new System.Drawing.Point(204, 155);
            this.permChangeOrders.Name = "permChangeOrders";
            this.permChangeOrders.Size = new System.Drawing.Size(97, 17);
            this.permChangeOrders.TabIndex = 10;
            this.permChangeOrders.Text = "Change Orders";
            this.permChangeOrders.UseVisualStyleBackColor = true;
            // 
            // permCreateOrders
            // 
            this.permCreateOrders.AutoSize = true;
            this.permCreateOrders.Location = new System.Drawing.Point(204, 132);
            this.permCreateOrders.Name = "permCreateOrders";
            this.permCreateOrders.Size = new System.Drawing.Size(91, 17);
            this.permCreateOrders.TabIndex = 9;
            this.permCreateOrders.Text = "Create Orders";
            this.permCreateOrders.UseVisualStyleBackColor = true;
            // 
            // permReplenishment
            // 
            this.permReplenishment.AutoSize = true;
            this.permReplenishment.Location = new System.Drawing.Point(68, 178);
            this.permReplenishment.Name = "permReplenishment";
            this.permReplenishment.Size = new System.Drawing.Size(96, 17);
            this.permReplenishment.TabIndex = 8;
            this.permReplenishment.Text = "Replenishment";
            this.permReplenishment.UseVisualStyleBackColor = true;
            // 
            // permCreateUsers
            // 
            this.permCreateUsers.AutoSize = true;
            this.permCreateUsers.Location = new System.Drawing.Point(68, 155);
            this.permCreateUsers.Name = "permCreateUsers";
            this.permCreateUsers.Size = new System.Drawing.Size(87, 17);
            this.permCreateUsers.TabIndex = 7;
            this.permCreateUsers.Text = "Create Users";
            this.permCreateUsers.UseVisualStyleBackColor = true;
            // 
            // permAdmin
            // 
            this.permAdmin.AutoSize = true;
            this.permAdmin.Location = new System.Drawing.Point(68, 132);
            this.permAdmin.Name = "permAdmin";
            this.permAdmin.Size = new System.Drawing.Size(55, 17);
            this.permAdmin.TabIndex = 6;
            this.permAdmin.Text = "Admin";
            this.permAdmin.UseVisualStyleBackColor = true;
            // 
            // permPassword
            // 
            this.permPassword.Location = new System.Drawing.Point(68, 106);
            this.permPassword.Name = "permPassword";
            this.permPassword.Size = new System.Drawing.Size(216, 20);
            this.permPassword.TabIndex = 5;
            // 
            // permLogin
            // 
            this.permLogin.Location = new System.Drawing.Point(68, 80);
            this.permLogin.Name = "permLogin";
            this.permLogin.Size = new System.Drawing.Size(216, 20);
            this.permLogin.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 20);
            this.button2.TabIndex = 3;
            this.button2.Text = "Exit Window";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Update Window";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SearcherUserButton
            // 
            this.SearcherUserButton.Location = new System.Drawing.Point(287, 53);
            this.SearcherUserButton.Name = "SearcherUserButton";
            this.SearcherUserButton.Size = new System.Drawing.Size(125, 21);
            this.SearcherUserButton.TabIndex = 1;
            this.SearcherUserButton.Text = "Find User";
            this.SearcherUserButton.UseVisualStyleBackColor = true;
            this.SearcherUserButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearcherUserTextField
            // 
            this.SearcherUserTextField.Location = new System.Drawing.Point(68, 54);
            this.SearcherUserTextField.Name = "SearcherUserTextField";
            this.SearcherUserTextField.Size = new System.Drawing.Size(216, 20);
            this.SearcherUserTextField.TabIndex = 0;
            this.SearcherUserTextField.TextChanged += new System.EventHandler(this.SearcherUserTextField_TextChanged);
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.Location = new System.Drawing.Point(68, 223);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(119, 25);
            this.DeleteUserButton.TabIndex = 16;
            this.DeleteUserButton.Text = "Delete User";
            this.DeleteUserButton.UseVisualStyleBackColor = true;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.Location = new System.Drawing.Point(68, 28);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(216, 20);
            this.textBox4.TabIndex = 17;
            this.textBox4.Text = "To Find Or Change";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // UserCreatorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserCreatorWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "UserCreatorWindow";
            this.Load += new System.EventHandler(this.UserCreatorWindow_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView ListaLewa;
        private System.Windows.Forms.ColumnHeader Login;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SearcherUserButton;
        private System.Windows.Forms.TextBox SearcherUserTextField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox permAdmin;
        private System.Windows.Forms.TextBox permPassword;
        private System.Windows.Forms.TextBox permLogin;
        private System.Windows.Forms.CheckBox permPriority;
        private System.Windows.Forms.CheckBox permChangeOrders;
        private System.Windows.Forms.CheckBox permCreateOrders;
        private System.Windows.Forms.CheckBox permReplenishment;
        private System.Windows.Forms.CheckBox permCreateUsers;
        private System.Windows.Forms.Button UpdateUser;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.TextBox textBox4;
    }
}