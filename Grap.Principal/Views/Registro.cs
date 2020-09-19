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
        public Registro()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            var cd=TxtCode.Text;
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
                Code=cd,
                Name=TxtName.Text,
                Image=cd+"_"+TxtImage.Text
            };

            db.Clients.Add(c);
            db.SaveChanges();

            ListaClientes lc = new ListaClientes();
            lc.Show();
            this.Close();


        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //Filtro de los archivos que se veran en este caso solo veremos pueros .pdf
            //    openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        //Aqui seleciona el Archivo y se ponen el el cuadro de texto
            //        TxtImage.Text = openFileDialog1.FileName;
            //        File.Copy(openFileDialog1.FileName, "Resources\\images\\" + Path.GetFileName(openFileDialog1.FileName));



            //    }

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("No se Cargo la Imagen " + ex.ToString());
            //}

            ////Propuesta 2
            //try
            //{
            //    //////    //Filtro de los archivos que se veran en este caso solo veremos pueros .pdf
            //    openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            //    openFileDialog1.ShowDialog();
            //    DialogResult dr = openFileDialog1.ShowDialog();
            //    if (DialogResult == DialogResult.OK)
            //    {
            //        TxtImage.Text = openFileDialog1.FileName;
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("No se Cargo la Imagen " + ex.ToString());
            //}
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

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
