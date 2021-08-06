namespace REPORT
{
    partial class REPORT_Loaithucan
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
            this.LoaiThucAnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanliquancoffee50DataSet = new REPORT.quanliquancoffee50DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LoaiThucAnTableAdapter = new REPORT.quanliquancoffee50DataSetTableAdapters.LoaiThucAnTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LoaiThucAnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanliquancoffee50DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // LoaiThucAnBindingSource
            // 
            this.LoaiThucAnBindingSource.DataMember = "LoaiThucAn";
            this.LoaiThucAnBindingSource.DataSource = this.quanliquancoffee50DataSet;
            // 
            // quanliquancoffee50DataSet
            // 
            this.quanliquancoffee50DataSet.DataSetName = "quanliquancoffee50DataSet";
            this.quanliquancoffee50DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Loaithucan";
            reportDataSource1.Value = this.LoaiThucAnBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "REPORT.REPORT_loaithucan.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1000, 468);
            this.reportViewer1.TabIndex = 0;
            // 
            // LoaiThucAnTableAdapter
            // 
            this.LoaiThucAnTableAdapter.ClearBeforeFill = true;
            // 
            // REPORT_Loaithucan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 468);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "REPORT_Loaithucan";
            this.Text = "REPORT_Loaithucan";
            this.Load += new System.EventHandler(this.REPORT_Loaithucan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoaiThucAnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanliquancoffee50DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LoaiThucAnBindingSource;
        private quanliquancoffee50DataSet quanliquancoffee50DataSet;
        private quanliquancoffee50DataSetTableAdapters.LoaiThucAnTableAdapter LoaiThucAnTableAdapter;
    }
}