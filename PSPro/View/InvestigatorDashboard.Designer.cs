
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
            this.userFullNameLabel = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.LogoutLinkLabel = new System.Windows.Forms.LinkLabel();
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
            // InvestigatorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 50F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 900);
            this.Controls.Add(this.userFullNameLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.LogoutLinkLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvestigatorDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PsPro - Investigator - Complaints";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userFullNameLabel;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.LinkLabel LogoutLinkLabel;
    }
}