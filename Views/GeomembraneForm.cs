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
using Mine.DataModel;
using MetroFramework;
using System.IO;
using Mine.Modal;

namespace Mine.Views
{
    public partial class GeomembraneForm : Form
    {
        readonly GraphDbContext db = new GraphDbContext();
        readonly int pdId = 0;
        public GeomembraneForm(int dev)
        {
            InitializeComponent();
            pdId = dev;
        }

        private void GeomembraneForm_Load(object sender, EventArgs e)
        {
            var pdev = db.ProjectDevs.Include(a => a.Project.Client).Include(a => a.Project).Where(a => a.Id == pdId).FirstOrDefault();
            MetroClient.Text = pdev.Project.Client.Name;
            MetroProject.Text = pdev.Project.PName;
            MetroProjectNo.Text = pdev.Project.ProjectNo;
            MetroContractor.Text = pdev.Project.Contractor;
            MetroSupplier.Text = pdev.Project.Supplier;
            MetroGeosynthetic.Text = pdev.Project.GeoSynthetic;
            MetroMachineNo.Text = pdev.MachineNo;
            MetroOperator.Text = pdev.Operator;
           

            if (pdev.Project.Client.ImgCl != null)
            {
                var bimg = Convert.ToBase64String(pdev.Project.Client.ImgCl);
                //var img = Image.FromStream();
                PbLogo.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(bimg)));
            }

            DGVFill();
        }

        private void DGVFill()
        {
            var gms = db.GeoMembranes.Where(a=>a.ProjectDevId==pdId).ToList();
            if (gms.Count>0)
            {
                geoMembraneBindingSource.DataSource= gms;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVGeo.CurrentRow.Cells["SeamNo"].Value!=null)
                {
                    var pdev = db.ProjectDevs.Include(a => a.Project.Client).Include(a => a.Project).Where(a => a.Id == pdId).FirstOrDefault();

                    var geolist = db.GeoMembranes.Where(a => a.ProjectDevId == pdev.Id).ToList();
                    double count = 0;
                    double seamtotal = 0;
                    foreach (var item in geolist)
                    {
                        count += item.SeamLength;
                    }

                    seamtotal = count;
                    var geo = new GeoMembrane();
                    geo.SeamingDate = Convert.ToDateTime(pdev.DevTime.ToShortDateString());
                    if (DGVGeo.CurrentRow.Cells["SeamNo"].Value != null)
                    {
                        geo.SeamNo = DGVGeo.CurrentRow.Cells["SeamNo"].Value.ToString();
                    }
                    else
                    {
                        geo.SeamNo = " ";
                    }
                    if (DGVGeo.CurrentRow.Cells["SeamTime"].Value != null)
                    {
                        geo.SeamTime = DGVGeo.CurrentRow.Cells["SeamTime"].Value.ToString();
                    }
                    else
                    {
                        geo.SeamTime = " ";
                    }

                    geo.WedgeTemp = Convert.ToInt32(DGVGeo.CurrentRow.Cells["WedgeTemp"].Value);
                    geo.WedgeSpeed = Convert.ToDouble(DGVGeo.CurrentRow.Cells["WedgeSpeed"].Value);
                    geo.SeamLength = Convert.ToDouble(DGVGeo.CurrentRow.Cells["SeamLength"].Value);
                    geo.CarryOver = seamtotal + Convert.ToDouble(DGVGeo.CurrentRow.Cells["SeamLength"].Value);

                    if (DGVGeo.CurrentRow.Cells["Destructive"].Value != null)
                    {
                        geo.Destructive = DGVGeo.CurrentRow.Cells["Destructive"].Value.ToString();
                    }
                    else
                    {
                        geo.Destructive = " ";
                    }

                    if (DGVGeo.CurrentRow.Cells["RemarksDestructive"].Value != null)
                    {
                        geo.RemarksDestructive = DGVGeo.CurrentRow.Cells["RemarksDestructive"].Value.ToString();
                    }
                    else
                    {
                        geo.RemarksDestructive = " ";
                    }


                    geo.ProjectDevId = pdev.Id;
                    db.GeoMembranes.Add(geo);
                    db.SaveChanges();
                    GeomembraneForm_Load(sender, e);
                }
                else
                {
                    MetroMessageBox.Show(this, "Ingrese datos a la linea" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

             

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Error"+ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int gId = Convert.ToInt32(DGVGeo.CurrentRow.Cells[0].Value);
            var geo = db.GeoMembranes.Find(gId);
            var geolist = db.GeoMembranes.Where(a => a.ProjectDevId == pdId).ToList();
            double count = 0;
            double seamtotal = 0;
            foreach (var item in geolist)
            {
                count += item.SeamLength;
            }

            seamtotal = count-geolist.Last().SeamLength;
            if (DGVGeo.CurrentRow.Cells["SeamNo"].Value != null)
            {
                geo.SeamNo = DGVGeo.CurrentRow.Cells["SeamNo"].Value.ToString();
            }
            else
            {
                geo.SeamNo = " ";
            }
            if (DGVGeo.CurrentRow.Cells["SeamTime"].Value != null)
            {
                geo.SeamTime = DGVGeo.CurrentRow.Cells["SeamTime"].Value.ToString();
            }
            else
            {
                geo.SeamTime = " ";
            }

            geo.WedgeTemp = Convert.ToInt32(DGVGeo.CurrentRow.Cells["WedgeTemp"].Value);
            geo.WedgeSpeed = Convert.ToDouble(DGVGeo.CurrentRow.Cells["WedgeSpeed"].Value);
            geo.SeamLength = Convert.ToDouble(DGVGeo.CurrentRow.Cells["SeamLength"].Value);
            geo.CarryOver = seamtotal + Convert.ToDouble(DGVGeo.CurrentRow.Cells["SeamLength"].Value);

            if (DGVGeo.CurrentRow.Cells["Destructive"].Value != null)
            {
                geo.Destructive = DGVGeo.CurrentRow.Cells["Destructive"].Value.ToString();
            }
            else
            {
                geo.Destructive = " ";
            }

            if (DGVGeo.CurrentRow.Cells["RemarksDestructive"].Value != null)
            {
                geo.RemarksDestructive = DGVGeo.CurrentRow.Cells["RemarksDestructive"].Value.ToString();
            }
            else
            {
                geo.RemarksDestructive = " ";
            }
            db.SaveChanges();
            GeomembraneForm_Load(sender, e);


        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int pdId = Convert.ToInt32(DGVGeo.CurrentRow.Cells[0].Value);
                var geo = db.GeoMembranes.Find(pdId);
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.GeoMembranes.Remove(geo);
                    db.SaveChanges();
                    GeomembraneForm_Load(sender, e);
                }
               
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Error in your record " + ex.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
           
            
        }

        private void BtnPdf_Click(object sender, EventArgs e)
        {
            ReportGeo rg = new ReportGeo(pdId);
            rg.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeploymentBtn_Click(object sender, EventArgs e)
        {
            DevelopmentForm df = new DevelopmentForm(pdId);
            df.Show();
            this.Close();
        }

        private void BtnDrawing_Click(object sender, EventArgs e)
        {
            Dibujo d = new Dibujo(pdId);
            d.Show();
            this.Close();
        }

        private void BtnData_Click(object sender, EventArgs e)
        {
            ModalInsp2 mi = new ModalInsp2(pdId);
            if (mi.ShowDialog() == DialogResult.Yes)
            {
                GeomembraneForm_Load(sender, e);
            }
        }

        private void DGVGeo_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (DGVGeo.IsCurrentCellDirty)
            {
                int number;
                if (e.ColumnIndex == 4)
                {

                    var data = DGVGeo[e.ColumnIndex, e.RowIndex].EditedFormattedValue.ToString();
                    var validate = int.TryParse(data, out number);
                    if (!validate)
                    {
                        MetroMessageBox.Show(this, "Error input Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                if (e.ColumnIndex == 5)
                {

                    var data = DGVGeo[e.ColumnIndex, e.RowIndex].EditedFormattedValue.ToString();
                    var validate = int.TryParse(data, out number);
                    if (!validate)
                    {
                        MetroMessageBox.Show(this, "Error input Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                if (e.ColumnIndex == 6)
                {

                    var data = DGVGeo[e.ColumnIndex, e.RowIndex].EditedFormattedValue.ToString();
                    var validate = int.TryParse(data, out number);
                    if (!validate)
                    {
                        MetroMessageBox.Show(this, "Error input Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void DGVGeo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
