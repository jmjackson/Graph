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

namespace Grap.Principal.Views.Modal
{
    public partial class ModalEditar : Form
    {
        readonly DataBaseContext db = new DataBaseContext();
        int clienteId = 0;
        public ModalEditar( int id)
        {
            InitializeComponent();
            clienteId = id;
            FillData(id);
        }

        private void FillData(int id)
        {
            var client = db.Clients.Find(id);
            TxtCode.Text = client.Code;
            TxtName.Text = client.Name;
            //No muestra la imagen que tiene el cliente a editar 
            PBox.Image = new Bitmap(client.Image);
        }

        //private void BtnEditar_Click(object sender, EventArgs e)
        //{
        //    var clientdb = db.Clients.Find(clienteId);
        //    clientdb.Code = TxtCode.Text;
        //    clientdb.Name = TxtName.Text;
        //    clientdb.Image = TxtImage.Text;
        //    db.SaveChanges();
        //    this.Close();

        //}

        private void BtnImage_Click(object sender, EventArgs e)
        {
            try
            {
                OFDialog.Filter = "Image Files((*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (OFDialog.ShowDialog() == DialogResult.OK)
                {
                    PBox.Image = new Bitmap(OFDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Su imagen no pudo ser cargada" + ex.ToString(), "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    PBox.Image.Save(path + cd + "_cliente.jpg");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    PBox.Image.Save(path + cd + "_cliente.jpg");
                }
                //Clients c = new Clients()
                //{
                //    Code = cd,
                //    Name = TxtName.Text,
                //    Image = path + cd + "_cliente.jpg"
                //};
                var clientdb = db.Clients.Find(clienteId);
                clientdb.Code = TxtCode.Text;
                clientdb.Name = TxtName.Text;
                clientdb.Image = path + cd + "_cliente.jpg";
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sus datos no han sido Actualizados" + ex.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();

        }
    }
}
