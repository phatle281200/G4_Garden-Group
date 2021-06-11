namespace UI
{
    partial class Dashboard_form
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
            this.label4 = new System.Windows.Forms.Label();
            this.currentIncidentLb = new System.Windows.Forms.Label();
            this.unresolvedIncidents = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pastdeadlineIncidents = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShowList = new System.Windows.Forms.Button();
            this.lblunresolved = new System.Windows.Forms.Label();
            this.lblAll = new System.Windows.Forms.Label();
            this.lblPastDl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 80);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(157, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 33);
            this.label4.TabIndex = 38;
            this.label4.Text = "Dashboard Statistic";
            // 
            // currentIncidentLb
            // 
            this.currentIncidentLb.AutoSize = true;
            this.currentIncidentLb.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentIncidentLb.Location = new System.Drawing.Point(36, 95);
            this.currentIncidentLb.Name = "currentIncidentLb";
            this.currentIncidentLb.Size = new System.Drawing.Size(161, 26);
            this.currentIncidentLb.TabIndex = 3;
            this.currentIncidentLb.Text = "Current Incidents";
            // 
            // unresolvedIncidents
            // 
            this.unresolvedIncidents.AutoSize = true;
            this.unresolvedIncidents.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unresolvedIncidents.Location = new System.Drawing.Point(207, 148);
            this.unresolvedIncidents.Name = "unresolvedIncidents";
            this.unresolvedIncidents.Size = new System.Drawing.Size(178, 23);
            this.unresolvedIncidents.TabIndex = 5;
            this.unresolvedIncidents.Text = "Unresolved Incidents";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "All tickets currently open";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "/";
            // 
            // pastdeadlineIncidents
            // 
            this.pastdeadlineIncidents.AutoSize = true;
            this.pastdeadlineIncidents.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pastdeadlineIncidents.Location = new System.Drawing.Point(195, 351);
            this.pastdeadlineIncidents.Name = "pastdeadlineIncidents";
            this.pastdeadlineIncidents.Size = new System.Drawing.Size(194, 23);
            this.pastdeadlineIncidents.TabIndex = 11;
            this.pastdeadlineIncidents.Text = "Incidents past deadline";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "These tickets need your immediate attention";
            // 
            // btnShowList
            // 
            this.btnShowList.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnShowList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowList.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnShowList.Location = new System.Drawing.Point(446, 92);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(107, 29);
            this.btnShowList.TabIndex = 14;
            this.btnShowList.Text = "SHOW LIST";
            this.btnShowList.UseVisualStyleBackColor = false;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // lblunresolved
            // 
            this.lblunresolved.AutoSize = true;
            this.lblunresolved.Location = new System.Drawing.Point(236, 214);
            this.lblunresolved.Name = "lblunresolved";
            this.lblunresolved.Size = new System.Drawing.Size(0, 13);
            this.lblunresolved.TabIndex = 15;
            // 
            // lblAll
            // 
            this.lblAll.AutoSize = true;
            this.lblAll.Location = new System.Drawing.Point(298, 214);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(0, 13);
            this.lblAll.TabIndex = 16;
            // 
            // lblPastDl
            // 
            this.lblPastDl.AutoSize = true;
            this.lblPastDl.Location = new System.Drawing.Point(267, 419);
            this.lblPastDl.Name = "lblPastDl";
            this.lblPastDl.Size = new System.Drawing.Size(0, 13);
            this.lblPastDl.TabIndex = 17;
            // 
            // Dashboard_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 545);
            this.Controls.Add(this.lblPastDl);
            this.Controls.Add(this.lblAll);
            this.Controls.Add(this.lblunresolved);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pastdeadlineIncidents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unresolvedIncidents);
            this.Controls.Add(this.currentIncidentLb);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard_form";
            this.Text = "Statistics_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label currentIncidentLb;
        private System.Windows.Forms.Label unresolvedIncidents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pastdeadlineIncidents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.Label lblunresolved;
        private System.Windows.Forms.Label lblAll;
        private System.Windows.Forms.Label lblPastDl;
        private System.Windows.Forms.Label label4;
    }
}