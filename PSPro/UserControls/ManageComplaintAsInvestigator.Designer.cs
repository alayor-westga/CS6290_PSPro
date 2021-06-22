
namespace PSPro.UserControls
{
    partial class ManageComplaintAsInvestigator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.citizenGroupBox = new System.Windows.Forms.GroupBox();
            this.citizenNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.citizenAddressLabel = new System.Windows.Forms.Label();
            this.citizenAddressLabelValue = new System.Windows.Forms.Label();
            this.citizenPhoneLabel = new System.Windows.Forms.Label();
            this.citizenPhoneLabelValue = new System.Windows.Forms.Label();
            this.citizenGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // citizenGroupBox
            // 
            this.citizenGroupBox.Controls.Add(this.citizenPhoneLabelValue);
            this.citizenGroupBox.Controls.Add(this.citizenPhoneLabel);
            this.citizenGroupBox.Controls.Add(this.citizenAddressLabelValue);
            this.citizenGroupBox.Controls.Add(this.citizenAddressLabel);
            this.citizenGroupBox.Controls.Add(this.label1);
            this.citizenGroupBox.Controls.Add(this.citizenNameLabel);
            this.citizenGroupBox.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citizenGroupBox.Location = new System.Drawing.Point(30, 32);
            this.citizenGroupBox.Name = "citizenGroupBox";
            this.citizenGroupBox.Size = new System.Drawing.Size(1246, 230);
            this.citizenGroupBox.TabIndex = 0;
            this.citizenGroupBox.TabStop = false;
            this.citizenGroupBox.Text = "Citizen";
            // 
            // citizenNameLabel
            // 
            this.citizenNameLabel.AutoSize = true;
            this.citizenNameLabel.Location = new System.Drawing.Point(38, 53);
            this.citizenNameLabel.Name = "citizenNameLabel";
            this.citizenNameLabel.Size = new System.Drawing.Size(128, 50);
            this.citizenNameLabel.TabIndex = 0;
            this.citizenNameLabel.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "--";
            // 
            // citizenAddressLabel
            // 
            this.citizenAddressLabel.AutoSize = true;
            this.citizenAddressLabel.Location = new System.Drawing.Point(38, 103);
            this.citizenAddressLabel.Name = "citizenAddressLabel";
            this.citizenAddressLabel.Size = new System.Drawing.Size(162, 50);
            this.citizenAddressLabel.TabIndex = 2;
            this.citizenAddressLabel.Text = "Address:";
            // 
            // citizenAddressLabelValue
            // 
            this.citizenAddressLabelValue.AutoSize = true;
            this.citizenAddressLabelValue.Location = new System.Drawing.Point(206, 103);
            this.citizenAddressLabelValue.Name = "citizenAddressLabelValue";
            this.citizenAddressLabelValue.Size = new System.Drawing.Size(52, 50);
            this.citizenAddressLabelValue.TabIndex = 3;
            this.citizenAddressLabelValue.Text = "--";
            // 
            // citizenPhoneLabel
            // 
            this.citizenPhoneLabel.AutoSize = true;
            this.citizenPhoneLabel.Location = new System.Drawing.Point(38, 153);
            this.citizenPhoneLabel.Name = "citizenPhoneLabel";
            this.citizenPhoneLabel.Size = new System.Drawing.Size(279, 50);
            this.citizenPhoneLabel.TabIndex = 4;
            this.citizenPhoneLabel.Text = "Phone Number:";
            // 
            // citizenPhoneLabelValue
            // 
            this.citizenPhoneLabelValue.AutoSize = true;
            this.citizenPhoneLabelValue.Location = new System.Drawing.Point(323, 153);
            this.citizenPhoneLabelValue.Name = "citizenPhoneLabelValue";
            this.citizenPhoneLabelValue.Size = new System.Drawing.Size(52, 50);
            this.citizenPhoneLabelValue.TabIndex = 5;
            this.citizenPhoneLabelValue.Text = "--";
            // 
            // ManageComplaintAsInvestigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.citizenGroupBox);
            this.Name = "ManageComplaintAsInvestigator";
            this.Size = new System.Drawing.Size(1308, 718);
            this.citizenGroupBox.ResumeLayout(false);
            this.citizenGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox citizenGroupBox;
        private System.Windows.Forms.Label citizenNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label citizenPhoneLabelValue;
        private System.Windows.Forms.Label citizenPhoneLabel;
        private System.Windows.Forms.Label citizenAddressLabelValue;
        private System.Windows.Forms.Label citizenAddressLabel;
    }
}
