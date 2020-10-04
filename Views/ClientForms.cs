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
    public partial class ClientForms : MetroFramework.Forms.MetroForm
    {
        public ClientForms()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            using (GraphDbContext db=new GraphDbContext())
            {
                clientBindingSource.DataSource = db.Clients.ToList();
            }
                PanelAdd.Enabled = false;
                Client cl = clientBindingSource.Current as Client;
                if (cl != null)
                    PBImage.Image = Image.FromFile(cl.Image);
                
           
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd=new OpenFileDialog() {Filter="JPG|*.jpg" })
            {
                var path = @"Resources/images/";
                if (Directory.Exists(path))
                {
                    
                }
                else
                {
                    Directory.CreateDirectory(path);
                    
                }
                if (ofd.ShowDialog()==DialogResult.OK)
                {
                    var img = path + TxtCode.Text + "_Client.Jpg";
                    PBImage.Image = new Bitmap(ofd.FileName);
                    PBImage.Image.Save(img);
                    Client c = clientBindingSource.Current as Client;
                    if(c != null)
                    {
                        c.Image = img;
                    }
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            PBImage.Image = null;
            PanelAdd.Enabled = true;
            clientBindingSource.Add(new Client());
            clientBindingSource.MoveLast();
            TxtCode.Focus();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            PanelAdd.Enabled = true;
            TxtCode.Focus();
            Client cl = clientBindingSource.Current as Client;

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            PanelAdd.Enabled = false;
            clientBindingSource.ResetBindings(false);
            Clients_Load(sender,e);
        }

        private void GDVClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Client cl = clientBindingSource.Current as Client;
            if (cl!=null)
            {
                PBImage.Image = Image.FromFile(cl.Image);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this,"Are you sure want to delete this record?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                using (GraphDbContext db=new GraphDbContext())
                {
                    Client cl = clientBindingSource.Current as Client;
                    if (cl!=null)
                    {
                        if (db.Entry<Client>(cl).State == EntityState.Detached)
                        {
                            db.Set<Client>().Attach(cl);
                        }
                        db.Entry<Client>(cl).State = EntityState.Deleted;
                        db.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Deleted Successfully");
                        clientBindingSource.RemoveCurrent();
                        PanelAdd.Enabled = false;
                        PBImage.Image = null;
                    }
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (GraphDbContext db=new GraphDbContext())
            {
                Client c = clientBindingSource.Current as Client;
                if (c != null)
                {
                    if (db.Entry<Client>(c).State == EntityState.Detached)
                    {
                        db.Set<Client>().Attach(c);
                    }
                    if (c.Id == 0)
                    {
                        db.Entry<Client>(c).State = EntityState.Added;
                    }
                    else
                    {
                        db.Entry<Client>(c).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this,"Save Successfully");
                    GDVClients.Refresh();
                    PanelAdd.Enabled = false;

                }
            }
        }
    }
}
