using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

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
            myGraphic graphic = new GdiPlusGraphic(e);
            Star star = new Star(50, 100, 50, 20);
            star.draw(graphic);

            //myGraphic graphic1 = new CairoContext(e);
            //House house = new House();
            //house.draw(graphic1);
        }
    }
}
