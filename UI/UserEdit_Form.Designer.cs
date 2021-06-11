namespace UI
{
    partial class UserEdit_Form
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
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_deleteUser = new System.Windows.Forms.Button();
            this.lbl_fullname = new System.Windows.Forms.Label();
            this.btn_editUser = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_number = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_typeUser = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.combo_usertype = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 84);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(170, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 33);
            this.label3.TabIndex = 37;
            this.label3.Text = "User Management";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(115, 439);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(97, 24);
            this.lbl_password.TabIndex = 62;
            this.lbl_password.Text = "Password:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(115, 397);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(102, 24);
            this.lbl_username.TabIndex = 61;
            this.lbl_username.Text = "Username:";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(286, 443);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(216, 20);
            this.txt_password.TabIndex = 60;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(286, 401);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(216, 20);
            this.txt_username.TabIndex = 59;
            // 
            // btn_deleteUser
            // 
            this.btn_deleteUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_deleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_deleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_deleteUser.Location = new System.Drawing.Point(91, 587);
            this.btn_deleteUser.Name = "btn_deleteUser";
            this.btn_deleteUser.Size = new System.Drawing.Size(152, 37);
            this.btn_deleteUser.TabIndex = 56;
            this.btn_deleteUser.Text = "Delete User";
            this.btn_deleteUser.UseVisualStyleBackColor = false;
            this.btn_deleteUser.Click += new System.EventHandler(this.btn_deleteUser_Click);
            // 
            // lbl_fullname
            // 
            this.lbl_fullname.AutoSize = true;
            this.lbl_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fullname.Location = new System.Drawing.Point(280, 107);
            this.lbl_fullname.Name = "lbl_fullname";
            this.lbl_fullname.Size = new System.Drawing.Size(55, 33);
            this.lbl_fullname.TabIndex = 55;
            this.lbl_fullname.Text = "     ";
            // 
            // btn_editUser
            // 
            this.btn_editUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_editUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_editUser.FlatAppearance.BorderSize = 0;
            this.btn_editUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_editUser.Location = new System.Drawing.Point(350, 530);
            this.btn_editUser.Name = "btn_editUser";
            this.btn_editUser.Size = new System.Drawing.Size(152, 37);
            this.btn_editUser.TabIndex = 54;
            this.btn_editUser.Text = "Confirm";
            this.btn_editUser.UseVisualStyleBackColor = false;
            this.btn_editUser.Click += new System.EventHandler(this.btn_editUser_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.Location = new System.Drawing.Point(350, 587);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(152, 37);
            this.btn_cancel.TabIndex = 53;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 33);
            this.label2.TabIndex = 52;
            this.label2.Text = "Edit user";
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_number.Location = new System.Drawing.Point(115, 294);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(142, 24);
            this.lbl_number.TabIndex = 51;
            this.lbl_number.Text = "Phone number:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(115, 252);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(137, 24);
            this.lbl_email.TabIndex = 50;
            this.lbl_email.Text = "Email Address:";
            // 
            // lbl_typeUser
            // 
            this.lbl_typeUser.AutoSize = true;
            this.lbl_typeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_typeUser.Location = new System.Drawing.Point(115, 346);
            this.lbl_typeUser.Name = "lbl_typeUser";
            this.lbl_typeUser.Size = new System.Drawing.Size(89, 24);
            this.lbl_typeUser.TabIndex = 49;
            this.lbl_typeUser.Text = "Usertype:\r\n";
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastname.Location = new System.Drawing.Point(115, 207);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(101, 24);
            this.lbl_lastname.TabIndex = 48;
            this.lbl_lastname.Text = "Last name:";
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstname.Location = new System.Drawing.Point(115, 169);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(103, 24);
            this.lbl_firstname.TabIndex = 47;
            this.lbl_firstname.Text = "First name:";
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(286, 294);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(216, 20);
            this.txt_number.TabIndex = 46;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(286, 252);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(216, 20);
            this.txt_email.TabIndex = 45;
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(286, 207);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(216, 20);
            this.txt_lastName.TabIndex = 44;
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(286, 169);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(216, 20);
            this.txt_firstName.TabIndex = 43;
            // 
            // combo_usertype
            // 
            this.combo_usertype.FormattingEnabled = true;
            this.combo_usertype.Location = new System.Drawing.Point(286, 349);
            this.combo_usertype.Name = "combo_usertype";
            this.combo_usertype.Size = new System.Drawing.Size(216, 21);
            this.combo_usertype.TabIndex = 63;
            // 
            // UserEdit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 730);
            this.Controls.Add(this.combo_usertype);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_deleteUser);
            this.Controls.Add(this.lbl_fullname);
            this.Controls.Add(this.btn_editUser);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_number);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_typeUser);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.lbl_firstname);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.panel1);
            this.Name = "UserEdit_Form";
            this.Text = "UserEdit_Form";
            this.Load += new System.EventHandler(this.UserEdit_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_deleteUser;
        private System.Windows.Forms.Label lbl_fullname;
        private System.Windows.Forms.Button btn_editUser;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_typeUser;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.ComboBox combo_usertype;
    }
}