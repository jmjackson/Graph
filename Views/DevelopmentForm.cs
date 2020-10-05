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
        int projectId;
        int pdev = 0;
        ProjectDev dvep;
        readonly GraphDbContext db = new GraphDbContext();

        public DevelopmentForm(int pId)
        {
            InitializeComponent();
            projectId = pId;
        }

        private void DevelopmentForm_Load(object sender, EventArgs e)
        {
            var pro = db.Projects.Include(a => a.Client).Where(a=>a.Id==projectId).FirstOrDefault();
            TxtClient.Text = pro.Client.Name;
            TxtContractor.Text = pro.Contractor;
            TxtGeoSynthetic.Text = pro.GeoSynthetic;
            TxtProject.Text = pro.PName;
            TxtProjectNo.Text = pro.ProjectNo;
            TxtSupplier.Text = pro.Supplier;
            PBPicture.Image = Image.FromFile(pro.Client.Image);

            var prdev = db.ProjectDevs.Find(pdev);
            if (prdev!=null)
            {
                PanelAdd.Enabled = true;
                dvep = prdev;
                DGVFill();
            }
            else
            {
               PanelAdd.Enabled= false;
            }

            
        }

        private void BtnSaveDev_Click(object sender, EventArgs e)
        {
            var pd = new ProjectDev()
            {
                ProjectId = projectId,
                Inspector = TxtInspector.Text,
                Location=TxtLocation.Text,
                DevTime=Convert.ToDateTime(TxtDate.Text)
            };

            db.ProjectDevs.Add(pd);
            db.SaveChanges();
            pdev = pd.Id;
            this.DevelopmentForm_Load(sender, e);

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var development = new Development()
            { 
                DeploymentDate=dvep.DevTime,
                Area=Convert.ToDecimal(TxtArea.Text),
                Lenght=Convert.ToDecimal(TxtLenght.Text),
                PanelNo=Convert.ToInt32(TxtPanelNo.Text),
                ProjectDevId=dvep.Id,
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
            var devdata = db.Developments.Where(a=>a.ProjectDevId==dvep.Id).ToList();
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
