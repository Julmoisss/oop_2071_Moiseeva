using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace oop_zadanie_2
{
    class Circle : Figure
    {
        int radius;
        Pen penR;
        public Circle(Pen penR, int x, int y, int radius)
        {
            this.penR = penR;
            this.x = x;
            this.y = y;
            this.radius = radius;
            this.radius = radius;
        }
        public override void Draw(Graphics gr)
        {
            Rectangle rect = new Rectangle(x, y, radius, radius);
            gr.DrawEllipse(penR, rect);
        }
    }
}
