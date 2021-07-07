
namespace PSPro.UserControls
{
    partial class ComplaintList
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
            this.components = new System.ComponentModel.Container();
            this.complaintsDataGridView = new System.Windows.Forms.DataGridView();
            this.complaintIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officerFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citizenFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allegationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complaintViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.officerComboBox = new System.Windows.Forms.ComboBox();
            this.officerComboBoxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.officerLabel = new System.Windows.Forms.Label();
            this.manageComplaintButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.complaintsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaintViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerComboBoxBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // complaintsDataGridView
            // 
            this.complaintsDataGridView.AllowUserToAddRows = false;
            this.complaintsDataGridView.AllowUserToDeleteRows = false;
            this.complaintsDataGridView.AutoGenerateColumns = false;
            this.complaintsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.complaintsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.complaintsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.complaintIDDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.officerFullNameDataGridViewTextBoxColumn,
            this.citizenFullNameDataGridViewTextBoxColumn,
            this.allegationDataGridViewTextBoxColumn});
            this.complaintsDataGridView.DataSource = this.complaintViewBindingSource;
            this.complaintsDataGridView.Location = new System.Drawing.Point(18, 124);
            this.complaintsDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.complaintsDataGridView.Name = "complaintsDataGridView";
            this.complaintsDataGridView.ReadOnly = true;
            this.complaintsDataGridView.RowHeadersWidth = 82;
            this.complaintsDataGridView.RowTemplate.Height = 33;
            this.complaintsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.complaintsDataGridView.Size = new System.Drawing.Size(1258, 480);
            this.complaintsDataGridView.TabIndex = 0;
            this.complaintsDataGridView.DoubleClick += new System.EventHandler(this.complaintsDataGridView_DoubleClick);
            // 
            // complaintIDDataGridViewTextBoxColumn
            // 
            this.complaintIDDataGridViewTextBoxColumn.DataPropertyName = "ComplaintID";
            this.complaintIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.complaintIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.complaintIDDataGridViewTextBoxColumn.Name = "complaintIDDataGridViewTextBoxColumn";
            this.complaintIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateCreatedDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            this.dateCreatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // officerFullNameDataGridViewTextBoxColumn
            // 
            this.officerFullNameDataGridViewTextBoxColumn.DataPropertyName = "OfficerFullName";
            this.officerFullNameDataGridViewTextBoxColumn.HeaderText = "Officer";
            this.officerFullNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.officerFullNameDataGridViewTextBoxColumn.Name = "officerFullNameDataGridViewTextBoxColumn";
            this.officerFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // citizenFullNameDataGridViewTextBoxColumn
            // 
            this.citizenFullNameDataGridViewTextBoxColumn.DataPropertyName = "CitizenFullName";
            this.citizenFullNameDataGridViewTextBoxColumn.HeaderText = "Citizen";
            this.citizenFullNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.citizenFullNameDataGridViewTextBoxColumn.Name = "citizenFullNameDataGridViewTextBoxColumn";
            this.citizenFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // allegationDataGridViewTextBoxColumn
            // 
            this.allegationDataGridViewTextBoxColumn.DataPropertyName = "Allegation";
            this.allegationDataGridViewTextBoxColumn.HeaderText = "Allegation";
            this.allegationDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.allegationDataGridViewTextBoxColumn.Name = "allegationDataGridViewTextBoxColumn";
            this.allegationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // complaintViewBindingSource
            // 
            this.complaintViewBindingSource.DataSource = typeof(PSPro.Model.ComplaintView);
            // 
            // officerComboBox
            // 
            this.officerComboBox.DataSource = this.officerComboBoxBindingSource;
            this.officerComboBox.DisplayMember = "DisplayName";
            this.officerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.officerComboBox.FormattingEnabled = true;
            this.officerComboBox.Location = new System.Drawing.Point(176, 49);
            this.officerComboBox.Name = "officerComboBox";
            this.officerComboBox.Size = new System.Drawing.Size(365, 33);
            this.officerComboBox.TabIndex = 1;
            this.officerComboBox.ValueMember = "PersonnelID";
            this.officerComboBox.SelectedIndexChanged += new System.EventHandler(this.officerComboBox_SelectedIndexChanged);
            // 
            // officerComboBoxBindingSource
            // 
            this.officerComboBoxBindingSource.DataSource = typeof(PSPro.Model.OfficerComboBox);
            // 
            // officerLabel
            // 
            this.officerLabel.AutoSize = true;
            this.officerLabel.Location = new System.Drawing.Point(45, 52);
            this.officerLabel.Name = "officerLabel";
            this.officerLabel.Size = new System.Drawing.Size(69, 25);
            this.officerLabel.TabIndex = 2;
            this.officerLabel.Text = "Officer";
            // 
            // manageComplaintButton
            // 
            this.manageComplaintButton.AutoSize = true;
            this.manageComplaintButton.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageComplaintButton.Location = new System.Drawing.Point(898, 628);
            this.manageComplaintButton.Name = "manageComplaintButton";
            this.manageComplaintButton.Size = new System.Drawing.Size(354, 60);
            this.manageComplaintButton.TabIndex = 4;
            this.manageComplaintButton.Text = "Manage Complaint";
            this.manageComplaintButton.UseVisualStyleBackColor = true;
            this.manageComplaintButton.Click += new System.EventHandler(this.manageComplaintButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(673, 52);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(62, 25);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "Status";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.Font = new System.Drawing.Font("Segoe UI", 10.875F);
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Open",
            "Closed"});
            this.statusComboBox.Location = new System.Drawing.Point(788, 49);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(307, 33);
            this.statusComboBox.TabIndex = 6;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // ComplaintList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.manageComplaintButton);
            this.Controls.Add(this.officerLabel);
            this.Controls.Add(this.officerComboBox);
            this.Controls.Add(this.complaintsDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ComplaintList";
            this.Size = new System.Drawing.Size(1308, 718);
            this.Load += new System.EventHandler(this.ComplaintList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.complaintsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaintViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerComboBoxBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView complaintsDataGridView;
        private System.Windows.Forms.ComboBox officerComboBox;
        private System.Windows.Forms.Label officerLabel;
        private System.Windows.Forms.BindingSource officerComboBoxBindingSource;
        private System.Windows.Forms.Button manageComplaintButton;
        private System.Windows.Forms.BindingSource complaintViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn complaintIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officerFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn citizenFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allegationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
    }
}
