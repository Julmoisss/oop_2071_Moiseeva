using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace oop_zadanie_2
{
    class Van : Figure
    {
        Circle c, c2;
        Rectangles rect; 

        public Van(int height, int width, int x, int y, Pen pen, Pen penR)
        {

            rect = new Rectangles(height, width, x, y, pen);
            c = new Circle(penR, Convert.ToInt32(0.2 * width) + x, (y + height), Convert.ToInt32(0.1 * width));
            c2 = new Circle(penR, (x + Convert.ToInt32(width*0.7)), (y + height), Convert.ToInt32(0.1 * width));
        }
        public override void Draw(Graphics gr)
        {
            rect.Draw(gr);
            c.Draw(gr);
            c2.Draw(gr);
        }
    }
}
