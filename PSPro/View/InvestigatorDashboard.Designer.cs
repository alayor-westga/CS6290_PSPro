﻿
namespace PSPro.View
{
    partial class InvestigatorDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvestigatorDashboard));
            this.userFullNameLabel = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.LogoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.complaintListTabControl = new System.Windows.Forms.TabControl();
            this.complaintListTabPage = new System.Windows.Forms.TabPage();
            this.complaintList = new PSPro.UserControls.ComplaintList();
            this.manageComplaintTabPage = new System.Windows.Forms.TabPage();
            this.manageComplaintAsInvestigator = new PSPro.UserControls.ManageComplaintAsInvestigator();
            this.complaintListTabControl.SuspendLayout();
            this.complaintListTabPage.SuspendLayout();
            this.manageComplaintTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // userFullNameLabel
            // 
            this.userFullNameLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.userFullNameLabel.Location = new System.Drawing.Point(174, 21);
            this.userFullNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userFullNameLabel.Name = "userFullNameLabel";
            this.userFullNameLabel.Size = new System.Drawing.Size(712, 52);
            this.userFullNameLabel.TabIndex = 29;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.WelcomeLabel.Location = new System.Drawing.Point(2, 21);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(179, 51);
            this.WelcomeLabel.TabIndex = 28;
            this.WelcomeLabel.Text = "Welcome";
            // 
            // LogoutLinkLabel
            // 
            this.LogoutLinkLabel.AutoSize = true;
            this.LogoutLinkLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.LogoutLinkLabel.Location = new System.Drawing.Point(1186, 7);
            this.LogoutLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogoutLinkLabel.Name = "LogoutLinkLabel";
            this.LogoutLinkLabel.Size = new System.Drawing.Size(141, 51);
            this.LogoutLinkLabel.TabIndex = 27;
            this.LogoutLinkLabel.TabStop = true;
            this.LogoutLinkLabel.Text = "Logout";
            this.LogoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // complaintListTabControl
            // 
            this.complaintListTabControl.Controls.Add(this.complaintListTabPage);
            this.complaintListTabControl.Controls.Add(this.manageComplaintTabPage);
            this.complaintListTabControl.Location = new System.Drawing.Point(-3, 98);
            this.complaintListTabControl.Name = "complaintListTabControl";
            this.complaintListTabControl.SelectedIndex = 0;
            this.complaintListTabControl.Size = new System.Drawing.Size(1324, 790);
            this.complaintListTabControl.TabIndex = 30;
            this.complaintListTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.complaintListTabControl_Selected);
            // 
            // complaintListTabPage
            // 
            this.complaintListTabPage.Controls.Add(this.complaintList);
            this.complaintListTabPage.Location = new System.Drawing.Point(8, 64);
            this.complaintListTabPage.Name = "complaintListTabPage";
            this.complaintListTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.complaintListTabPage.Size = new System.Drawing.Size(1308, 718);
            this.complaintListTabPage.TabIndex = 0;
            this.complaintListTabPage.Text = "Complaint List";
            this.complaintListTabPage.UseVisualStyleBackColor = true;
            // 
            // complaintList
            // 
            this.complaintList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.complaintList.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complaintList.Location = new System.Drawing.Point(3, 3);
            this.complaintList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.complaintList.Name = "complaintList";
            this.complaintList.Size = new System.Drawing.Size(1302, 712);
            this.complaintList.TabIndex = 0;
            // 
            // manageComplaintTabPage
            // 
            this.manageComplaintTabPage.Controls.Add(this.manageComplaintAsInvestigator);
            this.manageComplaintTabPage.Location = new System.Drawing.Point(8, 64);
            this.manageComplaintTabPage.Name = "manageComplaintTabPage";
            this.manageComplaintTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.manageComplaintTabPage.Size = new System.Drawing.Size(1308, 718);
            this.manageComplaintTabPage.TabIndex = 1;
            this.manageComplaintTabPage.Text = "Manage Complaint";
            this.manageComplaintTabPage.UseVisualStyleBackColor = true;
            // 
            // manageComplaintAsInvestigator
            // 
            this.manageComplaintAsInvestigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageComplaintAsInvestigator.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageComplaintAsInvestigator.Location = new System.Drawing.Point(3, 3);
            this.manageComplaintAsInvestigator.Margin = new System.Windows.Forms.Padding(4);
            this.manageComplaintAsInvestigator.Name = "manageComplaintAsInvestigator";
            this.manageComplaintAsInvestigator.Size = new System.Drawing.Size(1302, 712);
            this.manageComplaintAsInvestigator.TabIndex = 0;
            // 
            // InvestigatorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 50F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 900);
            this.Controls.Add(this.complaintListTabControl);
            this.Controls.Add(this.userFullNameLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.LogoutLinkLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvestigatorDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PsPro - Investigator - Complaints";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InvestigatorDashboard_FormClosed);
            this.complaintListTabControl.ResumeLayout(false);
            this.complaintListTabPage.ResumeLayout(false);
            this.manageComplaintTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userFullNameLabel;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.LinkLabel LogoutLinkLabel;
        private System.Windows.Forms.TabControl complaintListTabControl;
        private System.Windows.Forms.TabPage complaintListTabPage;
        private System.Windows.Forms.TabPage manageComplaintTabPage;
        private UserControls.ComplaintList complaintList;
        private UserControls.ManageComplaintAsInvestigator manageComplaintAsInvestigator;
    }
}