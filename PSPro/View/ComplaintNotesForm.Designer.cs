
namespace PSPro.View
{
    partial class ComplaintNotesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComplaintNotesForm));
            this.notesTextBox = new System.Windows.Forms.RichTextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.addNotesLabel = new System.Windows.Forms.Label();
            this.addNotesTextBox = new System.Windows.Forms.RichTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(41, 72);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.ReadOnly = true;
            this.notesTextBox.Size = new System.Drawing.Size(1296, 342);
            this.notesTextBox.TabIndex = 0;
            this.notesTextBox.Text = "";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(32, 19);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(128, 50);
            this.notesLabel.TabIndex = 1;
            this.notesLabel.Text = "Notes:";
            // 
            // addNotesLabel
            // 
            this.addNotesLabel.AutoSize = true;
            this.addNotesLabel.Location = new System.Drawing.Point(32, 436);
            this.addNotesLabel.Name = "addNotesLabel";
            this.addNotesLabel.Size = new System.Drawing.Size(206, 50);
            this.addNotesLabel.TabIndex = 2;
            this.addNotesLabel.Text = "Add Notes:";
            // 
            // addNotesTextBox
            // 
            this.addNotesTextBox.Location = new System.Drawing.Point(41, 489);
            this.addNotesTextBox.Name = "addNotesTextBox";
            this.addNotesTextBox.Size = new System.Drawing.Size(1296, 132);
            this.addNotesTextBox.TabIndex = 3;
            this.addNotesTextBox.Text = "";
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.Location = new System.Drawing.Point(1153, 651);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(164, 60);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Location = new System.Drawing.Point(948, 651);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(164, 60);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ComplaintNotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 50F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 723);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addNotesTextBox);
            this.Controls.Add(this.addNotesLabel);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComplaintNotesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complaint Notes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ComplaintNotesForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox notesTextBox;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.Label addNotesLabel;
        private System.Windows.Forms.RichTextBox addNotesTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button closeButton;
    }
}