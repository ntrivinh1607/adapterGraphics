using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cairo;
using Gtk;

namespace _1712913
{
    class CairoContext : myGraphic
    {
        public System.Drawing.Graphics Graphics1 { get; private set; }
        public Context Context1 { get; set; }
        public Win32Surface Surface1 { get; private set; }

        public CairoContext(System.Windows.Forms.PaintEventArgs e) : base(e)
        {
            Graphics1 = e.Graphics;
            Surface1 = new Win32Surface(Graphics1.GetHdc());
            Context1 = new Context(Surface1);
        }
        public override void drawStar(int centerPointX, int centerPointY, int outerRadius, int innerRadius)
        {
            
        }

        public override void drawHouse()
        {
            Context1.Rectangle(30, 50, 100, 100);
            Context1.Color = new Cairo.Color(0.9, 0.0, 0.0);

            //Context1.SetSourceRGBA(5, 5, 100, 100);
            Context1.Stroke();
            dispose();
        }
        private void dispose()
        {
            Graphics1.Dispose();
            Context1.Dispose();
            Surface1.Dispose();
        }
    }
}
