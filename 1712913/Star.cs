using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1712913
{
    class Star : Shape
    {
        int centerPointX, centerPointY, outerRadius, innerRadius;
        public Star(int centerPointX, int centerPointY, int outerRadius, int innerRadius)
        {
            this.centerPointX = centerPointX;
            this.centerPointY = centerPointY;
            this.outerRadius = outerRadius;
            this.innerRadius = innerRadius;
        }
        public override void draw(myGraphic graphic)
        {
            graphic.drawStar(centerPointX, centerPointY, outerRadius, innerRadius);
        }
    }
}
