
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
            this.complaintsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.complaintsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // complaintsDataGridView
            // 
            this.complaintsDataGridView.AllowUserToAddRows = false;
            this.complaintsDataGridView.AllowUserToDeleteRows = false;
            this.complaintsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.complaintsDataGridView.Location = new System.Drawing.Point(20, 116);
            this.complaintsDataGridView.Name = "complaintsDataGridView";
            this.complaintsDataGridView.ReadOnly = true;
            this.complaintsDataGridView.RowHeadersWidth = 82;
            this.complaintsDataGridView.RowTemplate.Height = 33;
            this.complaintsDataGridView.Size = new System.Drawing.Size(1268, 494);
            this.complaintsDataGridView.TabIndex = 0;
            // 
            // ComplaintList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.complaintsDataGridView);
            this.Name = "ComplaintList";
            this.Size = new System.Drawing.Size(1308, 718);
            ((System.ComponentModel.ISupportInitialize)(this.complaintsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView complaintsDataGridView;
    }
}
