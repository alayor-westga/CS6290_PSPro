
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
            this.dispositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complaintViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.officerComboBox = new System.Windows.Forms.ComboBox();
            this.officerComboBoxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.officerLabel = new System.Windows.Forms.Label();
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
            this.dispositionDataGridViewTextBoxColumn});
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
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "Date Created";
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
            // dispositionDataGridViewTextBoxColumn
            // 
            this.dispositionDataGridViewTextBoxColumn.DataPropertyName = "Disposition";
            this.dispositionDataGridViewTextBoxColumn.HeaderText = "Disposition";
            this.dispositionDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.dispositionDataGridViewTextBoxColumn.Name = "dispositionDataGridViewTextBoxColumn";
            this.dispositionDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.officerComboBox.Size = new System.Drawing.Size(365, 48);
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
            this.officerLabel.Size = new System.Drawing.Size(102, 40);
            this.officerLabel.TabIndex = 2;
            this.officerLabel.Text = "Officer";
            // 
            // ComplaintList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.BindingSource complaintViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn complaintIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officerFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn citizenFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox officerComboBox;
        private System.Windows.Forms.Label officerLabel;
        private System.Windows.Forms.BindingSource officerComboBoxBindingSource;
    }
}
