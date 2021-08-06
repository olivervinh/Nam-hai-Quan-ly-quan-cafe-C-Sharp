namespace QuanLyQuanCoffee
{
    partial class taoBaoCaoReport
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
            this.btnREPORTnv = new DevComponents.DotNetBar.ButtonX();
            this.btnREPORTnvTheoChucVu = new DevComponents.DotNetBar.ButtonX();
            this.btnREPORTfood = new DevComponents.DotNetBar.ButtonX();
            this.btnREPORTban = new DevComponents.DotNetBar.ButtonX();
            this.comREPORTLoaiThucAn = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.SuspendLayout();
            // 
            // btnREPORTnv
            // 
            this.btnREPORTnv.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnREPORTnv.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnREPORTnv.Location = new System.Drawing.Point(187, 54);
            this.btnREPORTnv.Name = "btnREPORTnv";
            this.btnREPORTnv.Size = new System.Drawing.Size(350, 73);
            this.btnREPORTnv.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnREPORTnv.TabIndex = 0;
            this.btnREPORTnv.Text = "Danh sách nhân viên";
            this.btnREPORTnv.Click += new System.EventHandler(this.btnREPORTnv_Click);
            // 
            // btnREPORTnvTheoChucVu
            // 
            this.btnREPORTnvTheoChucVu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnREPORTnvTheoChucVu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnREPORTnvTheoChucVu.Location = new System.Drawing.Point(187, 133);
            this.btnREPORTnvTheoChucVu.Name = "btnREPORTnvTheoChucVu";
            this.btnREPORTnvTheoChucVu.Size = new System.Drawing.Size(350, 62);
            this.btnREPORTnvTheoChucVu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnREPORTnvTheoChucVu.TabIndex = 1;
            this.btnREPORTnvTheoChucVu.Text = "Danh sách nhân viên theo chức vụ";
            // 
            // btnREPORTfood
            // 
            this.btnREPORTfood.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnREPORTfood.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnREPORTfood.Location = new System.Drawing.Point(187, 201);
            this.btnREPORTfood.Name = "btnREPORTfood";
            this.btnREPORTfood.Size = new System.Drawing.Size(350, 64);
            this.btnREPORTfood.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnREPORTfood.TabIndex = 2;
            this.btnREPORTfood.Text = "Danh sách thức ăn";
            // 
            // btnREPORTban
            // 
            this.btnREPORTban.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnREPORTban.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnREPORTban.Location = new System.Drawing.Point(187, 271);
            this.btnREPORTban.Name = "btnREPORTban";
            this.btnREPORTban.Size = new System.Drawing.Size(350, 64);
            this.btnREPORTban.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnREPORTban.TabIndex = 3;
            this.btnREPORTban.Text = "Danh sách Bàn ăn";
            // 
            // comREPORTLoaiThucAn
            // 
            this.comREPORTLoaiThucAn.DisplayMember = "Text";
            this.comREPORTLoaiThucAn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comREPORTLoaiThucAn.FormattingEnabled = true;
            this.comREPORTLoaiThucAn.ItemHeight = 16;
            this.comREPORTLoaiThucAn.Location = new System.Drawing.Point(559, 220);
            this.comREPORTLoaiThucAn.Name = "comREPORTLoaiThucAn";
            this.comREPORTLoaiThucAn.Size = new System.Drawing.Size(166, 22);
            this.comREPORTLoaiThucAn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comREPORTLoaiThucAn.TabIndex = 4;
            // 
            // taoBaoCaoReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comREPORTLoaiThucAn);
            this.Controls.Add(this.btnREPORTban);
            this.Controls.Add(this.btnREPORTfood);
            this.Controls.Add(this.btnREPORTnvTheoChucVu);
            this.Controls.Add(this.btnREPORTnv);
            this.Name = "taoBaoCaoReport";
            this.Text = "taoBaoCaoReport";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnREPORTnv;
        private DevComponents.DotNetBar.ButtonX btnREPORTnvTheoChucVu;
        private DevComponents.DotNetBar.ButtonX btnREPORTfood;
        private DevComponents.DotNetBar.ButtonX btnREPORTban;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comREPORTLoaiThucAn;
    }
}