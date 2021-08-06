using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REPORT
{
    public partial class REPORT_Loaithucan : Form
    {
        public REPORT_Loaithucan()
        {
            InitializeComponent();
        }

        private void REPORT_Loaithucan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanliquancoffee50DataSet.LoaiThucAn' table. You can move, or remove it, as needed.
            this.LoaiThucAnTableAdapter.Fill(this.quanliquancoffee50DataSet.LoaiThucAn);

            this.reportViewer1.RefreshReport();
        }
    }
}
