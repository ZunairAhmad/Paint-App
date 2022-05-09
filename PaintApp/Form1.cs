using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 900;
            this.Height = 700;
            bm = new Bitmap(PicPannel.Width, PicPannel.Height);
            g= Graphics.FromImage(bm);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            g.Clear(Color.White);
            PicPannel.Image = bm;
        }
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point x, y;
        Pen pen = new Pen(Color.Black,1);
        Pen pen1 = new Pen(Color.Black, 20);
        Pen erase = new Pen(Color.White,20);
        int index;
        int X,Y;
        int sqr_x , sqr_y;
        int cir_x , cir_y;
        ColorDialog cd = new ColorDialog();
        Color new_color;


        private void pic_color_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Rect_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void picbox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            y = e.Location; 
            cir_x = e.Location.X;
            cir_y = e.Location.Y;
            PicPannel.Cursor = Cursors.Cross;
        }

        private void picbox1_MouseUp(object sender, MouseEventArgs e)
        {
            paint= false;

            sqr_x = X - cir_x;
            sqr_y = Y - cir_y;

            if(index == 3)
            {
                g.DrawEllipse(pen, cir_x, cir_y, sqr_x, sqr_y);
                
            }
            if (index == 4)
            {
                g.DrawRectangle(pen, cir_x,cir_y, sqr_x, sqr_y);
            }
            if(index == 5)
            {
                g.DrawLine(pen, cir_x, cir_y,X,Y);
            }
            if (index == 8)
            {
                g.DrawArc(pen, X, Y, cir_x, cir_y, 50, 100);
            }
            if (index == 9)
            {
                g.DrawLine(pen1, 10, 100, 100, 50);
            }
            if (index == 10)
            {

                g.DrawEllipse(pen, cir_x, cir_y, sqr_x, sqr_y);
                g.DrawRectangle(pen, cir_x, cir_y, sqr_x, sqr_y);

            }
            PicPannel.Cursor = Cursors.Default;
        }

        private void btn_Circle_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btn_Line_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void picbox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (paint) { 
            if(index == 3)
            {
                g.DrawEllipse(pen, cir_x, cir_y, sqr_x, sqr_y);
                
            }
            if (index == 4)
            {
                g.DrawRectangle(pen, cir_x,cir_y, sqr_x, sqr_y);
            }
            if(index == 5)
            {
                g.DrawLine(pen, cir_x, cir_y,X,Y);
            }
            if (index == 8)
            {
                g.DrawArc(pen,new Rectangle(0,0,100,200),45,270);
            }
            if (index == 9)
            {
                g.DrawLine(pen1, 10, 100, 100, 50);
            }
            if (index == 10)
                {

                    g.DrawEllipse(pen, cir_x, cir_y, sqr_x, sqr_y);
                    g.DrawRectangle(pen, cir_x, cir_y, sqr_x, sqr_y);

                }
            }
        }

        private void btn_Arc_Click(object sender, EventArgs e)
        {
            index = 8;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            PicPannel.Image = bm;
            index = 0;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            PicColor.BackColor = cd.Color;
            pen.Color = cd.Color;
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
            new_color = cd.Color;
            
            PicColor.BackColor = new_color;
            
        }


  

        private void picbox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if(index == 1)
                {
                    x = e.Location;
                    g.DrawLine(pen, x, y);
                    y = x;
                }
                if (index == 2)
                {
                    x = e.Location;
                    g.DrawLine(erase, x, y);
                    y = x;
                }
                if (index == 9)
                {
                    x = e.Location;
                    g.DrawLine(pen1, x,y);
                    y = x;
                }

            }
            PicPannel.Refresh();
            X = e.X; Y = e.Y;
            sqr_x = e.X - cir_x;
            sqr_y = e.Y - cir_y;
        }

        private void btn_Pen_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void picbox1_MouseClick(object sender, MouseEventArgs e)
        {

            if (index == 7)
            {
                Point point = set_point(PicPannel, e.Location);
                fill(bm ,point.X, point.Y,new_color);
                

            }
        }
        static Point set_point(PictureBox pb,Point pt)
        {
            float px = 1f * pb.Width / pb.Width;
            float py = 1f * pb.Height / pb.Height;
            return new Point((int)(pt.X * px), (int)(pt.Y * py));
        }
       
        private void btn_Fill_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var save = new SaveFileDialog();
            save.Filter = "Image(*.jpg)|*.jpg|(*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, PicPannel.Width, PicPannel.Height), bm.PixelFormat);
                btm.Save(save.FileName, ImageFormat.Jpeg);
            }
        }

        private void PicPannel_Paint(object sender, PaintEventArgs e)
        {
            PicPannel.AllowDrop = true;
        }

        private void btn_Brush_Click(object sender, EventArgs e)
        {
            index = 9;
        }

        private void PicPannel_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);    
            if(data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                {
                    PicPannel.Image = Image.FromFile(fileNames[0]);
                }
                
            }
                    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PicPannel.AllowDrop = true;
        }

        private void PicPannel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var fileNames = data as string[];
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
             //   PicPannel.Image = Image.FromFile(fileNames[]);
                PicPannel.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void helpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("1. Make a Selection from Pannel \n 2. Click the icon \n 3. Choose Color \n 3. Hold your Mouse to draw any shape ", "Help", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {
                Close();
            }
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            PicPannel.Image = bm;
            index = 0;
        }

      

        private void PicColor_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            PicColor.BackColor = cd.Color;
            pen.Color = cd.Color;
        }

        private void bottomPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void shapeBtn_Click(object sender, EventArgs e)
        {
           index = 10;
        }
        
        private void btn_Erase_Click(object sender, EventArgs e)
        {
            index = 2;
        }
        private void validate(Bitmap bm , Stack<Point>sp,int X,int Y , Color old_color, Color new_color)
        {
            Color cir_x = bm.GetPixel(X, Y);
            if(cir_x == old_color)
            {
                sp.Push(new Point(X,Y));
                bm.SetPixel(X,Y,new_color);
            }
        }
        public void fill(Bitmap bm,int X,int Y,Color new_color)
        {
            Color old_color = bm.GetPixel(X,Y); 
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(X, Y));
            bm.SetPixel(X,Y, new_color);
            if (old_color == new_color)
                return;
            while (pixel.Count > 0)
            {
               Point pt = (Point)pixel.Pop();
                if(pt.X>0 && pt.Y>0 && pt.X<bm.Width-1 && pt.Y < bm.Height - 1)
                {
                    validate(bm,pixel,pt.X-1,pt.Y,old_color,new_color);
                    validate(bm, pixel, pt.X, pt.Y-1, old_color, new_color);
                    validate(bm, pixel, pt.X + 1, pt.Y, old_color, new_color);
                    validate(bm, pixel, pt.X, pt.Y+1, old_color, new_color);
                }
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
