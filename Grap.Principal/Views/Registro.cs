using Grap.Principal.DataModel;
using Grap.Principal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grap.Principal.Views
{
    public partial class Registro : Form
    {
        readonly DataBaseContext db = new DataBaseContext();
        public Registro(ListaClientes lf)
        {
            InitializeComponent();
            
        }

        
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       
        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnImage_Click(object sender, EventArgs e)
        {
            try
            {
                OFDialog.Filter = "Image Files((*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (OFDialog.ShowDialog()==DialogResult.OK)
                {
                    PBoxImage.Image = new Bitmap(OFDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Su imagen no pudo ser cargada"+ex.ToString(),"Error de Carga",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                var cd = TxtCode.Text;
                var path = @"Resources/images/";

                if (Directory.Exists(path))
                {
                    PBoxImage.Image.Save(path + cd + "_cliente.jpg");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    PBoxImage.Image.Save(path + cd + "_cliente.jpg");
                }
                Clients c = new Clients()
                {
                    Code = cd,
                    Name = TxtName.Text,
                    Image = path + cd + "_cliente.jpg"
                };
                db.Clients.Add(c);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sus datos no han sido cargados"+ex.ToString(),"Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            this.Close();

        }

        private void PBoxImage_Click(object sender, EventArgs e)
        {

        }

        private void LblImage_Click(object sender, EventArgs e)
        {

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblRegister_Click(object sender, EventArgs e)
        {

        }

        private void LblImg_Click(object sender, EventArgs e)
        {

        }

        private void LblName_Click(object sender, EventArgs e)
        {

        }

        private void LblCodigo_Click(object sender, EventArgs e)
        {

        }
    }
}
