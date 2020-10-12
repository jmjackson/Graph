using MetroFramework;
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
        readonly int proDevId;
        
     
        readonly GraphDbContext db = new GraphDbContext();

        public DevelopmentForm(int pdId)
        {
            InitializeComponent();
            proDevId = pdId;
        }

        private void DevelopmentForm_Load(object sender, EventArgs e)
        {
            var pdev = db.ProjectDevs.Include(a => a.Project.Client).Include(a => a.Project).Where(a => a.Id == proDevId).FirstOrDefault();
            LblRClient.Text = pdev.Project.Client.Name;
            LblRContractor.Text = pdev.Project.Contractor;
            LblRGeosyntetic.Text = pdev.Project.GeoSynthetic;
            LblRProject.Text = pdev.Project.PName;
            LblRProjectNo.Text = pdev.Project.ProjectNo;
            LblRSupplier.Text = pdev.Project.Supplier;
            PBPicture.Image = Image.FromFile(pdev.Project.Client.Image);
            LblRLocation.Text = pdev.Location;
            LblRInspector.Text = pdev.Inspector;
            TxtDate.Value = pdev.DevTime;
            DGVFill();
            
        }



        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var development = new Development()
                {
                    DeploymentDate = Convert.ToDateTime(TxtDate.Text),
                    Area = Convert.ToDecimal(TxtArea.Text),
                    Lenght = Convert.ToDecimal(TxtLenght.Text),
                    PanelNo = Convert.ToInt32(TxtPanelNo.Text),
                    ProjectDevId = proDevId,
                    RollNo = Convert.ToDouble(TxtRollNo.Text),
                    Remarks = TxtRemarks.Text,
                    Thickness = TxtThickness.Text,
                    Width = Convert.ToDecimal(TxtWidth.Text)
                };

                db.Developments.Add(development);
                db.SaveChanges();
                DevelopmentForm_Load(sender, e);
                MetroMessageBox.Show(this,"Saved successfully","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                TxtArea.Text = string.Empty;
                TxtLenght.Text = string.Empty;
                TxtPanelNo.Text = string.Empty;
                TxtRollNo.Text = string.Empty;
                TxtWidth.Text = string.Empty;
                TxtThickness.Text = string.Empty;
                TxtArea.Text = string.Empty;
                TxtRemarks.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MetroMessageBox.Show(this, "Error in your record "+ex.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           

            
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

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int pdId = Convert.ToInt32(DGVDev.CurrentRow.Cells[0].Value);
            var dev = db.Developments.Find(pdId);
            TxtDate.Text = dev.DeploymentDate.ToString();
            TxtArea.Text = dev.Area.ToString();
            TxtLenght.Text = dev.Lenght.ToString();
            TxtPanelNo.Text = dev.PanelNo.ToString();
            TxtRollNo.Text = dev.RollNo.ToString();
            TxtRemarks.Text = dev.Remarks;
            TxtThickness.Text = dev.Thickness;
            TxtWidth.Text = dev.Width.ToString();
            TxtId.Text = Convert.ToString(dev.Id);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int pdId = Convert.ToInt32(DGVDev.CurrentRow.Cells[0].Value);
                    var dev = db.Developments.Find(pdId);
                    db.Developments.Remove(dev);
                    db.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Deleted Successfully","Info");
                    DevelopmentForm_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Error in your record " + ex.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(TxtId.Text);
                var dev = db.Developments.Find(id);
                dev.Area = Convert.ToDecimal(TxtArea.Text);
                dev.Lenght = Convert.ToDecimal(TxtLenght.Text);
                dev.PanelNo = Convert.ToInt32(TxtPanelNo.Text);
                dev.Remarks = TxtRemarks.Text;
                dev.RollNo = Convert.ToDouble(TxtRollNo.Text);
                dev.Thickness = TxtThickness.Text;
                dev.Width = Convert.ToDecimal(TxtWidth.Text);
                db.SaveChanges();
                DevelopmentForm_Load(sender, e);
                MetroMessageBox.Show(this, "Update successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtArea.Text = string.Empty;
                TxtLenght.Text = string.Empty;
                TxtPanelNo.Text = string.Empty;
                TxtRollNo.Text = string.Empty;
                TxtWidth.Text = string.Empty;
                TxtThickness.Text = string.Empty;
                TxtArea.Text = string.Empty;
                TxtRemarks.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Error in your record " + ex.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           

        }

        private void BtnPDF_Click(object sender, EventArgs e)
        {
            var pdev = db.ProjectDevs.Include(a => a.Project.Client).Include(a => a.Project).Where(a => a.Id == proDevId).FirstOrDefault();
            ReportDev rd = new ReportDev(pdev.Id);
            rd.Show();
        }
    }
}
