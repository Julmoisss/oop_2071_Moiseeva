using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace oop_zadanie_2
{
    class Rectangles : Figure
    {
        int width, height;
        Random rnd;
        Pen pen;
        public Rectangles(int height, int width, int x, int y, Pen pen)
        {
            this.height = height;
            this.width = width;
            this.pen = pen;
            this.x = x;
            this.y = y;
        }
        public override void Draw(Graphics gr)
        {
            gr.DrawRectangle(pen, x, y, width, height);
        }
        List<Rectangle> rects = new List<Rectangle>();
    }
}
