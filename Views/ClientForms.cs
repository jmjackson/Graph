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
using System.Data.Entity;
using System.IO;

namespace Mine.Views
{
    public partial class ClientForms : Form
    {
        readonly GraphDbContext db = new GraphDbContext();
        public ClientForms()
        {
            InitializeComponent();
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddClient ac = new AddClient();
            if (ac.ShowDialog()==DialogResult.OK)
            {
                MetroFramework.MetroMessageBox.Show(this,"Save Successfull","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                UpdateDGV();
            }
        }

        private void UpdateDGV()
        {
            var lc = db.Clients.ToList();
            if (lc.Count>0)
            {
                GDVClients.AutoGenerateColumns = false;
                GDVClients.Columns[columnName: "Id"].DataPropertyName = "Id";
                GDVClients.Columns["Code"].DataPropertyName = "Code";
                GDVClients.Columns["CName"].DataPropertyName = "Name";
                GDVClients.DataSource = lc;
                GDVClients.Refresh();
            }
            
        }

        
       

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(GDVClients.CurrentRow.Cells[0].Value);
            if (MetroFramework.MetroMessageBox.Show(this,"Are you sure want to delete this record?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    var cdb=db.Clients.Find(id);
                    db.Entry<Client>(cdb).State = EntityState.Deleted;
                    db.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Deleted Successfully","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
            UpdateDGV();
        }

       

        private void ClientForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principal p = new Principal();
            p.Show();
        }

        private void ClientForms_Load(object sender, EventArgs e)
        {
            var lc = db.Clients.ToList();
            GDVClients.AutoGenerateColumns = false;
            GDVClients.Columns["Id"].DataPropertyName = "Id";
            GDVClients.Columns["Code"].DataPropertyName = "Code";
            GDVClients.Columns["CName"].DataPropertyName = "Name";
            GDVClients.DataSource = lc;
            
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
           this.Close();

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
