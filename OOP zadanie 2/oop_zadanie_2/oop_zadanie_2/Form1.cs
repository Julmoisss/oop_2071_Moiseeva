using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace oop_zadanie_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics gr;
        Pen pen = new Pen(Color.Red, 4);
        Pen penR = new Pen(Color.DarkBlue, 4);
        Random rnd = new Random();
        int height, width, x, y, radius;
        Rectangles rect;

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
            figs.Clear();
        }
        Circle c;
        Van van;
        List<Rectangle> rects = new List<Rectangle>();
        List<Figure> figs = new List<Figure>();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach(Rectangle rect in rects)
            {

            }

            foreach (Figure figure in figs)
            {
                figure.Draw(panel1.CreateGraphics());
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            height = e.Y - y;
            width = e.X - x;

            gr = panel1.CreateGraphics();

            if (radioButton1.Checked == true)
            {
                radius = Convert.ToInt32(width*0.5);
                c = new Circle(penR, x, y, radius);
                figs.Add(c);
            }

            if (radioButton2.Checked == true)
            {
                rect = new Rectangles(height, width, x, y, pen);
                figs.Add(rect);
            }

            if (radioButton3.Checked == true)
            {
                van = new Van(height, width, x, y, pen, penR);
                figs.Add(van);
            }
            panel1.Refresh();
        }
    }
}
