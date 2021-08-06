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
    public partial class REPORT_THUCAN : Form
    {
        public REPORT_THUCAN()
        {
            InitializeComponent();
        }

        private void REPORT_THUCAN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanliquancoffee50DataSet.ThucAn' table. You can move, or remove it, as needed.
            this.ThucAnTableAdapter.Fill(this.quanliquancoffee50DataSet.ThucAn);

            this.reportViewer1.RefreshReport();
        }
    }
}
