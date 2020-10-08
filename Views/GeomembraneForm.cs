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
    public partial class GeomembraneForm : MetroFramework.Forms.MetroForm
    {
        readonly GraphDbContext db = new GraphDbContext();
        int pdId = 0;
        public GeomembraneForm(int dev)
        {
            InitializeComponent();
            pdId = dev;
        }

        private void GeomembraneForm_Load(object sender, EventArgs e)
        {
            var pdev = db.ProjectDevs.Include(a => a.Project.Client).Include(a => a.Project).Where(a => a.Id == pdId).FirstOrDefault();
            MetroClient.Text = pdev.Project.Client.Name;
            MetroProject.Text = pdev.Project.PName;
            MetroProjectNo.Text = pdev.Project.ProjectNo;
            MetroContractor.Text = pdev.Project.Contractor;
            MetroSupplier.Text = pdev.Project.Supplier;
            MetroGeosynthetic.Text = pdev.Project.GeoSynthetic;

        }
    }
}
