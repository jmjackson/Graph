using Mine.DataContext;
using Mine.DataModel;
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
    public partial class AddDeployment : MetroFramework.Forms.MetroForm
    {
        readonly GraphDbContext db = new GraphDbContext();
        int pdId;
        public AddDeployment( int devId)
        {
            InitializeComponent();
            pdId = devId;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var dev = db.ProjectDevs.Find(pdId);
                var deployment = new Development()
                {
                    Area=Convert.ToDecimal(TxtArea.Text),
                    DeploymentDate=dev.DevTime,
                    Lenght=Convert.ToInt32(TxtLength.Text),
                    PanelNo=Convert.ToInt32(TxtPanel.Text),
                    ProjectDevId=dev.Id,
                    Remarks=TxtRemarks.Text,
                    RollNo=Convert.ToInt32(TxtRollNo.Text),
                    Thickness=TxtThickness.Text,
                    Width=Convert.ToDecimal(TxtWidth.Text)

                };
                db.Developments.Add(deployment);
                db.SaveChanges();
                this.Close();
            }
            catch (Exception)
            {

                
            }
        }
    }
}
