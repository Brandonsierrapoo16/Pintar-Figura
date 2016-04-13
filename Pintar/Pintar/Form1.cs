using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        enum TipoFigura { Rectangulo, Circulo };
        private TipoFigura figura_actual;

        List<Figura> figuras;

        public Form1()
        {
            figura_actual = TipoFigura.Circulo;
            
            figuras = new List<Figura>();
            InitializeComponent();

            circuloToolStripMenuItem.Checked = true;

        }

       

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this, e.X, e.Y);

            }

           


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figura f in figuras)
            {
                f.Dibuja(this);
            }
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.rectanguloToolStripMenuItem.Checked = true;
        }
    }
}
