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
    public partial class AddGeom : MetroFramework.Forms.MetroForm
    {
        readonly int pdId;
        readonly GraphDbContext db = new GraphDbContext();
        public AddGeom(int id)
        {
            InitializeComponent();
            pdId = id;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var dev = db.ProjectDevs.Find(pdId);
            var geo = new GeoMembrane()
            {
                ProjectDevId = dev.Id,
                RemarksDestructive = TxtRemarks.Text,
                CarryOver=Convert.ToDouble(TxtCarryOver.Text),
                Destructive=TxtDestructive.Text,
                SeamingDate=dev.DevTime,
                SeamLength=Convert.ToDouble(TxtSeamLength.Text),
                SeamNo=TxtSeamNo.Text,
                SeamTime=TxtSeamTime.Text,
                WedgeSpeed=Convert.ToDouble(TxtSpeed.Text),
                WedgeTemp=Convert.ToInt32(TxtTemp.Text),
            };
            db.GeoMembranes.Add(geo);
            db.SaveChanges();
            this.Close();
        }
    }
}
