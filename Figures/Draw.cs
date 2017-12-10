using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Figures
{
    class Draw
    {
        public void Drawing(Form1 f, Object objct)
        {
            
            Bitmap bmp = new Bitmap(f.picture.Width,f.picture.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            Points axis = new Points();
            axis.x = bmp.Width / 2;
            axis.y = bmp.Height / 2;
            axis.z = 0;
            // рисование осей координат
            graph.DrawLine(pen, 0, bmp.Height / 2, bmp.Width, bmp.Height / 2);
            graph.DrawLine(pen, bmp.Width / 2, 0, bmp.Width / 2, bmp.Height);
            // рисование фигуры
            pen.Width = 2;
            for ( int i = 0; i < objct.count_p_link; i++)
            { 
                for (int j = 1; j < objct.max_link; j++)
                {
                    if (objct.link_p[i,j] - 1 >= 0)
                    {
                        graph.DrawLine(pen, axis.x + objct.p[objct.link_p[i,0] - 1].x, axis.y - objct.p[objct.link_p[i, 0] - 1].y, axis.x + objct.p[objct.link_p[i,j] - 1].x, axis.y - objct.p[objct.link_p[i, j] - 1].y);
                    }
                }
            }
            f.picture.Image = bmp;
        }
    }
}
