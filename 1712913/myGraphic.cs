using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace _1712913
{
    abstract class myGraphic
    {
        protected System.Windows.Forms.PaintEventArgs e;

        public myGraphic(System.Windows.Forms.PaintEventArgs e)
        {
            this.e = e;
        }
        public abstract void drawStar(int x, int y, int z, int t);

        public abstract void drawHouse();
    }
}
