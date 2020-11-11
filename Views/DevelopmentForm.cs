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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mine.Views
{
    public partial class DevelopmentForm : Form
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
            LblClient.Text = "Client : "+ pdev.Project.Client.Name;
            LblContractor.Text = "Contractor : "+pdev.Project.Contractor;
            LblGeoSynthetic.Text ="Geosynthetic : "+ pdev.Project.GeoSynthetic;
            LblProject.Text = "Project : "+ pdev.Project.PName;
            LblProjectNo.Text = "Project No : "+ pdev.Project.ProjectNo;
            LblSupplier.Text = "Supplier : "+ pdev.Project.Supplier;
            
            if (pdev.Project.Client.ImgCl != null)
            {
                var bimg = Convert.ToBase64String(pdev.Project.Client.ImgCl);
                //var img = Image.FromStream();
                PBPicture.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(bimg)));
            }

            

            DGVFill();

        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var pdev = db.ProjectDevs.Include(a => a.Project.Client).Include(a => a.Project).Where(a => a.Id == proDevId).FirstOrDefault();
                Development dev = new Development();
                dev.DeploymentDate = Convert.ToDateTime(pdev.DevTime.ToShortDateString());
                dev.PanelNo = Convert.ToInt32(DGVDev.CurrentRow.Cells["PanelNo"].Value);
                dev.RollNo = Convert.ToInt32(DGVDev.CurrentRow.Cells["RollNo"].Value);
                dev.Lenght = Convert.ToInt32(DGVDev.CurrentRow.Cells["Lenght"].Value);
                dev.Width = Convert.ToDecimal(DGVDev.CurrentRow.Cells["Width"].Value);
                if (DGVDev.CurrentRow.Cells["Thickness"].Value!=null)
                {
                    dev.Thickness = DGVDev.CurrentRow.Cells["Thickness"].Value.ToString();
                }
                else
                {
                    dev.Thickness = " ";
                }
                
                dev.Area = Convert.ToInt32(DGVDev.CurrentRow.Cells["Lenght"].Value)* Convert.ToDecimal(DGVDev.CurrentRow.Cells["Width"].Value);
                if (DGVDev.CurrentRow.Cells["Remarks"].Value!=null)
                {
                    dev.Remarks = DGVDev.CurrentRow.Cells["Remarks"].Value.ToString();
                }
                else
                {
                    dev.Remarks = " ";
                }
                dev.ProjectDevId = pdev.Id;
                db.Developments.Add(dev);
                db.SaveChanges();

                DevelopmentForm_Load(sender, e);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Error in your record " + ex.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void DGVFill()
        {
            var devdata = db.Developments.Where(a => a.ProjectDevId == proDevId).ToList();
            if (devdata.Count > 0 || DGVDev.CurrentRow != null)
            {
                developmentBindingSource.DataSource = devdata;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int pdId = Convert.ToInt32(DGVDev.CurrentRow.Cells[0].Value);
            var dev = db.Developments.Find(pdId);
            dev.PanelNo = Convert.ToInt32(DGVDev.CurrentRow.Cells["PanelNo"].Value);
            dev.RollNo = Convert.ToInt32(DGVDev.CurrentRow.Cells["RollNo"].Value);
            dev.Lenght = Convert.ToInt32(DGVDev.CurrentRow.Cells["Lenght"].Value);
            dev.Width = Convert.ToDecimal(DGVDev.CurrentRow.Cells["Width"].Value);
            if (DGVDev.CurrentRow.Cells["Thickness"].Value.ToString() == "")
            {
                dev.Thickness = " ";
            }
            else
            {
                dev.Thickness = DGVDev.CurrentRow.Cells["Thickness"].Value.ToString();
            }
            dev.Area = Convert.ToInt32(DGVDev.CurrentRow.Cells["Lenght"].Value)* Convert.ToDecimal(DGVDev.CurrentRow.Cells["Width"].Value);
            if (DGVDev.CurrentRow.Cells["Remarks"].Value.ToString() == "")
            {
                dev.Remarks = " ";
            }
            else
            {
                dev.Remarks = DGVDev.CurrentRow.Cells["Remarks"].Value.ToString();
            }
            db.SaveChanges();
            DevelopmentForm_Load(sender, e);
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
                    MetroFramework.MetroMessageBox.Show(this, "Deleted Successfully", "Info");
                    DevelopmentForm_Load(sender, e);
                    DGVDev.Refresh();
                }
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeamingButton_Click(object sender, EventArgs e)
        {
            GeomembraneForm geo = new GeomembraneForm(proDevId);
            geo.Show();
            this.Close();

        }

        private void BtnDrawing_Click(object sender, EventArgs e)
        {
            Dibujo d = new Dibujo(proDevId);
            d.Show();
            this.Close();
        }

        
    }
}
