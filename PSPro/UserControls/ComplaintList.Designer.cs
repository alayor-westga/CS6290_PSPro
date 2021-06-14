
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
            this.complaintViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.complaintIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officerFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citizenFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.complaintsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaintViewBindingSource)).BeginInit();
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
            this.complaintsDataGridView.Location = new System.Drawing.Point(20, 116);
            this.complaintsDataGridView.Name = "complaintsDataGridView";
            this.complaintsDataGridView.ReadOnly = true;
            this.complaintsDataGridView.RowHeadersWidth = 82;
            this.complaintsDataGridView.RowTemplate.Height = 33;
            this.complaintsDataGridView.Size = new System.Drawing.Size(1268, 494);
            this.complaintsDataGridView.TabIndex = 0;
            // 
            // complaintViewBindingSource
            // 
            this.complaintViewBindingSource.DataSource = typeof(PSPro.Model.ComplaintView);
            // 
            // complaintIDDataGridViewTextBoxColumn
            // 
            this.complaintIDDataGridViewTextBoxColumn.DataPropertyName = "ComplaintID";
            this.complaintIDDataGridViewTextBoxColumn.HeaderText = "ComplaintID";
            this.complaintIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.complaintIDDataGridViewTextBoxColumn.Name = "complaintIDDataGridViewTextBoxColumn";
            this.complaintIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            this.dateCreatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // officerFullNameDataGridViewTextBoxColumn
            // 
            this.officerFullNameDataGridViewTextBoxColumn.DataPropertyName = "OfficerFullName";
            this.officerFullNameDataGridViewTextBoxColumn.HeaderText = "OfficerFullName";
            this.officerFullNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.officerFullNameDataGridViewTextBoxColumn.Name = "officerFullNameDataGridViewTextBoxColumn";
            this.officerFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // citizenFullNameDataGridViewTextBoxColumn
            // 
            this.citizenFullNameDataGridViewTextBoxColumn.DataPropertyName = "CitizenFullName";
            this.citizenFullNameDataGridViewTextBoxColumn.HeaderText = "CitizenFullName";
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
            // ComplaintList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.complaintsDataGridView);
            this.Name = "ComplaintList";
            this.Size = new System.Drawing.Size(1308, 718);
            ((System.ComponentModel.ISupportInitialize)(this.complaintsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaintViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView complaintsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn complaintIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officerFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn citizenFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource complaintViewBindingSource;
    }
}
