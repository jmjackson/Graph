using Mine.DataContext;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;


namespace Mine.Views
{
    public partial class Dibujo : MetroFramework.Forms.MetroForm
    {
        //conexion bd o consulta 
        readonly GraphDbContext db = new GraphDbContext();
        Graphics g;
        private Bitmap imagen;

        int pdId;


        public Dibujo(int dev)
        {
            InitializeComponent();
            g = PbLienzo.CreateGraphics();
            //PbLienzo.Image = new Bitmap(PbLienzo.Width, PbLienzo.Height);
            imagen = new Bitmap(PbLienzo.Width, PbLienzo.Height);

            pdId = dev;

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

                Graphics g = Graphics.FromImage(imagen);
                Pen pluma = new Pen(color, ancho);

                //Dibuja una linea entre el punto anterior y el actual
                g.DrawLine(pluma, new Point(X ?? e.X, Y ?? e.Y), new Point(e.X, e.Y));
                X = e.X;
                Y = e.Y;
                PbLienzo.Image = imagen;
            }
        }

        private void PbLienzo_MouseClick(object sender, MouseEventArgs e)
        {
            string text2 = "p-1";
            Font font2 = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);

            Graphics g = Graphics.FromImage(imagen);

            g.DrawString(text2, font2, new SolidBrush(Color.Black),e.X+10,e.Y+25);

            //TextRenderer.DrawText(g, text2, font2, new Point(X ?? e.X, Y ?? e.Y), Color.Blue,flags);

            PbLienzo.Image = imagen;
        }
        private void BntSave_Click(object sender, EventArgs e)
        {

            Bitmap bmp = (Bitmap)PbLienzo.Image;

            saveFileDialog1.FileName = "Dibujo" + DateTime.Now.ToString(" yyyy_MM_dd_HHmmss ");

            saveFileDialog1.Filter = "Excel files (*.jpg)|*.jpg";

            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PbLienzo.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }

        }

        private void Dibujo_Load(object sender, EventArgs e)
        {
            var Pn = db.ProjectDevs.Include(a => a.Project).Where(a => a.Id == pdId).FirstOrDefault();

            var projectno =(from d in db.Developments where d.ProjectDevId== Pn.Id select d ).ToList();

            foreach (var item in projectno)
            {
                DgLpn.AutoGenerateColumns = false;
                DgLpn.Columns["Id"].DataPropertyName = "Id";
                DgLpn.Columns["PanelNo"].DataPropertyName = "PanelNo";
                DgLpn.DataSource = projectno;
                //var panel = item.PanelNo;
            }

        }
    }
}
