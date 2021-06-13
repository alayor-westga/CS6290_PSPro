
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
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.PhoneRadioButton = new System.Windows.Forms.RadioButton();
            this.EmailRadioButton = new System.Windows.Forms.RadioButton();
            this.FirstAndLastNameRadioButton = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.searchResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.SelectCitizenButton = new System.Windows.Forms.Button();
            this.citizenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citizenIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.searchResultsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citizenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchGroupBox
            // 
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
            this.searchGroupBox.Size = new System.Drawing.Size(924, 232);
            this.searchGroupBox.TabIndex = 0;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Select a Search Option";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(27, 152);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(128, 29);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(32, 184);
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.citizenIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.citizenBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(912, 223);
            this.dataGridView1.TabIndex = 1;
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
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(619, 74);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(176, 29);
            this.phoneLabel.TabIndex = 10;
            this.phoneLabel.Text = "Phone Number";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(624, 106);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(276, 34);
            this.phoneTextBox.TabIndex = 9;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(327, 184);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(276, 34);
            this.SearchButton.TabIndex = 11;
            this.SearchButton.Text = "Search for Citizen";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // searchResultsGroupBox
            // 
            this.searchResultsGroupBox.Controls.Add(this.SelectCitizenButton);
            this.searchResultsGroupBox.Controls.Add(this.dataGridView1);
            this.searchResultsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResultsGroupBox.Location = new System.Drawing.Point(12, 250);
            this.searchResultsGroupBox.Name = "searchResultsGroupBox";
            this.searchResultsGroupBox.Size = new System.Drawing.Size(924, 305);
            this.searchResultsGroupBox.TabIndex = 2;
            this.searchResultsGroupBox.TabStop = false;
            this.searchResultsGroupBox.Text = "Citizen Search Results";
            // 
            // SelectCitizenButton
            // 
            this.SelectCitizenButton.Location = new System.Drawing.Point(733, 262);
            this.SelectCitizenButton.Name = "SelectCitizenButton";
            this.SelectCitizenButton.Size = new System.Drawing.Size(185, 37);
            this.SelectCitizenButton.TabIndex = 2;
            this.SelectCitizenButton.Text = "Select Citizen";
            this.SelectCitizenButton.UseVisualStyleBackColor = true;
            // 
            // citizenBindingSource
            // 
            this.citizenBindingSource.DataSource = typeof(PSPro.Model.Citizen);
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
            // SearchCitizenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 567);
            this.Controls.Add(this.searchResultsGroupBox);
            this.Controls.Add(this.searchGroupBox);
            this.Name = "SearchCitizenForm";
            this.Text = "Search for A Citizen";
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.searchResultsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.citizenBindingSource)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.GroupBox searchResultsGroupBox;
        private System.Windows.Forms.Button SelectCitizenButton;
    }
}