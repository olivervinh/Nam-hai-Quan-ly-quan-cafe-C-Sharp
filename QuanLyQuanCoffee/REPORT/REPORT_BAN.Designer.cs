namespace REPORT
{
    partial class REPORT_BAN
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
            this.BanAnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanliquancoffee50DataSet = new REPORT.quanliquancoffee50DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BanAnTableAdapter = new REPORT.quanliquancoffee50DataSetTableAdapters.BanAnTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BanAnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanliquancoffee50DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BanAnBindingSource
            // 
            this.BanAnBindingSource.DataMember = "BanAn";
            this.BanAnBindingSource.DataSource = this.quanliquancoffee50DataSet;
            // 
            // quanliquancoffee50DataSet
            // 
            this.quanliquancoffee50DataSet.DataSetName = "quanliquancoffee50DataSet";
            this.quanliquancoffee50DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsBanAn";
            reportDataSource1.Value = this.BanAnBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "REPORT.REPORT_Ban.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1087, 529);
            this.reportViewer1.TabIndex = 0;
            // 
            // BanAnTableAdapter
            // 
            this.BanAnTableAdapter.ClearBeforeFill = true;
            // 
            // REPORT_BAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 529);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "REPORT_BAN";
            this.Text = "REPORT_BAN";
            this.Load += new System.EventHandler(this.REPORT_BAN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BanAnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanliquancoffee50DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BanAnBindingSource;
        private quanliquancoffee50DataSet quanliquancoffee50DataSet;
        private quanliquancoffee50DataSetTableAdapters.BanAnTableAdapter BanAnTableAdapter;
    }
}