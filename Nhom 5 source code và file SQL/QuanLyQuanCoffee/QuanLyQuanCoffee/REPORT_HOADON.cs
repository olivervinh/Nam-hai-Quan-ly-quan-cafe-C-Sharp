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
    public partial class REPORT_HOADON : Form
    {
        public REPORT_HOADON()
        {
            InitializeComponent();
        }

        private void REPORT_HOADONvaCTHD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanliquancoffee50DataSet.HoaDon' table. You can move, or remove it, as needed.
            this.HoaDonTableAdapter.Fill(this.quanliquancoffee50DataSet.HoaDon);

            this.reportViewer1.RefreshReport();
        }
    }
}
