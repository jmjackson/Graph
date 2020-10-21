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

namespace Mine.Views
{
    public partial class EditGeo : MetroFramework.Forms.MetroForm
    {
        readonly int gid;
        readonly GraphDbContext db = new GraphDbContext();
        public EditGeo(int id)
        {
            InitializeComponent();
            gid = id;
        }

        private void EditGeo_Load(object sender, EventArgs e)
        {
            var gm = db.GeoMembranes.Find(gid);
            TxtId.Text = gm.Id.ToString();
            TxtCarryOver.Text = gm.CarryOver.ToString();
            TxtDestructive.Text = gm.Destructive.ToString();
            TxtRemark.Text = gm.RemarksDestructive;
            TxtSeamLength.Text = gm.SeamLength.ToString();
            TxtSeamNo.Text = gm.SeamNo.ToString();
            TxtSeamTime.Text = gm.SeamTime;
            TxtSpeed.Text = gm.WedgeSpeed.ToString();
            TxtTemp.Text = gm.WedgeTemp.ToString();

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtId.Text);
            var gm = db.GeoMembranes.Find(id);
            gm.CarryOver = Convert.ToDouble(TxtCarryOver.Text);
            gm.Destructive = TxtDestructive.Text;
            gm.RemarksDestructive = TxtRemark.Text;
            gm.SeamLength = Convert.ToInt32(TxtSeamLength.Text);
            gm.SeamNo = TxtSeamNo.Text;
            gm.SeamTime = TxtSeamTime.Text;
            gm.WedgeSpeed = Convert.ToDouble(TxtSpeed.Text);
            gm.WedgeTemp = Convert.ToInt32(TxtTemp.Text);
            db.SaveChanges();
            this.Close();

        }
    }
}
