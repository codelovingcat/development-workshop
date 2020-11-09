using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_graphic_operations
{
    public partial class Graphic : Form
    {
        public Graphic()
        {
            InitializeComponent();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            float tea, hazelnut, egypt ,total;
            tea = int.Parse(textTea.Text);
            hazelnut = int.Parse(textHazelnut.Text);
            egypt = int.Parse(textEgypt.Text);

            total = tea + hazelnut + egypt;

            float ptea, phazelnut, pegypt;
            ptea = (tea / total) * 360;
            phazelnut = (hazelnut / total) * 360;
            pegypt = (egypt / total) * 360;

            Pen pen = new Pen(Color.White,1);
            Graphics graphics = this.CreateGraphics();

            Rectangle r = new Rectangle( textTea.Location.X + textTea.Size.Width + 10, 10, 250, 260 );
            
            Brush brush1 = new SolidBrush(Color.Black);
            Brush brush2 = new SolidBrush(Color.White);
            Brush brush3 = new SolidBrush(Color.Red);

            graphics.Clear(Graphic.DefaultBackColor);
            graphics.DrawPie(pen, r, 0, ptea);
            graphics.FillPie(brush1, r, 0, ptea);
            graphics.DrawPie(pen, r, ptea, phazelnut);
            graphics.FillPie(brush2, r, ptea, phazelnut);
            graphics.DrawPie(pen, r, ptea + phazelnut, pegypt);
            graphics.FillPie(brush3, r, ptea + phazelnut, pegypt);
        }
    }
}
