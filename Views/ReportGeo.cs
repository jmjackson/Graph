using Mine.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Mine.Views
{
    public partial class ReportGeo : Form
    {
        readonly GraphDbContext db = new GraphDbContext();
        readonly int pdevId;
        public ReportGeo(int pdId)
        {
            pdevId = pdId;
            InitializeComponent();
        }

        private void ReportGeo_Load(object sender, EventArgs e)
        {
            ReportGeomembraneFill();

           
        }

        private void ReportGeomembraneFill()
        {
            var projectdev = db.ProjectDevs.Include(a => a.Project).Include(a=>a.Project.Client).Where(a => a.Id == pdevId).FirstOrDefault();
            var geomm = db.GeoMembranes.Where(a => a.ProjectDevId == pdevId).ToList(); ;

            ProjectBindingSource.DataSource = projectdev.Project;
            ClientBindingSource.DataSource = projectdev.Project.Client;
            ProjectDevBindingSource.DataSource = projectdev;
            GeoMembraneBindingSource.DataSource = geomm;
            this.ReportViewGeom.RefreshReport();

        }

    }
}
