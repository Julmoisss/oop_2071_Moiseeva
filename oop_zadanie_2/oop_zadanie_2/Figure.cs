using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace oop_zadanie_2
{
    abstract class Figure
    {
        protected int x, y;

        public abstract void Draw(Graphics gr);
    }
}
