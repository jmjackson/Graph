using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grap.Principal.Views
{
    public partial class Registro : Form
    {
        SQLiteController SQ = new SQLiteController();
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
            //Correguir esta part dela comparacion ya que no se sabe si el codigo lleva letas o no 
            //if (SQ.Registrado(Convert.ToInt32(TxtCode.Text)) == 0)
            //{
                MessageBox.Show(SQ.insertar(TxtCode.Text, TxtName.Text, TxtImage.Text));
                TxtCode.Text = "";
                TxtName.Text = "";
                TxtImage.Text = "";


            //}
            //else
            //{
            //    MessageBox.Show("Imposible de regitrar, El registro ya existe");
            //}
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //Filtro de los archivos que se veran en este caso solo veremos pueros .pdf
                openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //Aqui seleciona el Archivo y se ponen el el cuadro de texto
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
