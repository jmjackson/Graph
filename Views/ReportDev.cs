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
using Mine.ViewModelProject;

namespace Mine.Views
{
    public partial class ReportDev : Form
    {
        readonly GraphDbContext db = new GraphDbContext();
        readonly int PdevId;
        public ReportDev(int pdid)
        {
            PdevId = pdid;
            InitializeComponent();
        }

        private void ReportDev_Load(object sender, EventArgs e)
        {


            LoadDevelopmentReport();
        }

        private void LoadDevelopmentReport()
        {
            //ok cuando consultamos ala bd le asignamos los datos a el viewmodel
           

            var projectdev = db.ProjectDevs.Include(a=>a.Project).Include(a=>a.Project.Client).Where(a=>a.Id==PdevId).FirstOrDefault();
            var developmentlist = db.Developments.Where(a => a.ProjectDevId == projectdev.Id).ToList();
            
           ProjectBindingSource.DataSource = projectdev.Project;
            DevelopmentBindingSource.DataSource = developmentlist;
            ClientBindingSource.DataSource = projectdev.Project.Client;
            ReportDevView.LocalReport.EnableExternalImages = true;
            this.ReportDevView.RefreshReport();
        }

       
    }
}
