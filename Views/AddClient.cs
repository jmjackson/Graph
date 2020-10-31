using Mine.DataContext;
using Mine.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mine.Views
{
    public partial class AddClient : Form
    {
        readonly GraphDbContext db = new GraphDbContext();
     
        public AddClient()
        {
            
            InitializeComponent();
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OFDialog.Filter = "Image Files((*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (OFDialog.ShowDialog() == DialogResult.OK)
                {
                    PbClient.Image = Image.FromFile(OFDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Image Not Upload" + ex.ToString(), "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var cd = TxtCode.Text;
                

                Image img = PbClient.Image as Image;
                byte[] imgbyte;
                using (MemoryStream m=new MemoryStream())
                {
                    img.Save(m,System.Drawing.Imaging.ImageFormat.Png);
                    imgbyte = m.ToArray();
                }

                var cl = new Client()
                {
                    Code = cd,
                    Name = TxtName.Text,
                    ImgCl=imgbyte,
                    
                };

                db.Clients.Add(cl);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("His data not upload" + ex.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
