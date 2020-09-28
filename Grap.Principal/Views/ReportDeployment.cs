using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using Grap.Principal.Model;
using Grap.Principal.DataModel;
using System.Runtime.CompilerServices;
using Grap.Principal.ViewModels;

namespace Grap.Principal
{
    public partial class ReportDeployment : Form
    {
        readonly DataBaseContext db = new DataBaseContext();
        readonly int projectId = 0;
        public ReportDeployment(int id)
        {
            InitializeComponent();
            projectId = id;
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lbl_Searcher_Click(object sender, EventArgs e)
        {

        }

       

        private void ReportDeployment_Load(object sender, EventArgs e)
        {
            var pro = (from p in db.Projects
                           join c in db.Clients
                           on p.ClientId equals c.Id
                           where p.Id == projectId
                           select new ProjectViewModel{
                           Id=p.Id,
                           ProjectName=p.ProjectName,
                           Code=c.Code,
                           Contractor=p.Contractor,
                           Geosynthetic=p.Geosynthetic,
                           Image=c.Image,
                           LeachPad=p.LeachPad,
                           MachineNo=p.MachineNo,
                           Name=c.Name,
                           Operator=p.Operator,
                           ProjectNo=p.ProjectNo,
                           Supplier=p.Supplier
                           }).FirstOrDefault();


            LblInfoClient.Text = pro.Name;
            LblInfoProject.Text = pro.ProjectName;
            LblInfoProjectNo.Text = pro.ProjectNo;
            LblInfoSupplier.Text = pro.Supplier;

            PBLogoImage.Image = new Bitmap(pro.Image);


            //DGV data
            //var Dp = db.Deployments.Where(a => a.ProjectId = projectId).Tolist();

            //DGVDeployment.AutoGenerateColumns = false;

            //DGVDeployment.Columns["DeploymentDate"].DataPropertyName = "DeploymentDate";
            //DGVDeployment.Columns["PanelNo"].DataPropertyName = "PanelNo";
            //DGVDeployment.Columns["RollNo"].DataPropertyName = "RollNo";
            //DGVDeployment.Columns["Lenght"].DataPropertyName = "PanelLenght";
            //DGVDeployment.Columns["Width"].DataPropertyName = "Width";
            //DGVDeployment.Columns["Thickness"].DataPropertyName = "Thickness";
            //DGVDeployment.Columns["Area"].DataPropertyName = "Area";
            //DGVDeployment.Columns["Remarks"].DataPropertyName = "Remarks";

            //DGVDeployment.DataSource = Dp;
        }

      
    }
}
