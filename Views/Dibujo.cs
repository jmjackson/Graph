using Mine.DataContext;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using System.Drawing.Imaging;
using System.IO;
using Mine.DataModel;

namespace Mine.Views
{
    public partial class Dibujo : Form
    {
        //conexion bd o consulta 
        //readonly GraphDbContext db = new GraphDbContext();
        //Graphics g;
        //private Bitmap imagen;
        //int pdId;
        //int selecc_Opcion=1;
        public Dibujo(int dev)
        {
            InitializeComponent();
            //g = PbLienzo.CreateGraphics();
            //imagen = new Bitmap(PbLienzo.Width, PbLienzo.Height);
            //pdId = dev;
            //BtnDraw.Enabled = false;
        }

        //int? X = null;
        //int? Y = null;
        //bool dibujar = false;
        //Color color = Color.Black;
        //int ancho = 2;


        private void Dibujo_Load(object sender, EventArgs e)
        {
           

            //var Pn = db.ProjectDevs.Include(a => a.Project).Where(a => a.Id == pdId).FirstOrDefault();

            //var projectno = (from d in db.Developments where d.ProjectDevId == Pn.Id select d).ToList();

            //foreach (var item in projectno)
            //{
            //    DgLpn.AutoGenerateColumns = false;
            //    DgLpn.Columns["Id"].DataPropertyName = "Id";
            //    DgLpn.Columns["PanelNo"].DataPropertyName = "PanelNo";
            //    DgLpn.DataSource = projectno;
            //    //var panel = item.PanelNo;
            //}

            //tabla de cordenadas
     

            //if (Pn.ImageDev!=null)
            //{
            //    var picture = Convert.ToBase64String(Pn.ImageDev);
            //    PbLienzo.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(picture)));
            //}

            
        }

        //Reset tools
        //void resetTools()
        //{
        //    foreach (Control b in ToolsBox.Controls)
        //        b.Enabled = true;
        //}  
        //Tools button
        private void BtnDraw_Click_1(object sender, EventArgs e)
        {
            //resetTools();
            //((Button)sender).Enabled = false;
            //selecc_Opcion = 1;
        }

        private void BntAddPanelNo_Click_1(object sender, EventArgs e)
        {
            //resetTools();
            //((Button)sender).Enabled = false;
            //selecc_Opcion = 2;
        }

        private void BntSave_Click_1(object sender, EventArgs e)
        {
            

            try
            {
                //var dp = db.ProjectDevs.Find(pdId);
                //Image img = PbLienzo.Image as Image;
                //byte[] imgs;
                //using(MemoryStream m=new MemoryStream())
                //{
                //    img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
                //    imgs = m.ToArray();
                //}
                //dp.ImageDev = imgs;
                //db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardo el Dibujo" + ex.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnAC_Click_1(object sender, EventArgs e)
        {
            //resetTools();
            ((Button)sender).Enabled = false;
            //selecc_Opcion = 3;
        }

        private void BtnClear_Click_1(object sender, EventArgs e)
        {
            //resetTools();
            //((Button)sender).Enabled = false;
            //selecc_Opcion = 4;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PBLienzo_Click(object sender, EventArgs e)
        {

        }

        private void ToolsBox_Enter(object sender, EventArgs e)
        {

        }

        //Eventos de picturebox
        private void PbLienzo_MouseClick_1(object sender, MouseEventArgs e)
        {
            //if (selecc_Opcion == 2)
            //{
            //    if (dibujar == true)
            //    {
            //        Font font2 = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
            //        Graphics g = Graphics.FromImage(imagen);

            //        //seleciona de la tabla y lo dibuja
            //        int projecn = Convert.ToInt32(DgLpn.CurrentRow.Cells[1].Value);
            //        string texto = Convert.ToString(projecn);

            //        g.DrawString(texto, font2, new SolidBrush(Color.Black), e.X, e.Y);

            //        PbLienzo.Image = imagen;
            //    }
            //}
            //if (selecc_Opcion == 3)
            //{
            //    //Dibujamos Cordenada y simbologia
            //    if (dibujar == true)
            //    {
            //        Font font2 = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
            //        Graphics g = Graphics.FromImage(imagen);

            //        //seleciona de la tabla y lo dibuja
            //        //string texto = Convert.ToString(DgCordenada.CurrentRow.Cells[1].Value);
            //        g.DrawString(" ", font2, new SolidBrush(Color.Black), e.X, e.Y);

            //        PbLienzo.Image = imagen;
            //    }
            //}
        }

        private void PbLienzo_MouseDown_1(object sender, MouseEventArgs e)
        {
            //dibujar = true;
        }

        private void PbLienzo_MouseMove_1(object sender, MouseEventArgs e)
        {
            //if (selecc_Opcion == 1)
            //{
            //    if (dibujar == true)
            //    {
            //        //Herramienta cuyas propiedades son cambiadas de acuerdo al valor de las variables 
            //        //declaradas al inicio

            //        Graphics g = Graphics.FromImage(imagen);
            //        Pen pluma = new Pen(color, ancho);

            //        //Dibuja una linea entre el punto anterior y el actual
            //        g.DrawLine(pluma, new Point(X ?? e.X, Y ?? e.Y), new Point(e.X, e.Y));
            //        X = e.X;
            //        Y = e.Y;
            //        PbLienzo.Image = imagen;
            //    }
            //}
            //if (selecc_Opcion == 4)
            //{
            //    if (dibujar == true)
            //    {
            //        //Herramienta cuyas propiedades son cambiadas de acuerdo al valor de las variables 
            //        //declaradas al inicio
            //        Color color2 = Color.White;
            //        int ancho2 = 10;
            //        Graphics g = Graphics.FromImage(imagen);
            //        Pen borrador = new Pen(color2, ancho2);

            //        //Dibuja una linea entre el punto anterior y el actual
            //        g.DrawLine(borrador, new Point(X ?? e.X, Y ?? e.Y), new Point(e.X, e.Y));
            //        X = e.X;
            //        Y = e.Y;
            //        PbLienzo.Image = imagen;
            //    }
            //}
        }

        private void PbLienzo_MouseUp_1(object sender, MouseEventArgs e)
        {
            //dibujar = false;

            //X = null;
            //Y = null;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
