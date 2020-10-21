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
using System.Drawing.Imaging;

namespace Mine.Views
{
    public partial class Dibujo : MetroFramework.Forms.MetroForm
    {
        //conexion bd o consulta 
        readonly GraphDbContext db = new GraphDbContext();
        Graphics g;
        private Bitmap imagen;
        int pdId;
        int selecc_Opcion=1;
        public Dibujo(int dev)
        {
            InitializeComponent();
            g = PbLienzo.CreateGraphics();
            imagen = new Bitmap(PbLienzo.Width, PbLienzo.Height);
            pdId = dev;
            BtnDraw.Enabled = false;
        }

        int? X = null;
        int? Y = null;
        bool dibujar = false;
        Color color = Color.Black;
        int ancho = 2;

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
            if (selecc_Opcion == 1)
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
            if (selecc_Opcion == 3)
            {
                if (dibujar == true)
                {
                    //Herramienta cuyas propiedades son cambiadas de acuerdo al valor de las variables 
                    //declaradas al inicio
                    Color color2 = Color.White;
                    int ancho2 = 10;
                    Graphics g = Graphics.FromImage(imagen);
                    Pen borrador = new Pen(color2, ancho2);

                    //Dibuja una linea entre el punto anterior y el actual
                    g.DrawLine(borrador, new Point(X ?? e.X, Y ?? e.Y), new Point(e.X, e.Y));
                    X = e.X;
                    Y = e.Y;
                    PbLienzo.Image = imagen;
                }
            }
            if (selecc_Opcion == 4)
            {
                if (dibujar == true)
                {
                    //Herramienta cuyas propiedades son cambiadas de acuerdo al valor de las variables 
                    //declaradas al inicio
                    Color color2 = Color.Black;
                    int ancho2 = 10;
                    Graphics g = Graphics.FromImage(imagen);
                    Pen borrador = new Pen(color2, ancho2);

                    //Dibuja una linea entre el punto anterior y el actual
                    g.DrawLine(borrador, new Point(X ?? e.X, Y ?? e.Y), new Point(e.X, e.Y));
                    X = e.X;
                    Y = e.Y;
                    PbLienzo.Image = imagen;
                }
            }
        }

        private void BntSave_Click(object sender, EventArgs e)
        {

            Bitmap bmp = (Bitmap)PbLienzo.Image;

            //saveFileDialog1.FileName = DateTime.Now.ToString(" yyyy_MM_dd_HHmmss ");

            //saveFileDialog1.Filter = "Excel files (*.jpg)|*.jpg";

            //saveFileDialog1.RestoreDirectory = true;

            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    PbLienzo.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
            //}

            //PbLienzo.Image.Save(@"C:\Users\jesus\source\repos\Graph\bin\Debug\Resources\images\yyyy_MM_dd_HHmmss.Jpeg", ImageFormat.Png);

            string panth = @"C:\Users\jesus\source\repos\Graph\bin\Debug\Resources\images";
            PbLienzo.Image.Save(panth + DateTime.Now.ToString(" yyyy_MM_dd_HHmmss "), ImageFormat.Png);

        }

        private void Dibujo_Load(object sender, EventArgs e)
        {

            var Pn = db.ProjectDevs.Include(a => a.Project).Where(a => a.Id == pdId).FirstOrDefault();

            var projectno = (from d in db.Developments where d.ProjectDevId == Pn.Id select d).ToList();

            foreach (var item in projectno)
            {
                DgLpn.AutoGenerateColumns = false;
                DgLpn.Columns["Id"].DataPropertyName = "Id";
                DgLpn.Columns["PanelNo"].DataPropertyName = "PanelNo";
                DgLpn.DataSource = projectno;
                //var panel = item.PanelNo;
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            resetTools();
            ((Button)sender).Enabled = false;
            selecc_Opcion = 3;
        }

        private void PbLienzo_MouseClick(object sender, MouseEventArgs e)
        {
            if (selecc_Opcion == 2)
            {
                if (dibujar == true)
                {
                    Font font2 = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
                    Graphics g = Graphics.FromImage(imagen);

                    //seleciona de la tabla y lo dibuja
                    int projecn = Convert.ToInt32(DgLpn.CurrentRow.Cells[1].Value);
                    string texto = Convert.ToString(projecn);

                    g.DrawString(texto, font2, new SolidBrush(Color.Black), e.X, e.Y);

                    PbLienzo.Image = imagen;
                }
            }
        }
        void resetTools()
        {
            foreach (Control b in toolBox.Controls)
                b.Enabled = true;
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            resetTools();
            ((Button)sender).Enabled = false;
            selecc_Opcion = 1;
        }

        private void BntAddPanelNo_Click(object sender, EventArgs e)
        {
            resetTools();
            ((Button)sender).Enabled = false;
            selecc_Opcion = 2;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            resetTools();
            ((Button)sender).Enabled = false;
            try
            {
                OpenFileDialog edit = new OpenFileDialog();
                if (edit.ShowDialog() == DialogResult.OK)
                {
                    string imagen = edit.FileName;
                    PbLienzo.Image = Image.FromFile(imagen);
                    selecc_Opcion = 4;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }
    }
}
