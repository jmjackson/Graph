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
                //////    //Filtro de los archivos que se veran en este caso solo veremos pueros .pdf
                openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    TxtImage.Text = openFileDialog1.FileName;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se Cargo la Imagen " + ex.ToString());
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            var cd = TxtCode.Text;
            //var Path = "C:Resources\\images" + ".jpg";
            var path = "~/Resources/images/";
            if (Directory.Exists(path))
            {
                //Bitmap bmp;
                String paths = Application.StartupPath;
                //bmp.Save(openFileDialog1.FileName, "Resources\\images\\" + Path.GetFileName(openFileDialog1.FileName));
                File.Copy(openFileDialog1.FileName, "Resources\\images\\" + Path.GetFileName(openFileDialog1.FileName));
            }
            Clients c = new Clients()
            {
                Code = cd,
                Name = TxtName.Text,
                Image = cd + "_" + TxtImage.Text
            };

            db.Clients.Add(c);
            db.SaveChanges();
           
            this.Close();
            

        }
    }
}
