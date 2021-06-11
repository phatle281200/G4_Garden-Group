namespace UI
{
    partial class UsersManage_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.listview_Users = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.first = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.last = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tickets = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_addUser = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-5, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 80);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(166, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 33);
            this.label3.TabIndex = 36;
            this.label3.Text = "User Management";
            // 
            // listview_Users
            // 
            this.listview_Users.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Email,
            this.first,
            this.last,
            this.tickets});
            this.listview_Users.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listview_Users.FullRowSelect = true;
            this.listview_Users.GridLines = true;
            this.listview_Users.HideSelection = false;
            this.listview_Users.Location = new System.Drawing.Point(12, 95);
            this.listview_Users.Name = "listview_Users";
            this.listview_Users.Size = new System.Drawing.Size(568, 577);
            this.listview_Users.TabIndex = 3;
            this.listview_Users.UseCompatibleStateImageBehavior = false;
            this.listview_Users.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 55;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 197;
            // 
            // first
            // 
            this.first.Text = "First name";
            this.first.Width = 120;
            // 
            // last
            // 
            this.last.Text = "Last name";
            this.last.Width = 120;
            // 
            // tickets
            // 
            this.tickets.Text = "# tickets";
            this.tickets.Width = 75;
            // 
            // btn_addUser
            // 
            this.btn_addUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_addUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addUser.ForeColor = System.Drawing.Color.White;
            this.btn_addUser.Location = new System.Drawing.Point(460, 689);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(106, 29);
            this.btn_addUser.TabIndex = 19;
            this.btn_addUser.Text = "Add user";
            this.btn_addUser.UseVisualStyleBackColor = false;
            this.btn_addUser.Click += new System.EventHandler(this.btn_addUser_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(23, 689);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(106, 29);
            this.btn_edit.TabIndex = 21;
            this.btn_edit.Text = "Edit user";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // UsersManage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 730);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_addUser);
            this.Controls.Add(this.listview_Users);
            this.Controls.Add(this.panel1);
            this.Name = "UsersManage_Form";
            this.Text = "Users_Form";
            this.Load += new System.EventHandler(this.UsersManage_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listview_Users;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader first;
        private System.Windows.Forms.ColumnHeader last;
        private System.Windows.Forms.ColumnHeader tickets;
        private System.Windows.Forms.Button btn_addUser;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label label3;
    }
}