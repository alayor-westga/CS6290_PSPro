
namespace PSPro
{
    partial class TestReportForm
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
            this.ComplaintsStatisticsByYearReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ComplaintsStatisticsByYearReportTableAdapter = new PSPro.psproDataSetTableAdapters.ComplaintsStatisticsByYearReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.psproDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComplaintsStatisticsByYearReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ComplaintsStatisticsByYearReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PSPro.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(43, 85);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1129, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // psproDataSet
            // 
            this.psproDataSet.DataSetName = "psproDataSet";
            this.psproDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ComplaintsStatisticsByYearReportBindingSource
            // 
            this.ComplaintsStatisticsByYearReportBindingSource.DataMember = "ComplaintsStatisticsByYearReport";
            this.ComplaintsStatisticsByYearReportBindingSource.DataSource = this.psproDataSet;
            // 
            // ComplaintsStatisticsByYearReportTableAdapter
            // 
            this.ComplaintsStatisticsByYearReportTableAdapter.ClearBeforeFill = true;
            // 
            // TestReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TestReportForm";
            this.Text = "TestReportForm";
            this.Load += new System.EventHandler(this.TestReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.psproDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComplaintsStatisticsByYearReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ComplaintsStatisticsByYearReportBindingSource;
        private psproDataSet psproDataSet;
        private psproDataSetTableAdapters.ComplaintsStatisticsByYearReportTableAdapter ComplaintsStatisticsByYearReportTableAdapter;
    }
}