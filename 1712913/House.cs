using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1712913
{
    class House : Shape
    {
        int centerPointX, centerPointY, width, height;
        public House(int centerPointX, int centerPointY, int width, int height)
        {
            this.centerPointX = centerPointX;
            this.centerPointY = centerPointY;
            this.width = width;
            this.height = height;
        }
        public override void draw(myGraphic graphic)
        {
            graphic.drawHouse(centerPointX, centerPointY, width, height);
        }
    }
}
