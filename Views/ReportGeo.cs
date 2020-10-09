using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mine.Views
{
    public partial class ReportGeo : Form
    {
        public ReportGeo()
        {
            InitializeComponent();
        }

        private void ReportGeo_Load(object sender, EventArgs e)
        {
            this.reportViewer1.Visible = true;
            this.reportViewer1.RefreshReport();
        }
    }
}
