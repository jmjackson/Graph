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
    public partial class EditDeployment : MetroFramework.Forms.MetroForm
    {
        readonly int dId;
        readonly GraphDbContext db = new GraphDbContext();
        public EditDeployment(int id)
        {
            InitializeComponent();
            dId = id;
        }

        private void EditDeployment_Load(object sender, EventArgs e)
        {
            var dev = db.Developments.Find(dId);
            TxtArea.Text = dev.Area.ToString();
            TxtId.Text = dev.Id.ToString();
            TxtLength.Text = dev.Lenght.ToString();
            TxtPanel.Text = dev.PanelNo.ToString();
            TxtRemarks.Text = dev.Remarks;
            TxtRoll.Text = dev.RollNo.ToString();
            TxtThickness.Text = dev.Thickness.ToString();
            TxtWidth.Text = dev.Width.ToString();
            

            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(TxtId.Text);
            var dev = db.Developments.Find(id);
            dev.Area = Convert.ToDecimal(TxtArea.Text);
            dev.Lenght = Convert.ToInt32(TxtLength.Text);
            dev.PanelNo = Convert.ToInt32(TxtPanel.Text);
            dev.Remarks = TxtRemarks.Text;
            dev.RollNo = Convert.ToInt32(TxtRoll.Text);
            dev.Thickness = TxtThickness.Text;
            dev.Width = Convert.ToDecimal(TxtWidth.Text);
            db.SaveChanges();
            this.Close();
        }
    }
}
