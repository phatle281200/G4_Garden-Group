namespace UI
{
    partial class IncidentDisplay_Form
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
            this.txtFilterByEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEmailFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-10, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 80);
            this.panel1.TabIndex = 1;
            // 
            // txtFilterByEmail
            // 
            this.txtFilterByEmail.Location = new System.Drawing.Point(129, 126);
            this.txtFilterByEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFilterByEmail.Name = "txtFilterByEmail";
            this.txtFilterByEmail.Size = new System.Drawing.Size(219, 20);
            this.txtFilterByEmail.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "filter by";
            // 
            // btnEmailFilter
            // 
            this.btnEmailFilter.Location = new System.Drawing.Point(423, 120);
            this.btnEmailFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEmailFilter.Name = "btnEmailFilter";
            this.btnEmailFilter.Size = new System.Drawing.Size(129, 30);
            this.btnEmailFilter.TabIndex = 9;
            this.btnEmailFilter.Text = "Filter";
            this.btnEmailFilter.UseVisualStyleBackColor = true;
            this.btnEmailFilter.Click += new System.EventHandler(this.btnEmailFilter_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "List of incidents";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(21, 171);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(553, 543);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(155, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 33);
            this.label3.TabIndex = 38;
            this.label3.Text = "Incident Management";
            // 
            // IncidentDisplay_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 737);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtFilterByEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEmailFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "IncidentDisplay_Form";
            this.Text = "IncidentDisplay_Form";
            this.Load += new System.EventHandler(this.IncidentDisplay_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFilterByEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEmailFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label3;
    }
}