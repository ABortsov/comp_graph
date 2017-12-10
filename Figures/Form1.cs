using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Figures
{
    public partial class Form1 : Form
    {
        Matrix M = new Matrix();
        Object obj;
        Points[] points;
        Side[] sides;
        public Form1()
        {
            InitializeComponent();
            StreamReader Working_file = new StreamReader("U://file.txt");
            int Count_points = Convert.ToInt32(Working_file.ReadLine());
            string[] coordinatesSTR = new string[Count_points];
            //считывание координат в массив строк
            for (int i = 0; i < Count_points; i++)
            {
                coordinatesSTR[i] = Working_file.ReadLine();
            }
            //разделение строк на отдельные координаты
            string[,] Arr_coordinates = new string[Count_points,4];
            string[] coordinates_tmp = new string[4];
            for (int i = 0; i < Count_points; i++)
            {
                coordinates_tmp = coordinatesSTR[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for ( int j = 0; j < 4; j++)
                {
                    Arr_coordinates[i, j] = coordinates_tmp[j];
                }
            }
            // Заполнение массива точек и установление координат
            points = new Points[Count_points];
            for (int i = 0; i < Count_points; i++)
            {
                points[i] = new Points();
                points[i].x = float.Parse(Arr_coordinates[i, 0]);
                points[i].y = float.Parse(Arr_coordinates[i, 1]);
                points[i].z = float.Parse(Arr_coordinates[i, 2]);                
                points[i].h = float.Parse(Arr_coordinates[i, 3]);
            }
            // Установление связей между точек
            int Count_sides = Convert.ToInt32(Working_file.ReadLine());
            int max_line_segment = Convert.ToInt32(Working_file.ReadLine());
            int[] Arr_link = new int[max_line_segment];
            string[] linkSTR = new string[Count_sides];
            for (int i = 0; i < Count_sides; i++)
            {
                linkSTR[i] = Working_file.ReadLine();
            }
            // Заполнение массива связей точек
            sides = new Side[Count_sides];
            for (int i = 0; i < Count_sides; i++)
            {
                coordinates_tmp = linkSTR[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < coordinates_tmp.Length - 1; j++)
                    Arr_link[j] = Convert.ToInt32(coordinates_tmp[j]);
                sides[i] = new Side(points,Arr_link,coordinates_tmp[coordinates_tmp.Length - 1]);
            }
            obj = new Object(Count_sides,sides,points);
            obj.Draw(this);
        }

        private void buttonRX_Click(object sender, EventArgs e)
        {
            M.init();
            float angle = 0;
                angle = float.Parse(textRX.Text);
            M.RotateOnOX(angle);
            obj.Object_x_Matrix(M);
            obj.Draw(this);

        }

        private void buttonShift_Click(object sender, EventArgs e)
        {
            M.init();
            M.M[1, 0] = - float.Parse(textSH.Text);
            obj.Object_x_Matrix(M);
            obj.Draw(this);
        }

        private void buttonRY_Click(object sender, EventArgs e)
        {
            M.init();
            float angle = 0;
            angle = float.Parse(textRY.Text);
            M.RotateOnOY(angle);
            obj.Object_x_Matrix(M);
            obj.Draw(this);
        }

        private void buttonRZ_Click(object sender, EventArgs e)
        {
            M.init();
            float angle = 0;
            angle = float.Parse(textRZ.Text);
            M.RotateOnOZ(angle);
            obj.Object_x_Matrix(M);
            obj.Draw(this);
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            M.init();
            M.transfer(float.Parse(textMX.Text), float.Parse(textMY.Text), float.Parse(textMZ.Text));
            obj.Object_x_Matrix(M);
            obj.Draw(this);
            
        }

        private void buttonSC_Click(object sender, EventArgs e)
        {
            M.init();
            M.Scale(float.Parse(textSC.Text));
            obj.Object_x_Matrix(M);
            obj.Draw(this);
        }

        private void buttonWR_Click(object sender, EventArgs e)
        {
            float sc_h, sc_w;
            float x, y;
            float max_x = 0, max_y = 0, min_x = 0, min_y = 0;
            float hei = 0;
            float wid = 0;
            max_x = obj.sides[0].p[0].x;
            min_x = obj.sides[0].p[0].x;
            max_y = obj.sides[0].p[0].y;
            min_y = obj.sides[0].p[0].y;
            for (int i = 0; i < obj.sides.Length; i++)
            {
                for (int j = 1; j < obj.sides[i].p.Length; j++)
                {
                    if (obj.sides[i].p[j].x > max_x)
                        max_x = obj.sides[i].p[j].x;
                    if (obj.sides[i].p[j].x < min_x)
                        min_x = obj.sides[i].p[j].x;
                    if (obj.sides[i].p[j].y > max_y)
                        max_y = obj.sides[i].p[j].y;
                    if (obj.sides[i].p[j].y < min_y)
                        min_y = obj.sides[i].p[j].y;
                }
            }
            x = (max_x + min_x) / 2;
            y = (max_y + min_y) / 2;
            hei = Math.Abs(max_y - min_y);
            wid = Math.Abs(max_x - min_x);
            M.init();
            M.transfer(-x, -y, 0);
            obj.Object_x_Matrix(M);
            sc_h = picture.Height / hei / (float)1.1;
            sc_w = picture.Width / wid / (float)1.1;
            M.init();
            if (sc_h < sc_w)
            {
                M.Scale(sc_h);
            }
            else
            {
                M.Scale(sc_w);
            }
            obj.Object_x_Matrix(M);
            obj.Draw(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void buttonSPPT_Click(object sender, EventArgs e)
        {
            M.init();
            M.M[2, 3] = (float)1.0/float.Parse(textSPPT.Text);
            obj.Object_x_Matrix(M);
            for ( int i = 0; i < obj.sides.Length; i++)
            {
                for (int j = 0; j < obj.sides[i].p.Length; j++)
                {
                    obj.sides[i].p[j].x = obj.sides[i].p[j].x / obj.sides[i].p[j].h;
                    obj.sides[i].p[j].y = obj.sides[i].p[j].y / obj.sides[i].p[j].h;
                    obj.sides[i].p[j].z = obj.sides[i].p[j].z / obj.sides[i].p[j].h;
                    obj.sides[i].p[j].h = obj.sides[i].p[j].h / obj.sides[i].p[j].h;
                }
            }
            obj.Draw(this);
        }

        private void buttonRet_Click(object sender, EventArgs e)
        {
            obj = new Object(sides.Length,sides,points);
            obj.Draw(this);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
