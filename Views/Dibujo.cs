using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mine.Views
{
    public partial class Dibujo : MetroFramework.Forms.MetroForm
    {
        Graphics g;
        //private Bitmap imagen;
        public Dibujo()
        {
            InitializeComponent();
            g = PbLienzo.CreateGraphics();
            //imagen = new Bitmap(PbLienzo.Width, PbLienzo.Height);
        }
    
        int? X = null;
        int? Y = null;

        Color color = Color.Black;
        int ancho = 2;

        bool dibujar = false;


        private void PbLienzo_MouseDown(object sender, MouseEventArgs e)
        {
            dibujar = true;
        }

        private void PbLienzo_MouseUp(object sender, MouseEventArgs e)
        {
            dibujar = false;

            X = null;
            Y = null;
        }

        private void PbLienzo_MouseMove(object sender, MouseEventArgs e)
        {
            if (dibujar == true)
            {
                //Herramienta cuyas propiedades son cambiadas de acuerdo al valor de las variables 
                //declaradas al inicio
                Pen pluma = new Pen(color, ancho);

                //Dibuja una linea entre el punto anterior y el actual
                g.DrawLine(pluma, new Point(X ?? e.X, Y ?? e.Y), new Point(e.X, e.Y));
                X = e.X;
                Y = e.Y;
            }
        }

        private void PbLienzo_MouseClick(object sender, MouseEventArgs e)
        {
            g.DrawRectangle(new Pen(color, ancho), e.X - (50 / 2), e.Y - (50 / 2), 50, 50);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)PbLienzo.Image;

            saveFileDialog1.FileName = "Dibujo" + DateTime.Now.ToString("yyyy_MM_dd_HHmmss");
            //saveFileDialog1.Filter = "Excel files (*.png)|*.png";
            saveFileDialog1.Filter = "Draw files (*.png)|*.png|(*.jpg)|*.jpg";

            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PbLienzo.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
                //bmp.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }
    }
}
