
namespace PSPro.View
{
    partial class SearchCitizenForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCitizenForm));
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.phoneFormatLabel = new System.Windows.Forms.Label();
            this.firstNameErrorLabel = new System.Windows.Forms.Label();
            this.phoneErrorLabel = new System.Windows.Forms.Label();
            this.emailErrorLabel = new System.Windows.Forms.Label();
            this.CancelActionButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.PhoneRadioButton = new System.Windows.Forms.RadioButton();
            this.EmailRadioButton = new System.Windows.Forms.RadioButton();
            this.FirstAndLastNameRadioButton = new System.Windows.Forms.RadioButton();
            this.citizenResultDataGridView = new System.Windows.Forms.DataGridView();
            this.citizenIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citizenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SelectCitizenButton = new System.Windows.Forms.Button();
            this.searchResultsLabel = new System.Windows.Forms.Label();
            this.noResultsLabel = new System.Windows.Forms.Label();
            this.searchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citizenResultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citizenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.phoneFormatLabel);
            this.searchGroupBox.Controls.Add(this.firstNameErrorLabel);
            this.searchGroupBox.Controls.Add(this.phoneErrorLabel);
            this.searchGroupBox.Controls.Add(this.emailErrorLabel);
            this.searchGroupBox.Controls.Add(this.CancelActionButton);
            this.searchGroupBox.Controls.Add(this.SearchButton);
            this.searchGroupBox.Controls.Add(this.phoneLabel);
            this.searchGroupBox.Controls.Add(this.phoneTextBox);
            this.searchGroupBox.Controls.Add(this.emailLabel);
            this.searchGroupBox.Controls.Add(this.emailTextBox);
            this.searchGroupBox.Controls.Add(this.lastNameLabel);
            this.searchGroupBox.Controls.Add(this.lastNameTextBox);
            this.searchGroupBox.Controls.Add(this.firstNameLabel);
            this.searchGroupBox.Controls.Add(this.firstNameTextBox);
            this.searchGroupBox.Controls.Add(this.PhoneRadioButton);
            this.searchGroupBox.Controls.Add(this.EmailRadioButton);
            this.searchGroupBox.Controls.Add(this.FirstAndLastNameRadioButton);
            this.searchGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchGroupBox.Location = new System.Drawing.Point(12, 12);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(924, 244);
            this.searchGroupBox.TabIndex = 0;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Select a Search Option";
            // 
            // phoneFormatLabel
            // 
            this.phoneFormatLabel.AutoSize = true;
            this.phoneFormatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneFormatLabel.Location = new System.Drawing.Point(708, 80);
            this.phoneFormatLabel.Name = "phoneFormatLabel";
            this.phoneFormatLabel.Size = new System.Drawing.Size(111, 20);
            this.phoneFormatLabel.TabIndex = 17;
            this.phoneFormatLabel.Text = "###-###-####";
            // 
            // firstNameErrorLabel
            // 
            this.firstNameErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.firstNameErrorLabel.Location = new System.Drawing.Point(32, 142);
            this.firstNameErrorLabel.Name = "firstNameErrorLabel";
            this.firstNameErrorLabel.Size = new System.Drawing.Size(276, 24);
            this.firstNameErrorLabel.TabIndex = 15;
            // 
            // phoneErrorLabel
            // 
            this.phoneErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.phoneErrorLabel.Location = new System.Drawing.Point(621, 142);
            this.phoneErrorLabel.Name = "phoneErrorLabel";
            this.phoneErrorLabel.Size = new System.Drawing.Size(303, 24);
            this.phoneErrorLabel.TabIndex = 14;
            // 
            // emailErrorLabel
            // 
            this.emailErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.emailErrorLabel.Location = new System.Drawing.Point(327, 142);
            this.emailErrorLabel.Name = "emailErrorLabel";
            this.emailErrorLabel.Size = new System.Drawing.Size(276, 24);
            this.emailErrorLabel.TabIndex = 13;
            // 
            // CancelActionButton
            // 
            this.CancelActionButton.Location = new System.Drawing.Point(624, 196);
            this.CancelActionButton.Name = "CancelActionButton";
            this.CancelActionButton.Size = new System.Drawing.Size(276, 34);
            this.CancelActionButton.TabIndex = 12;
            this.CancelActionButton.Text = "Cancel";
            this.CancelActionButton.UseVisualStyleBackColor = true;
            this.CancelActionButton.Click += new System.EventHandler(this.CancelActionButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(327, 196);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(276, 34);
            this.SearchButton.TabIndex = 11;
            this.SearchButton.Text = "Search for Citizen";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(619, 74);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(83, 29);
            this.phoneLabel.TabIndex = 10;
            this.phoneLabel.Text = "Phone";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(624, 106);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(276, 34);
            this.phoneTextBox.TabIndex = 9;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(322, 74);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(74, 29);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(327, 106);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(276, 34);
            this.emailTextBox.TabIndex = 7;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(27, 164);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(128, 29);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(32, 196);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(276, 34);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(27, 74);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(131, 29);
            this.firstNameLabel.TabIndex = 4;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(32, 106);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(276, 34);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // PhoneRadioButton
            // 
            this.PhoneRadioButton.AutoSize = true;
            this.PhoneRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneRadioButton.Location = new System.Drawing.Point(624, 38);
            this.PhoneRadioButton.Name = "PhoneRadioButton";
            this.PhoneRadioButton.Size = new System.Drawing.Size(137, 33);
            this.PhoneRadioButton.TabIndex = 2;
            this.PhoneRadioButton.TabStop = true;
            this.PhoneRadioButton.Text = "By Phone";
            this.PhoneRadioButton.UseVisualStyleBackColor = true;
            this.PhoneRadioButton.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckChanged);
            // 
            // EmailRadioButton
            // 
            this.EmailRadioButton.AutoSize = true;
            this.EmailRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailRadioButton.Location = new System.Drawing.Point(327, 38);
            this.EmailRadioButton.Name = "EmailRadioButton";
            this.EmailRadioButton.Size = new System.Drawing.Size(128, 33);
            this.EmailRadioButton.TabIndex = 1;
            this.EmailRadioButton.TabStop = true;
            this.EmailRadioButton.Text = "By Email";
            this.EmailRadioButton.UseVisualStyleBackColor = true;
            this.EmailRadioButton.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckChanged);
            // 
            // FirstAndLastNameRadioButton
            // 
            this.FirstAndLastNameRadioButton.AutoSize = true;
            this.FirstAndLastNameRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstAndLastNameRadioButton.Location = new System.Drawing.Point(32, 38);
            this.FirstAndLastNameRadioButton.Name = "FirstAndLastNameRadioButton";
            this.FirstAndLastNameRadioButton.Size = new System.Drawing.Size(132, 33);
            this.FirstAndLastNameRadioButton.TabIndex = 0;
            this.FirstAndLastNameRadioButton.TabStop = true;
            this.FirstAndLastNameRadioButton.Text = "By Name";
            this.FirstAndLastNameRadioButton.UseVisualStyleBackColor = true;
            this.FirstAndLastNameRadioButton.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckChanged);
            // 
            // citizenResultDataGridView
            // 
            this.citizenResultDataGridView.AllowUserToAddRows = false;
            this.citizenResultDataGridView.AllowUserToDeleteRows = false;
            this.citizenResultDataGridView.AutoGenerateColumns = false;
            this.citizenResultDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.citizenResultDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.citizenResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.citizenResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.citizenIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.citizenResultDataGridView.DataSource = this.citizenBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.citizenResultDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.citizenResultDataGridView.Location = new System.Drawing.Point(12, 291);
            this.citizenResultDataGridView.MultiSelect = false;
            this.citizenResultDataGridView.Name = "citizenResultDataGridView";
            this.citizenResultDataGridView.ReadOnly = true;
            this.citizenResultDataGridView.RowHeadersWidth = 51;
            this.citizenResultDataGridView.RowTemplate.Height = 24;
            this.citizenResultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.citizenResultDataGridView.Size = new System.Drawing.Size(924, 237);
            this.citizenResultDataGridView.TabIndex = 1;
            this.citizenResultDataGridView.TabStop = false;
            this.citizenResultDataGridView.DoubleClick += new System.EventHandler(this.SelectCitizenButton_Click);
            // 
            // citizenIDDataGridViewTextBoxColumn
            // 
            this.citizenIDDataGridViewTextBoxColumn.DataPropertyName = "CitizenID";
            this.citizenIDDataGridViewTextBoxColumn.FillWeight = 80F;
            this.citizenIDDataGridViewTextBoxColumn.HeaderText = "Citizen ID";
            this.citizenIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.citizenIDDataGridViewTextBoxColumn.Name = "citizenIDDataGridViewTextBoxColumn";
            this.citizenIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // citizenBindingSource
            // 
            this.citizenBindingSource.DataSource = typeof(PSPro.Model.Citizen);
            // 
            // SelectCitizenButton
            // 
            this.SelectCitizenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectCitizenButton.Location = new System.Drawing.Point(751, 534);
            this.SelectCitizenButton.Name = "SelectCitizenButton";
            this.SelectCitizenButton.Size = new System.Drawing.Size(185, 37);
            this.SelectCitizenButton.TabIndex = 2;
            this.SelectCitizenButton.Text = "Select Citizen";
            this.SelectCitizenButton.UseVisualStyleBackColor = true;
            this.SelectCitizenButton.Click += new System.EventHandler(this.SelectCitizenButton_Click);
            // 
            // searchResultsLabel
            // 
            this.searchResultsLabel.AutoSize = true;
            this.searchResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResultsLabel.Location = new System.Drawing.Point(7, 259);
            this.searchResultsLabel.Name = "searchResultsLabel";
            this.searchResultsLabel.Size = new System.Drawing.Size(254, 29);
            this.searchResultsLabel.TabIndex = 3;
            this.searchResultsLabel.Text = "Citizen Search Results";
            // 
            // noResultsLabel
            // 
            this.noResultsLabel.AutoSize = true;
            this.noResultsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noResultsLabel.ForeColor = System.Drawing.Color.Red;
            this.noResultsLabel.Location = new System.Drawing.Point(265, 264);
            this.noResultsLabel.Name = "noResultsLabel";
            this.noResultsLabel.Size = new System.Drawing.Size(0, 23);
            this.noResultsLabel.TabIndex = 4;
            // 
            // SearchCitizenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 583);
            this.Controls.Add(this.noResultsLabel);
            this.Controls.Add(this.searchResultsLabel);
            this.Controls.Add(this.SelectCitizenButton);
            this.Controls.Add(this.citizenResultDataGridView);
            this.Controls.Add(this.searchGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchCitizenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search for A Citizen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchCitizenForm_FormClosed);
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citizenResultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citizenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.RadioButton PhoneRadioButton;
        private System.Windows.Forms.RadioButton EmailRadioButton;
        private System.Windows.Forms.RadioButton FirstAndLastNameRadioButton;
        private System.Windows.Forms.DataGridView citizenResultDataGridView;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn citizenIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource citizenBindingSource;
        private System.Windows.Forms.Button CancelActionButton;
        private System.Windows.Forms.Button SelectCitizenButton;
        private System.Windows.Forms.Label searchResultsLabel;
        private System.Windows.Forms.Label emailErrorLabel;
        private System.Windows.Forms.Label firstNameErrorLabel;
        private System.Windows.Forms.Label phoneErrorLabel;
        private System.Windows.Forms.Label phoneFormatLabel;
        private System.Windows.Forms.Label noResultsLabel;
    }
}