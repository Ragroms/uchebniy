using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace прак_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            SolidBrush brush = new SolidBrush(Color.Black);
            HatchBrush hatchBrush = new HatchBrush(HatchStyle.DiagonalCross, Color.Green);
            g.FillRectangle(hatchBrush, 100, 50, 40, 50);
            g.DrawRectangle(new Pen(Color.Green), 115, 100, 11, 16);
            g.DrawRectangle(new Pen(Color.Green), 100, 126, 40, 40);
            g.DrawLine(new Pen(Color.Purple), 115, 50, 100, 30);
            g.DrawLine(new Pen(Color.Purple), 118, 50, 140, 30);
            g.DrawLine(new Pen(Color.Purple), 118, 50, 103, 30);
            g.DrawLine(new Pen(Color.Purple), 120, 50, 143, 30);
            g.DrawLine(new Pen(Color.Purple), 100, 30, 103, 30);
            g.DrawLine(new Pen(Color.Purple), 140, 30, 143, 30);
            g.FillEllipse(new SolidBrush(Color.White), 105, 58, 13, 10);
            g.FillEllipse(new SolidBrush(Color.White), 122, 58, 13, 10);
            g.FillEllipse(new SolidBrush(Color.Gray), 109, 60, 6, 5);
            g.FillEllipse(new SolidBrush(Color.Gray), 125, 60, 7, 6);
            g.FillEllipse(new SolidBrush(Color.Gray), 111, 85, 19, 5);
            hatchBrush = new HatchBrush(HatchStyle.DiagonalCross, Color.Green);
            g.FillRectangle(hatchBrush, 80, 116, 80, 70);
            g.DrawRectangle(new Pen(Color.Green), 50, 120, 30, 12);
            g.DrawRectangle(new Pen(Color.Green), 160, 120, 30, 12);
            g.DrawRectangle(new Pen(Color.Green), 98, 186, 17, 74);
            g.DrawRectangle(new Pen(Color.Green), 126, 186, 17, 74);
            g.FillRectangle(hatchBrush, 98, 126, 46, 46);
            g.DrawRectangle(new Pen(Color.Green), 91, 260, 24, 10);
            g.DrawRectangle(new Pen(Color.Green), 126, 260, 24, 10);
            g.DrawLine(new Pen(Color.Green), 50, 120, 20, 170);
            g.DrawLine(new Pen(Color.Green), 50, 130, 28, 170);
            g.DrawLine(new Pen(Color.Green), 190, 120, 210, 70);
            g.DrawLine(new Pen(Color.Green), 190, 130, 220, 70);
            g.FillEllipse(new SolidBrush(Color.Red), 20, 160, 20, 20);
            g.FillEllipse(new SolidBrush(Color.Blue), 205, 65, 20, 20);
        }
    }
}
