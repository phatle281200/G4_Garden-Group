namespace UI
{
    partial class Menu_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Form));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketOverviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addIncidentTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferIncidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Licensed to: The garden group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "HelpDesk";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(461, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.incidentManagementToolStripMenuItem,
            this.userManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(595, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardStatisticsToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // dashboardStatisticsToolStripMenuItem
            // 
            this.dashboardStatisticsToolStripMenuItem.Name = "dashboardStatisticsToolStripMenuItem";
            this.dashboardStatisticsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dashboardStatisticsToolStripMenuItem.Text = "Dashboard Statistics";
            this.dashboardStatisticsToolStripMenuItem.Click += new System.EventHandler(this.dashboardStatisticsToolStripMenuItem_Click);
            // 
            // incidentManagementToolStripMenuItem
            // 
            this.incidentManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticketOverviewToolStripMenuItem,
            this.addIncidentTicketToolStripMenuItem,
            this.transferIncidentToolStripMenuItem});
            this.incidentManagementToolStripMenuItem.Name = "incidentManagementToolStripMenuItem";
            this.incidentManagementToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.incidentManagementToolStripMenuItem.Text = "Incident Management";
            // 
            // ticketOverviewToolStripMenuItem
            // 
            this.ticketOverviewToolStripMenuItem.Name = "ticketOverviewToolStripMenuItem";
            this.ticketOverviewToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.ticketOverviewToolStripMenuItem.Text = "Ticket Overview";
            this.ticketOverviewToolStripMenuItem.Click += new System.EventHandler(this.ticketOverviewToolStripMenuItem_Click);
            // 
            // addIncidentTicketToolStripMenuItem
            // 
            this.addIncidentTicketToolStripMenuItem.Name = "addIncidentTicketToolStripMenuItem";
            this.addIncidentTicketToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.addIncidentTicketToolStripMenuItem.Text = "Add Incident Ticket";
            this.addIncidentTicketToolStripMenuItem.Click += new System.EventHandler(this.addIncidentTicketToolStripMenuItem_Click);
            // 
            // transferIncidentToolStripMenuItem
            // 
            this.transferIncidentToolStripMenuItem.Name = "transferIncidentToolStripMenuItem";
            this.transferIncidentToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.transferIncidentToolStripMenuItem.Text = "Transfer Incident";
            this.transferIncidentToolStripMenuItem.Click += new System.EventHandler(this.transferIncidentToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersToolStripMenuItem});
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.userManagementToolStripMenuItem.Text = "User Management";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 106);
            this.panel1.TabIndex = 7;
            // 
            // Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(595, 361);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu_Form";
            this.Text = "Menu_Form";
            this.Load += new System.EventHandler(this.Menu_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketOverviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addIncidentTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferIncidentToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}