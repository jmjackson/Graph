using Mine.DataContext;
using Mine.DataModel;
using Mine.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mine.Views
{
    public partial class DevelopmentForm : MetroFramework.Forms.MetroForm
    {
        int proDevId;
        
     
        readonly GraphDbContext db = new GraphDbContext();

        public DevelopmentForm(int pdId)
        {
            InitializeComponent();
            proDevId = pdId;
        }

        private void DevelopmentForm_Load(object sender, EventArgs e)
        {
            var pdev = db.ProjectDevs.Include(a => a.Project.Client).Include(a => a.Project).Where(a => a.Id == proDevId).FirstOrDefault();
            TxtClient.Text = pdev.Project.Client.Name;
            TxtContractor.Text = pdev.Project.Contractor;
            TxtGeoSynthetic.Text = pdev.Project.GeoSynthetic;
            TxtProject.Text = pdev.Project.PName;
            TxtProjectNo.Text = pdev.Project.ProjectNo;
            TxtSupplier.Text = pdev.Project.Supplier;
            PBPicture.Image = Image.FromFile(pdev.Project.Client.Image);
            TxtLocation.Text = pdev.Location;
            TxtInspector.Text = pdev.Inspector;

            //var prdev = db.ProjectDevs.Find(pdev);
            

            
        }

        private void BtnSaveDev_Click(object sender, EventArgs e)
        {
            

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var development = new Development()
            { 
                
                Area=Convert.ToDecimal(TxtArea.Text),
                Lenght=Convert.ToDecimal(TxtLenght.Text),
                PanelNo=Convert.ToInt32(TxtPanelNo.Text),
                ProjectDevId=proDevId,
                RollNo=Convert.ToDouble(TxtRollNo.Text),
                Remarks=TxtRemarks.Text,
                Thickness=TxtThickness.Text,
                Width=Convert.ToDecimal(TxtWidth.Text)
            };
            db.Developments.Add(development);
            db.SaveChanges();
            DevelopmentForm_Load(sender, e);

            
        }

        public void DGVFill()
        {
            var devdata = db.Developments.Where(a=>a.ProjectDevId==proDevId).ToList();
            if (devdata.Count>0)
            {
                DGVDev.AutoGenerateColumns = false;
                DGVDev.Columns["Id"].DataPropertyName = "Id";
                DGVDev.Columns["DeploymentDate"].DataPropertyName = "DeploymentDate";
                DGVDev.Columns["PanelNo"].DataPropertyName = "PanelNo";
                DGVDev.Columns["RollNo"].DataPropertyName = "RollNo";
                DGVDev.Columns["Length"].DataPropertyName = "Length";
                DGVDev.Columns["Width"].DataPropertyName = "Width";
                DGVDev.Columns["Thickness"].DataPropertyName = "Thickness";
                DGVDev.Columns["Area"].DataPropertyName = "Area";
                DGVDev.Columns["Remarks"].DataPropertyName = "Remarks";
                DGVDev.DataSource = devdata;
            }
        }
    }
}
