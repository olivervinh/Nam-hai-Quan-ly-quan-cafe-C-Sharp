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
    public partial class REPORT_BAN : Form
    {
        public REPORT_BAN()
        {
            InitializeComponent();
        }

        private void REPORT_BAN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanliquancoffee50DataSet.BanAn' table. You can move, or remove it, as needed.
            this.BanAnTableAdapter.Fill(this.quanliquancoffee50DataSet.BanAn);

            this.reportViewer1.RefreshReport();
        }
    }
}
