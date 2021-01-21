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
        public abstract void drawStar(int centerPointX, int centerPointY, int innerRadius, int outterRadius);

        public abstract void drawHouse(int centerPointX, int centerPointY, int width, int height);

        public abstract void dispose();
    }
}
