namespace UI
{
    partial class TransferIncidentPage
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
            this.combobxIncident = new System.Windows.Forms.ComboBox();
            this.combobxUsers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTransferTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combobxIncident
            // 
            this.combobxIncident.FormattingEnabled = true;
            this.combobxIncident.Location = new System.Drawing.Point(172, 58);
            this.combobxIncident.Name = "combobxIncident";
            this.combobxIncident.Size = new System.Drawing.Size(204, 24);
            this.combobxIncident.TabIndex = 0;
            // 
            // combobxUsers
            // 
            this.combobxUsers.FormattingEnabled = true;
            this.combobxUsers.Location = new System.Drawing.Point(172, 131);
            this.combobxUsers.Name = "combobxUsers";
            this.combobxUsers.Size = new System.Drawing.Size(204, 24);
            this.combobxUsers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Incident:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Transfer to:";
            // 
            // btnTransferTicket
            // 
            this.btnTransferTicket.Location = new System.Drawing.Point(159, 229);
            this.btnTransferTicket.Name = "btnTransferTicket";
            this.btnTransferTicket.Size = new System.Drawing.Size(227, 53);
            this.btnTransferTicket.TabIndex = 4;
            this.btnTransferTicket.Text = "Transfer Ticket";
            this.btnTransferTicket.UseVisualStyleBackColor = true;
            this.btnTransferTicket.Click += new System.EventHandler(this.btnTransferTicket_Click);
            // 
            // TransferIncidentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 361);
            this.Controls.Add(this.btnTransferTicket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combobxUsers);
            this.Controls.Add(this.combobxIncident);
            this.Name = "TransferIncidentPage";
            this.Text = "TransferIncident";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobxIncident;
        private System.Windows.Forms.ComboBox combobxUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTransferTicket;
    }
}