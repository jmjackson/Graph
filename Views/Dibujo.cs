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
        
        private Boolean draw = false;
        private double diffxy;
        private int curX, curY,x,y, diffx, diffy;
        private int a = 0, b = 0;
        readonly private Color colors;
        Point medio = new Point(0, 0);
        int? X = null;
        int? Y = null;
        int ancho;

        //Graphics g;
        //private Bitmap imagen;
        readonly int pdId;
        //int selecc_Opcion=1;
        public Dibujo(int dev)
        {
            InitializeComponent();
            //g = PbLienzo.CreateGraphics();
            pdId = dev;
            //BtnDraw.Enabled = false;

            bmp = new Bitmap(Pdibujo.Width,Pdibujo.Height);
            Pdibujo.CreateGraphics().DrawImage(bmp, 0, 0);
        }

        //int? X = null;
        //int? Y = null;
        //bool dibujar = false;
        //Color color = Color.Black;
        //int ancho = 2;
         private Bitmap bmp;
        private void Dibujo_Load(object sender, EventArgs e)
        {
            var Pn = db.ProjectDevs.Include(a => a.Project).Where(a => a.Id == pdId).FirstOrDefault();
            

            var projectno = (from d in db.Developments where d.ProjectDevId == Pn.Id select d).ToList();
            var seamno = (from s in db.GeoMembranes where s.ProjectDevId == Pn.Id select s).ToList();

            foreach (var item in projectno)
            {
                
                ListBoxData.Items.Add(item.PanelNo);

            }
            foreach (var item in seamno)
            {
                SNOList.Items.Add(item.Id+"-"+item.SeamNo);
            }

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
        //private void PbLienzo_MouseClick_1(object sender, MouseEventArgs e)
        //{
        //    //if (selecc_Opcion == 2)
        //    //{
        //    //    if (dibujar == true)
        //    //    {
        //    //        Font font2 = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
        //    //        Graphics g = Graphics.FromImage(imagen);

        //    //        //seleciona de la tabla y lo dibuja
        //    //        int projecn = Convert.ToInt32(DgLpn.CurrentRow.Cells[1].Value);
        //    //        string texto = Convert.ToString(projecn);

        //    //        g.DrawString(texto, font2, new SolidBrush(Color.Black), e.X, e.Y);

        //    //        PbLienzo.Image = imagen;
        //    //    }
        //    //}
        //    //if (selecc_Opcion == 3)
        //    //{
        //    //    //Dibujamos Cordenada y simbologia
        //    //    if (dibujar == true)
        //    //    {
        //    //        Font font2 = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
        //    //        Graphics g = Graphics.FromImage(imagen);

        //    //        //seleciona de la tabla y lo dibuja
        //    //        //string texto = Convert.ToString(DgCordenada.CurrentRow.Cells[1].Value);
        //    //        g.DrawString(" ", font2, new SolidBrush(Color.Black), e.X, e.Y);

        //    //        PbLienzo.Image = imagen;
        //    //    }
        //    //}
        //}

        //private void PbLienzo_MouseDown_1(object sender, MouseEventArgs e)
        //{
        //    //dibujar = true;

        //}
        private void BtnClear_Click(object sender, EventArgs e)
        {
            //borrador
            a = -1;
        }
        private void BtnPluma_Click(object sender, EventArgs e)
        {
            //lapiz
            a = 0;
        }
        private void BtnLinia_Click(object sender, EventArgs e)
        {
            // linia
            a = 1;
        }
        private void BtnRectangulo_Click(object sender, EventArgs e)
        {
            //rectangulo
            a = 2;
        }
        private void BtnCircle_Click(object sender, EventArgs e)
        {
            //circulo
            a = 3;
        }
        private void BtnCuadrado_Click(object sender, EventArgs e)
        {
            //cuadrado
            a = 4;
        }
        private void BtnTriangulo_Click(object sender, EventArgs e)
        {
            //triangulo
            a = 5;
        }
        private void BtnSet_Click(object sender, EventArgs e)
        {
            a = 7;
        }
        private void BtnTrianguloRectangulo_Click(object sender, EventArgs e)
        {
            a = 8;
        }

        private void Pdibujo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                draw = true;
                b++;
            }
            curX = e.X;
            curY = e.Y;
        }

        private void Pdibujo_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
            X = null;
            Y = null;
        }

        private void Pdibujo_MouseMove(object sender, MouseEventArgs e)
        {
 
            diffxy = Math.Sqrt((diffx * diffx) + (diffy * diffy));
            if (draw == true)
            {
                x = e.X;
                y = e.Y;

                using (Graphics g = Graphics.FromImage(bmp))
                {
                    if (a == 0)
                    {
                        g.DrawLine(new Pen(Color.Black, ancho), new Point(X ?? e.X, Y ?? e.Y), new Point(e.X, e.Y));
                        X = e.X;
                        Y = e.Y;
                    }
                    if (a == -1)
                    {
                        
                        g.DrawLine(new Pen(Color.White, ancho), new Point(X ?? e.X, Y ?? e.Y), new Point(e.X, e.Y));
                        X = e.X;
                        Y = e.Y;
                    }
                }
                Pdibujo.Invalidate();

            }
        }
            

        private void Pdibujo_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics myPaint = Graphics.FromImage(bmp);
            if (draw == true)
            {
                x = e.X;
                y = e.Y;
                diffx = e.X - curX;
                diffy = curY - e.Y;

                //Medidas para el trinagulo Normal
                // medio.X = x - (cx - x);
                medio.X = curX - (x - curX);
                // medio.Y = cy;//cx, cy, en este caso se usan como puntos iniciales
                medio.Y = y;

                int w = 100, h = 100;
                Rectangle rect = new Rectangle(e.X, e.Y, diffx, diffy);
                if (a == 1)
                {
                    //Linia
                    myPaint.DrawLine(new Pen(Color.Black), curX, curY, e.X, e.Y);
                    myPaint.DrawLine(new Pen(Color.Black), curX, curY, e.X, e.Y);
                }
                if (a == 2)
                {
                    //Rectangulo
                    myPaint.DrawRectangle(new Pen(Color.Black), curX, curY, diffx, -diffy);
                    myPaint.DrawRectangle(new Pen(Color.Black), curX, curY, diffx, -diffy);
                }
                if (a == 3)
                {
                    //Circulo
                    myPaint.DrawEllipse(new Pen(Color.Black),curX,curY,diffx,-diffy);
                    myPaint.DrawEllipse(new Pen(Color.Black), curX, curY, diffx, -diffy);
                }
                if (a == 4)
                {
                    //Cuadrado
                    myPaint.DrawRectangle(new Pen(Color.Black), curX, curY, diffx, diffx);
                    myPaint.DrawRectangle(new Pen(Color.Black), curX, curY, diffx, diffx);
                }
                if (a == 5)
                {
                    //Triangulo
                    myPaint.DrawLine(new Pen(Color.Black), x, y, curX, curY);
                    myPaint.DrawLine(new Pen(Color.Black), x, y, medio.X, medio.Y);
                    myPaint.DrawLine(new Pen(Color.Black), medio.X, medio.Y, curX, curY);
                }
                if (a == 7)
                {
                    //texto
                    var select = Convert.ToInt32(ListBoxData.SelectedItem.ToString());
                    var tdev = db.Developments.Where(a => a.ProjectDevId == pdId).Where(a => a.PanelNo == select).FirstOrDefault();
                    //var tgeo = db.GeoMembranes.Where(a => a.ProjectDevId == pdId).FirstOrDefault();

                    string text1 = "PNo:" + tdev.PanelNo.ToString() + ", RNo.: " + tdev.RollNo + "\nL:" + tdev.Lenght + ", W:" + tdev.Width +
                        "\nT:" + tdev.Thickness + ", Date:" + tdev.DeploymentDate.ToShortDateString();
                    using (Font font1 = new Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Point))
                    {
                        //RectangleF rectF1 = new RectangleF(e.X, e.Y, diffx, diffy);
                        RectangleF rectF1 = new RectangleF(e.X, e.Y, 150, 50);//cordenadas primero y luego tamano
                        myPaint.DrawString(text1, font1, Brushes.DarkGray, rectF1);
                        myPaint.DrawRectangle(Pens.White, Rectangle.Round(rectF1));
                    }
                }
                if (a == 8)
                {
                    int posx1 = x;
                    int posy1 = y;

                    int posx2 = curX;
                    int posy2 = curY;

                    int altura = posy2 - posy1;
                    int base_ = posx2 - posx1;

                    int posx = posx1;
                    int posy = posy2;
                    // Base
                    myPaint.DrawLine(new Pen(Color.Black), posx, posy, posx + base_, posy);
                    // Altura
                    myPaint.DrawLine(new Pen(Color.Black), posx, posy, posx, posy - altura);
                    // Hipotenusa
                    myPaint.DrawLine(new Pen(Color.Black), posx, posy - altura, posx + base_, posy);

                }
                if (a==9)
                {
                    //texto
                    var select = SNOList.SelectedItem.ToString();
                    string[] data = select.Split('-');
                    var sel = Convert.ToInt32(data[0]);
                    var tgeo = db.GeoMembranes.Where(a => a.ProjectDevId == pdId).Where(a => a.Id == sel).FirstOrDefault();
                    

                    string text1 = "SN:" + tgeo.SeamNo.ToString() + ", SL.: " + tgeo.SeamLength.ToString() + "\nST:" + tgeo.SeamTime + ", WT:" + tgeo.WedgeTemp +
                        "\nWS:" + tgeo.WedgeSpeed + ", D:" + tgeo.Destructive.ToString()+"R:"+tgeo.RemarksDestructive;
                    using (Font font1 = new Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Point))
                    {
                        //RectangleF rectF1 = new RectangleF(e.X, e.Y, diffx, diffy);
                        RectangleF rectF1 = new RectangleF(e.X, e.Y, 150, 50);//cordenadas primero y luego tamano
                        myPaint.DrawString(text1, font1, Brushes.DarkGray, rectF1);
                        myPaint.DrawRectangle(Pens.White, Rectangle.Round(rectF1));
                    }
                }
            }
        }

        private void TbGrosor_Scroll(object sender, EventArgs e)
        {
            TrackBar Modificador = new TrackBar();
            lblGrosor.Text = TbGrosor.Value.ToString();
            ancho = Convert.ToInt32(lblGrosor.Text);
        }

        private void TxtGrosor_TextChanged(object sender, EventArgs e)
        {
            ////if (Convert.ToInt32(TxtGrosor.Text)<0)
            ////{
            ////    ancho = Convert.ToInt32(TxtGrosor.Text);
            ////}
        }

        private void TxtGrosor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ////evita ingresar teto en el cuadro de texto de grosor
            //if (Char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (Char.IsControl(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (Char.IsSeparator(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //}
        }

        private void PanelRight_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void BtnSeamNo_Click(object sender, EventArgs e)
        {
            a = 9;
        }

        private void Pdibujo_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, Point.Empty);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //var dp = db.ProjectDevs.Find(pdId);
            
            //Image img = Pdraw.Image as Image;
            //byte[] imgs;
            //using(MemoryStream m=new MemoryStream())
            //{
            //   img.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
            //   imgs = m.ToArray();
            //}
            //dp.ImageDev = imgs;
            //db.SaveChanges();

        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.DefaultExt = "bmp";
            saveFileDialog.Filter = "Bitmap files|*.bmp";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Pdibujo.DrawToBitmap(bmp, new Rectangle(0, 0, Pdibujo.Width, Pdibujo.Height));
                bmp.Save(saveFileDialog.FileName);
            }

        }

        //private void PbLienzo_MouseMove_1(object sender, MouseEventArgs e)
        //{
        //    //if (selecc_Opcion == 1)
        //    //{
        //    //    if (dibujar == true)
        //    //    {
        //    //        //Herramienta cuyas propiedades son cambiadas de acuerdo al valor de las variables 
        //    //        //declaradas al inicio

        //    //        Graphics g = Graphics.FromImage(imagen);
        //    //        Pen pluma = new Pen(color, ancho);

        //    //        //Dibuja una linea entre el punto anterior y el actual
        //    //        g.DrawLine(pluma, new Point(X ?? e.X, Y ?? e.Y), new Point(e.X, e.Y));
        //    //        X = e.X;
        //    //        Y = e.Y;
        //    //        PbLienzo.Image = imagen;
        //    //    }
        //    //}
        //    //if (selecc_Opcion == 4)
        //    //{
        //    //    if (dibujar == true)
        //    //    {
        //    //        //Herramienta cuyas propiedades son cambiadas de acuerdo al valor de las variables 
        //    //        //declaradas al inicio
        //    //        Color color2 = Color.White;
        //    //        int ancho2 = 10;
        //    //        Graphics g = Graphics.FromImage(imagen);
        //    //        Pen borrador = new Pen(color2, ancho2);

        //    //        //Dibuja una linea entre el punto anterior y el actual
        //    //        g.DrawLine(borrador, new Point(X ?? e.X, Y ?? e.Y), new Point(e.X, e.Y));
        //    //        X = e.X;
        //    //        Y = e.Y;
        //    //        PbLienzo.Image = imagen;
        //    //    }
        //    //}
        //}

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
