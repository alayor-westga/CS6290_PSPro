
namespace PSPro.UserControls
{
    partial class ManageComplaintAsAdministrator
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
            this.complaintGroupBox = new System.Windows.Forms.GroupBox();
            this.seeNotesButton = new System.Windows.Forms.Button();
            this.disciplineComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dispositionLabelValue = new System.Windows.Forms.Label();
            this.disciplineLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.dateLabelValue = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.notesLabel = new System.Windows.Forms.Label();
            this.allegationLabelValue = new System.Windows.Forms.Label();
            this.allegationLabel = new System.Windows.Forms.Label();
            this.statusLabelValue = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.complaintIdLabelValue = new System.Windows.Forms.Label();
            this.complaintIdLabel = new System.Windows.Forms.Label();
            this.officerFullNameLabelValue = new System.Windows.Forms.Label();
            this.officerFullNameLabel = new System.Windows.Forms.Label();
            this.citizenGroupBox = new System.Windows.Forms.GroupBox();
            this.citizenPhoneLabelValue = new System.Windows.Forms.Label();
            this.citizenPhoneLabel = new System.Windows.Forms.Label();
            this.citizenAddressLabelValue = new System.Windows.Forms.Label();
            this.citizenAddressLabel = new System.Windows.Forms.Label();
            this.citizenNameLabelValue = new System.Windows.Forms.Label();
            this.citizenNameLabel = new System.Windows.Forms.Label();
            this.complaintGroupBox.SuspendLayout();
            this.citizenGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // complaintGroupBox
            // 
            this.complaintGroupBox.Controls.Add(this.seeNotesButton);
            this.complaintGroupBox.Controls.Add(this.disciplineComboBox);
            this.complaintGroupBox.Controls.Add(this.label1);
            this.complaintGroupBox.Controls.Add(this.dispositionLabelValue);
            this.complaintGroupBox.Controls.Add(this.disciplineLabel);
            this.complaintGroupBox.Controls.Add(this.saveButton);
            this.complaintGroupBox.Controls.Add(this.dateLabelValue);
            this.complaintGroupBox.Controls.Add(this.dateLabel);
            this.complaintGroupBox.Controls.Add(this.notesLabel);
            this.complaintGroupBox.Controls.Add(this.allegationLabelValue);
            this.complaintGroupBox.Controls.Add(this.allegationLabel);
            this.complaintGroupBox.Controls.Add(this.statusLabelValue);
            this.complaintGroupBox.Controls.Add(this.statusLabel);
            this.complaintGroupBox.Controls.Add(this.complaintIdLabelValue);
            this.complaintGroupBox.Controls.Add(this.complaintIdLabel);
            this.complaintGroupBox.Controls.Add(this.officerFullNameLabelValue);
            this.complaintGroupBox.Controls.Add(this.officerFullNameLabel);
            this.complaintGroupBox.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complaintGroupBox.Location = new System.Drawing.Point(17, 222);
            this.complaintGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.complaintGroupBox.Name = "complaintGroupBox";
            this.complaintGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.complaintGroupBox.Size = new System.Drawing.Size(1274, 382);
            this.complaintGroupBox.TabIndex = 3;
            this.complaintGroupBox.TabStop = false;
            this.complaintGroupBox.Text = "Complaint";
            // 
            // seeNotesButton
            // 
            this.seeNotesButton.Location = new System.Drawing.Point(155, 150);
            this.seeNotesButton.Name = "seeNotesButton";
            this.seeNotesButton.Size = new System.Drawing.Size(221, 55);
            this.seeNotesButton.TabIndex = 22;
            this.seeNotesButton.Text = "See Notes";
            this.seeNotesButton.UseVisualStyleBackColor = true;
            this.seeNotesButton.Click += new System.EventHandler(this.seeNotesButton_Click);
            // 
            // disciplineComboBox
            // 
            this.disciplineComboBox.FormattingEnabled = true;
            this.disciplineComboBox.Items.AddRange(new object[] {
            "None",
            "Letter of reprimand",
            "Suspension",
            "Demotion",
            "Termination"});
            this.disciplineComboBox.Location = new System.Drawing.Point(242, 312);
            this.disciplineComboBox.Name = "disciplineComboBox";
            this.disciplineComboBox.Size = new System.Drawing.Size(541, 39);
            this.disciplineComboBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 315);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Discipline:";
            // 
            // dispositionLabelValue
            // 
            this.dispositionLabelValue.AutoSize = true;
            this.dispositionLabelValue.Location = new System.Drawing.Point(215, 237);
            this.dispositionLabelValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dispositionLabelValue.Name = "dispositionLabelValue";
            this.dispositionLabelValue.Size = new System.Drawing.Size(35, 32);
            this.dispositionLabelValue.TabIndex = 19;
            this.dispositionLabelValue.Text = "--";
            // 
            // disciplineLabel
            // 
            this.disciplineLabel.AutoSize = true;
            this.disciplineLabel.Location = new System.Drawing.Point(20, 237);
            this.disciplineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.disciplineLabel.Name = "disciplineLabel";
            this.disciplineLabel.Size = new System.Drawing.Size(139, 32);
            this.disciplineLabel.TabIndex = 18;
            this.disciplineLabel.Text = "Disposition:";
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.Location = new System.Drawing.Point(1051, 299);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(172, 60);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dateLabelValue
            // 
            this.dateLabelValue.AutoSize = true;
            this.dateLabelValue.Location = new System.Drawing.Point(1054, 215);
            this.dateLabelValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabelValue.Name = "dateLabelValue";
            this.dateLabelValue.Size = new System.Drawing.Size(35, 32);
            this.dateLabelValue.TabIndex = 16;
            this.dateLabelValue.Text = "--";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(953, 215);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(70, 32);
            this.dateLabel.TabIndex = 15;
            this.dateLabel.Text = "Date:";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(20, 155);
            this.notesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(83, 32);
            this.notesLabel.TabIndex = 13;
            this.notesLabel.Text = "Notes:";
            // 
            // allegationLabelValue
            // 
            this.allegationLabelValue.AutoSize = true;
            this.allegationLabelValue.Location = new System.Drawing.Point(749, 95);
            this.allegationLabelValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.allegationLabelValue.Name = "allegationLabelValue";
            this.allegationLabelValue.Size = new System.Drawing.Size(35, 32);
            this.allegationLabelValue.TabIndex = 12;
            this.allegationLabelValue.Text = "--";
            // 
            // allegationLabel
            // 
            this.allegationLabel.AutoSize = true;
            this.allegationLabel.Location = new System.Drawing.Point(559, 95);
            this.allegationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.allegationLabel.Name = "allegationLabel";
            this.allegationLabel.Size = new System.Drawing.Size(128, 32);
            this.allegationLabel.TabIndex = 11;
            this.allegationLabel.Text = "Allegation:";
            // 
            // statusLabelValue
            // 
            this.statusLabelValue.AutoSize = true;
            this.statusLabelValue.Location = new System.Drawing.Point(689, 45);
            this.statusLabelValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabelValue.Name = "statusLabelValue";
            this.statusLabelValue.Size = new System.Drawing.Size(35, 32);
            this.statusLabelValue.TabIndex = 10;
            this.statusLabelValue.Text = "--";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(559, 45);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(84, 32);
            this.statusLabel.TabIndex = 9;
            this.statusLabel.Text = "Status:";
            // 
            // complaintIdLabelValue
            // 
            this.complaintIdLabelValue.AutoSize = true;
            this.complaintIdLabelValue.Location = new System.Drawing.Point(83, 45);
            this.complaintIdLabelValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.complaintIdLabelValue.Name = "complaintIdLabelValue";
            this.complaintIdLabelValue.Size = new System.Drawing.Size(35, 32);
            this.complaintIdLabelValue.TabIndex = 8;
            this.complaintIdLabelValue.Text = "--";
            // 
            // complaintIdLabel
            // 
            this.complaintIdLabel.AutoSize = true;
            this.complaintIdLabel.Location = new System.Drawing.Point(20, 45);
            this.complaintIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.complaintIdLabel.Name = "complaintIdLabel";
            this.complaintIdLabel.Size = new System.Drawing.Size(43, 32);
            this.complaintIdLabel.TabIndex = 7;
            this.complaintIdLabel.Text = "ID:";
            // 
            // officerFullNameLabelValue
            // 
            this.officerFullNameLabelValue.AutoSize = true;
            this.officerFullNameLabelValue.Location = new System.Drawing.Point(158, 95);
            this.officerFullNameLabelValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.officerFullNameLabelValue.Name = "officerFullNameLabelValue";
            this.officerFullNameLabelValue.Size = new System.Drawing.Size(35, 32);
            this.officerFullNameLabelValue.TabIndex = 6;
            this.officerFullNameLabelValue.Text = "--";
            // 
            // officerFullNameLabel
            // 
            this.officerFullNameLabel.AutoSize = true;
            this.officerFullNameLabel.Location = new System.Drawing.Point(20, 95);
            this.officerFullNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.officerFullNameLabel.Name = "officerFullNameLabel";
            this.officerFullNameLabel.Size = new System.Drawing.Size(92, 32);
            this.officerFullNameLabel.TabIndex = 6;
            this.officerFullNameLabel.Text = "Officer:";
            // 
            // citizenGroupBox
            // 
            this.citizenGroupBox.Controls.Add(this.citizenPhoneLabelValue);
            this.citizenGroupBox.Controls.Add(this.citizenPhoneLabel);
            this.citizenGroupBox.Controls.Add(this.citizenAddressLabelValue);
            this.citizenGroupBox.Controls.Add(this.citizenAddressLabel);
            this.citizenGroupBox.Controls.Add(this.citizenNameLabelValue);
            this.citizenGroupBox.Controls.Add(this.citizenNameLabel);
            this.citizenGroupBox.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citizenGroupBox.Location = new System.Drawing.Point(17, 16);
            this.citizenGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.citizenGroupBox.Name = "citizenGroupBox";
            this.citizenGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.citizenGroupBox.Size = new System.Drawing.Size(1274, 198);
            this.citizenGroupBox.TabIndex = 2;
            this.citizenGroupBox.TabStop = false;
            this.citizenGroupBox.Text = "Citizen";
            // 
            // citizenPhoneLabelValue
            // 
            this.citizenPhoneLabelValue.AutoSize = true;
            this.citizenPhoneLabelValue.Location = new System.Drawing.Point(992, 54);
            this.citizenPhoneLabelValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.citizenPhoneLabelValue.Name = "citizenPhoneLabelValue";
            this.citizenPhoneLabelValue.Size = new System.Drawing.Size(35, 32);
            this.citizenPhoneLabelValue.TabIndex = 5;
            this.citizenPhoneLabelValue.Text = "--";
            // 
            // citizenPhoneLabel
            // 
            this.citizenPhoneLabel.AutoSize = true;
            this.citizenPhoneLabel.Location = new System.Drawing.Point(721, 54);
            this.citizenPhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.citizenPhoneLabel.Name = "citizenPhoneLabel";
            this.citizenPhoneLabel.Size = new System.Drawing.Size(183, 32);
            this.citizenPhoneLabel.TabIndex = 4;
            this.citizenPhoneLabel.Text = "Phone Number:";
            // 
            // citizenAddressLabelValue
            // 
            this.citizenAddressLabelValue.AutoSize = true;
            this.citizenAddressLabelValue.Location = new System.Drawing.Point(174, 128);
            this.citizenAddressLabelValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.citizenAddressLabelValue.Name = "citizenAddressLabelValue";
            this.citizenAddressLabelValue.Size = new System.Drawing.Size(35, 32);
            this.citizenAddressLabelValue.TabIndex = 3;
            this.citizenAddressLabelValue.Text = "--";
            // 
            // citizenAddressLabel
            // 
            this.citizenAddressLabel.AutoSize = true;
            this.citizenAddressLabel.Location = new System.Drawing.Point(20, 128);
            this.citizenAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.citizenAddressLabel.Name = "citizenAddressLabel";
            this.citizenAddressLabel.Size = new System.Drawing.Size(104, 32);
            this.citizenAddressLabel.TabIndex = 2;
            this.citizenAddressLabel.Text = "Address:";
            // 
            // citizenNameLabelValue
            // 
            this.citizenNameLabelValue.AutoSize = true;
            this.citizenNameLabelValue.Location = new System.Drawing.Point(147, 54);
            this.citizenNameLabelValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.citizenNameLabelValue.Name = "citizenNameLabelValue";
            this.citizenNameLabelValue.Size = new System.Drawing.Size(35, 32);
            this.citizenNameLabelValue.TabIndex = 1;
            this.citizenNameLabelValue.Text = "--";
            // 
            // citizenNameLabel
            // 
            this.citizenNameLabel.AutoSize = true;
            this.citizenNameLabel.Location = new System.Drawing.Point(20, 54);
            this.citizenNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.citizenNameLabel.Name = "citizenNameLabel";
            this.citizenNameLabel.Size = new System.Drawing.Size(84, 32);
            this.citizenNameLabel.TabIndex = 0;
            this.citizenNameLabel.Text = "Name:";
            // 
            // ManageComplaintAsAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.complaintGroupBox);
            this.Controls.Add(this.citizenGroupBox);
            this.Name = "ManageComplaintAsAdministrator";
            this.Size = new System.Drawing.Size(1308, 620);
            this.complaintGroupBox.ResumeLayout(false);
            this.complaintGroupBox.PerformLayout();
            this.citizenGroupBox.ResumeLayout(false);
            this.citizenGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox complaintGroupBox;
        private System.Windows.Forms.Button seeNotesButton;
        private System.Windows.Forms.ComboBox disciplineComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dispositionLabelValue;
        private System.Windows.Forms.Label disciplineLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label dateLabelValue;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.Label allegationLabelValue;
        private System.Windows.Forms.Label allegationLabel;
        private System.Windows.Forms.Label statusLabelValue;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label complaintIdLabelValue;
        private System.Windows.Forms.Label complaintIdLabel;
        private System.Windows.Forms.Label officerFullNameLabelValue;
        private System.Windows.Forms.Label officerFullNameLabel;
        private System.Windows.Forms.GroupBox citizenGroupBox;
        private System.Windows.Forms.Label citizenPhoneLabelValue;
        private System.Windows.Forms.Label citizenPhoneLabel;
        private System.Windows.Forms.Label citizenAddressLabelValue;
        private System.Windows.Forms.Label citizenAddressLabel;
        private System.Windows.Forms.Label citizenNameLabelValue;
        private System.Windows.Forms.Label citizenNameLabel;
    }
}
