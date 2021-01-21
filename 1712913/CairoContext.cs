using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cairo;

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
            int[,] points = { { 0 + centerPointX, 85 + centerPointY }, { 75 + centerPointX, 75 + centerPointY }, { 100 + centerPointX, 10 + centerPointY },
                            { 125 + centerPointX, 75 + centerPointY }, { 200 + centerPointX, 85 + centerPointY }, { 150 + centerPointX, 125 + centerPointY }, 
                            { 160 + centerPointX, 190 + centerPointY }, { 100 + centerPointX, 150 + centerPointY }, { 40 + centerPointX, 190 + centerPointY },
                            { 50 + centerPointX, 125 + centerPointY }, { 0 + centerPointX, 85 + centerPointY } };

            Context1.SetSourceRGB(0.9, 0.0, 0.0);
            int i;
            for (i = 0; i < 10; i++) {
                Context1.LineTo(points[i, 0], points[i, 1]);
            }
            Context1.ClosePath();
            Context1.StrokePreserve();
            //Context1.Fill();
        }

        public override void drawHouse(int centerPointX, int centerPointY, int width, int height)
        {
            Context1.SetSourceRGB(0.9, 0.0, 0.0);
            Context1.Rectangle(centerPointX - width/2, centerPointY - height/2, width, height);
            Context1.MoveTo(centerPointX - width / 1.2, centerPointY - height / 2);
            Context1.LineTo(centerPointX + width / 1.2, centerPointY - height / 2);
            Context1.LineTo(centerPointX, centerPointY - height);
            Context1.ClosePath();
            Context1.Stroke();
        }
        public override void dispose()
        {
            Graphics1.Dispose();
            Context1.Dispose();
            Surface1.Dispose();
        }
    }
}
