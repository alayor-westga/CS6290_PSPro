
namespace PSPro.View
{
    partial class ComplaintsSummaryDialog
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.psproDataSet = new PSPro.psproDataSet();
            this.complaintsStatisticsByYearReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.complaintsStatisticsByYearReportTableAdapter = new PSPro.psproDataSetTableAdapters.ComplaintsStatisticsByYearReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.psproDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaintsStatisticsByYearReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.complaintsStatisticsByYearReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PSPro.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1306, 384);
            this.reportViewer1.TabIndex = 0;
            // 
            // psproDataSet
            // 
            this.psproDataSet.DataSetName = "psproDataSet";
            this.psproDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // complaintsStatisticsByYearReportBindingSource
            // 
            this.complaintsStatisticsByYearReportBindingSource.DataMember = "ComplaintsStatisticsByYearReport";
            this.complaintsStatisticsByYearReportBindingSource.DataSource = this.psproDataSet;
            // 
            // complaintsStatisticsByYearReportTableAdapter
            // 
            this.complaintsStatisticsByYearReportTableAdapter.ClearBeforeFill = true;
            // 
            // ComplaintsSummaryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 384);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ComplaintsSummaryDialog";
            this.Text = "Complaints Summary";
            this.Load += new System.EventHandler(this.ComplaintsSummaryDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.psproDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaintsStatisticsByYearReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private psproDataSet psproDataSet;
        private System.Windows.Forms.BindingSource complaintsStatisticsByYearReportBindingSource;
        private psproDataSetTableAdapters.ComplaintsStatisticsByYearReportTableAdapter complaintsStatisticsByYearReportTableAdapter;
    }
}