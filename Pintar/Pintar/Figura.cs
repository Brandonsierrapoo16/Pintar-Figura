﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    abstract class Figura
    {
        public int X , Y;
        public Pen pluma;
        public Brush brocha;
        public int ancho, largo;

        public Figura(int x, int y)
        {
            X = x;
            Y = y;
            pluma = new Pen (Color.Red,2);
            ancho = 50;
            largo = 50;
        
        }

        public abstract void Dibuja (Form f);

    }

    class Rectangulo : Figura
    {
        public Rectangulo(int x, int y)
            : base(x, y)
        {

        }
        public override void Dibuja(Form f)
        {
            Graphics g = f.CreateGraphics();
        }

    }

    class Circulo : Figura
    {
        public Circulo(int x, int y)
            : base(x, y)
    {

    }
        public override void  Dibuja(Form f)
{
 	Graphics g = f.CreateGraphics();
}

    }

    

      
}
