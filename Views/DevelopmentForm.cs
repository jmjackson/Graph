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
            LblRClient.Text = pdev.Project.Client.Name;
            LblRContractor.Text = pdev.Project.Contractor;
            LblRGeosyntetic.Text = pdev.Project.GeoSynthetic;
            LblRProject.Text = pdev.Project.PName;
            LblRProjectNo.Text = pdev.Project.ProjectNo;
            LblRSupplier.Text = pdev.Project.Supplier;
            
            //if (pdev.Project.Client.Image != null)
            //{
            //    PBPicture.Image = Image.FromFile(pdev.Project.Client.Image);
            //}
            
            
            TxtDate.Value = pdev.DevTime;
            DGVFill();
            

        }



        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    AddDeployment ad = new AddDeployment(proDevId);
            //    if (ad.ShowDialog()==DialogResult.Yes)
            //    {
            //        DevelopmentForm_Load(sender,e);
            //    }
            //    DevelopmentForm_Load(sender, e);
            //}
            //catch (Exception ex)
            //{
            //    MetroMessageBox.Show(this, "Error in your record "+ex.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            DataTable datatable = new DataTable();
            datatable = DGVDev.DataSource as DataTable;

            //Agregar las Filas al DataRow
            DataRow datarow;
            for (int i = 0; i < 5; i++)
            {
                datarow = datatable.NewRow();
                datarow[i].ToString();
                datatable.Rows.Add(datarow);
            }
        }

        public void DGVFill()
        {
            var devdata = db.Developments.Where(a=>a.ProjectDevId==proDevId).ToList();
            if (devdata.Count>0 || DGVDev.CurrentRow!=null)
            {
                developmentBindingSource.DataSource = devdata;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int pdId = Convert.ToInt32(DGVDev.CurrentRow.Cells[0].Value);
           
            EditDeployment ed = new EditDeployment(pdId);
            if (ed.ShowDialog()==DialogResult.Yes)
            {
                DevelopmentForm_Load(sender,e);
            }
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int pdId = Convert.ToInt32(DGVDev.CurrentRow.Cells["Id"].Value);
                    var dev = db.Developments.Find(pdId);
                    db.Developments.Remove(dev);
                    db.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Deleted Successfully","Info");
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

        private void DGVDev_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVDev.CurrentRow!=null)
            {
                DataGridViewRow dgvr = DGVDev.CurrentRow;
                Development dv = new Development();
                

            }
        }

        
    }
}
