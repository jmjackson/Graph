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
        readonly GraphDbContext db = new GraphDbContext();

        //
        Bitmap btm;

        private Graphics myPaint;
        private Boolean draw = false;
        private double diffxy;
        private int curX, curY,x,y, diffx, diffy;
        private int a = 0, b = 0;
        private Color pintura;

        int? X = null;
        int? Y = null;


        //Graphics g;
        //private Bitmap imagen;
        int pdId;
        //int selecc_Opcion=1;
        public Dibujo(int dev)
        {
            InitializeComponent();
            //g = PbLienzo.CreateGraphics();
            //imagen = new Bitmap(PbLienzo.Width, PbLienzo.Height);
            pdId = dev;
            //BtnDraw.Enabled = false;
        }

        //int? X = null;
        //int? Y = null;
        //bool dibujar = false;
        //Color color = Color.Black;
        //int ancho = 2;


        private void Dibujo_Load(object sender, EventArgs e)
        {
            myPaint = PbDraw.CreateGraphics();

            var Pn = db.ProjectDevs.Include(a => a.Project).Where(a => a.Id == pdId).FirstOrDefault();

            var projectno = (from d in db.Developments where d.ProjectDevId == Pn.Id select d).ToList();

            foreach (var item in projectno)
            {
                //DgLpn.AutoGenerateColumns = false;
                //DgLpn.Columns["Id"].DataPropertyName = "Id";
                //DgLpn.Columns["PanelNo"].DataPropertyName = "PanelNo";
                //DgLpn.DataSource = projectno;
                //var panel = item.PanelNo;
                ListBoxData.Items.Add(item.PanelNo);

            }

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
        private void BtnPluma_Click(object sender, EventArgs e)
        {
            a = 0;
        }
        private void BtnLinia_Click(object sender, EventArgs e)
        {
            a = 1;
        }
        private void BtnCuadrado_Click(object sender, EventArgs e)
        {
            a = 2;
        }

        private void BtnCirculo_Click(object sender, EventArgs e)
        {
            a = 3;
        }

        private void BtnTriangulo_Click(object sender, EventArgs e)
        {
            a = 4;
        }
        private void BtnRectangulo_Click(object sender, EventArgs e)
        {
            a = 5;
        }
        private void BtnTexto_Click(object sender, EventArgs e)
        {
            a = 7;
        }
        private void BtnBorrador_Click(object sender, EventArgs e)
        {
            a = 8;
        }
        private void PbDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                draw = true;
                b++;
            }
            curX = e.X;
            curY = e.Y;
        }

        private void PbDraw_MouseMove(object sender, MouseEventArgs e)
        {
            //textBox1.Text = Convert.ToString(diffx);
            //textBox2.Text = Convert.ToString(diffy);
            //diffxy = Math.Sqrt((diffx * diffx) + (diffy * diffy));
            //textBox3.Text = Convert.ToString(diffxy);

            if (draw == true)
            {
                if (a==0)
                {
                    myPaint.DrawLine(new Pen(Color.Black), new Point(X ?? e.X, Y ?? e.Y), new Point(e.X, e.Y));
                    X = e.X;
                    Y = e.Y;
                }
                if (a == 8)
                {
                    myPaint.DrawLine(new Pen(Color.White,30), new Point(X ?? e.X, Y ?? e.Y), new Point(e.X, e.Y));
                    X = e.X;
                    Y = e.Y;
                }
            }

        }

        private void PbDraw_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;

            X = null;
            Y = null;
        }

        private void PbDraw_MouseClick(object sender, MouseEventArgs e)
        {
            if (draw == true)
            {
                x = e.X;
                y = e.Y;
                diffx = e.X - curX;
                diffy = curY - e.Y;

                int w = 100,h=100;
                Rectangle rect = new Rectangle(e.X, e.Y, diffx, diffy);
                if (a==1)
                {
                    //Linia
                    myPaint.DrawLine(new Pen(Color.Black), curX, curY, e.X, e.Y);
                    myPaint.DrawLine(new Pen(Color.Black),curX,curY,e.X,e.Y);
                }
                if (a == 2)
                {
                    //Cuadrado
                    //Rectangle cuadrado = new Rectangle(e.X, e.Y,w,h);
                    //myPaint.DrawRectangle(new Pen(Color.Black),shape);

                }
                if (a == 3)
                {
                    //Circulo
                    //myPaint.DrawEllipse(new Pen(Color.Black), rect);
                    myPaint.DrawEllipse(new Pen(Color.Black), e.X, e.Y, diffx, diffy);
                }
                if (a == 4)
                {
                    //Triangulo
                    //myPaint.DrawEllipse(new Pen(Color.Black), shape);
                }
                if (a == 5)
                {
                    // Draw rectangle to screen.
                    //myPaint.DrawRectangle(new Pen(Color.Black), rect);
                    myPaint.DrawRectangle(new Pen(Color.Black), e.X, e.Y, diffx, diffy);
                }
                if (a == 7)
                {
                    string text1 = "Draw text in a rectangle by passing a RectF to the DrawString method.";
                    using (Font font1 = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point))
                    {
                        //RectangleF rectF1 = new RectangleF(e.X, e.Y, diffx, diffy);
                        RectangleF rectF1 = new RectangleF(e.X, e.Y, 100, 122);//cordenadas primero y luego tamano
                        myPaint.DrawString(text1, font1, Brushes.Blue, rectF1);
                        myPaint.DrawRectangle(Pens.Black, Rectangle.Round(rectF1));
                    }
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            a = 8;
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
            //draw = false;

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

        private void SeamingButton_Click(object sender, EventArgs e)
        {
            GeomembraneForm gf = new GeomembraneForm(pdId);
            gf.Show();
            this.Close();

        }

        private void DeployButton_Click(object sender, EventArgs e)
        {
            DevelopmentForm df = new DevelopmentForm(pdId);
            df.Show();
            this.Close();
        }
    }
}
