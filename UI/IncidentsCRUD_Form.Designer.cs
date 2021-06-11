namespace UI
{
    partial class IncidentsCRUD_Form
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
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerIncidentdeadline = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbIncidentPriority = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmbIncidentType = new System.Windows.Forms.ComboBox();
            this.dateTimePickercreatedTime = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(-17, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 106);
            this.panel1.TabIndex = 1;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(377, 421);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(287, 24);
            this.cmbStatus.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Status*";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(377, 746);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(285, 50);
            this.btnupdate.TabIndex = 35;
            this.btnupdate.Text = "Update ticket";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(377, 186);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(287, 22);
            this.txtUserID.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(103, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Reported by user*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(103, 588);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Description*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 529);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "Deadline/follow up*";
            // 
            // dateTimePickerIncidentdeadline
            // 
            this.dateTimePickerIncidentdeadline.Location = new System.Drawing.Point(377, 534);
            this.dateTimePickerIncidentdeadline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerIncidentdeadline.Name = "dateTimePickerIncidentdeadline";
            this.dateTimePickerIncidentdeadline.Size = new System.Drawing.Size(287, 22);
            this.dateTimePickerIncidentdeadline.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "The Reported Full Time*";
            // 
            // cmbIncidentPriority
            // 
            this.cmbIncidentPriority.FormattingEnabled = true;
            this.cmbIncidentPriority.Location = new System.Drawing.Point(377, 369);
            this.cmbIncidentPriority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbIncidentPriority.Name = "cmbIncidentPriority";
            this.cmbIncidentPriority.Size = new System.Drawing.Size(287, 24);
            this.cmbIncidentPriority.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Incident Priority*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Incident Type*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Subject Email*";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(377, 588);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(287, 132);
            this.txtDescription.TabIndex = 24;
            // 
            // cmbIncidentType
            // 
            this.cmbIncidentType.AllowDrop = true;
            this.cmbIncidentType.FormattingEnabled = true;
            this.cmbIncidentType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbIncidentType.Location = new System.Drawing.Point(377, 306);
            this.cmbIncidentType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbIncidentType.Name = "cmbIncidentType";
            this.cmbIncidentType.Size = new System.Drawing.Size(287, 24);
            this.cmbIncidentType.TabIndex = 23;
            // 
            // dateTimePickercreatedTime
            // 
            this.dateTimePickercreatedTime.Location = new System.Drawing.Point(377, 475);
            this.dateTimePickercreatedTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickercreatedTime.Name = "dateTimePickercreatedTime";
            this.dateTimePickercreatedTime.Size = new System.Drawing.Size(287, 22);
            this.dateTimePickercreatedTime.TabIndex = 22;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(377, 249);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(287, 22);
            this.txtEmail.TabIndex = 21;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(107, 746);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(247, 50);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Create ticket";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // IncidentsCRUD_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 898);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerIncidentdeadline);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbIncidentPriority);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cmbIncidentType);
            this.Controls.Add(this.dateTimePickercreatedTime);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IncidentsCRUD_Form";
            this.Text = "CRUD_Incident_Form";
            this.Load += new System.EventHandler(this.IncidentsCRUD_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerIncidentdeadline;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbIncidentPriority;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbIncidentType;
        private System.Windows.Forms.DateTimePicker dateTimePickercreatedTime;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAdd;
    }
}