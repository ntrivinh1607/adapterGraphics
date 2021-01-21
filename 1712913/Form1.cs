using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace _1712913
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            House house = new House(100, 100, 100, 100);
            Star star = new Star(200, 100, 50, 20);
            //choose graphics
            myGraphic gdiGraphic = new GdiPlusGraphic(e);
            //myGraphic cairoGraphic = new CairoContext(e);

            star.draw(gdiGraphic);
            house.draw(gdiGraphic);

            //house.draw(cairoGraphic);
            //star.draw(cairoGraphic);
            //cairoGraphic.dispose();
        }
    }
}
