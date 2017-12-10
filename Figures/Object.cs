using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures
{
    class Object
    {
        public Side[] sides;
        public Points[] p;
        private float scal (Vec a, Vec b)
        {
            return (a.x * b.x + a.y * b.y + a.z * b.z);
        }
        private float lenOV(Vec c)
        {
            return (float)Math.Sqrt(c.x * c.x + c.y * c.y + c.z * c.z);
        }
        public Object(int count, Side[] s, Points[] points_all)
        {
            p = new Points[points_all.Length];
            for (int i = 0; i < points_all.Length; i++)
            {
                p[i] = new Points();
                p[i].x = points_all[i].x;
                p[i].y = points_all[i].y;
                p[i].z = points_all[i].z;
                p[i].h = points_all[i].h;
            }
            sides = new Side[count];
            for (int i = 0; i < count; i++)
            {
                sides[i] = new Side();
                sides[i].color = s[i].color;
                sides[i].p = new Points[s[i].p.Length];
                for (int j = 0; j < s[i].p.Length; j++)
                {
                    sides[i].p[j] = new Points();
                    sides[i].p[j].x = s[i].p[j].x;
                    sides[i].p[j].y = s[i].p[j].y;
                    sides[i].p[j].z = s[i].p[j].z;
                    sides[i].p[j].h = s[i].p[j].h;
                }
                sides[i].normal.x = s[i].normal.x;
                sides[i].normal.y = s[i].normal.y;
                sides[i].normal.z = s[i].normal.z;
                sides[i].normal.h = s[i].normal.h;
            }
        }
        public void Object_x_Matrix(Matrix M)
        {
            for (int i = 0; i < sides.Length; i++)
                sides[i].Side_On_Matrix(M);
            Points p_tmp = new Points();
            for (int i = 0; i < p.Length; i++)
            {
                p_tmp.x = p[i].x;
                p_tmp.y = p[i].y;
                p_tmp.z = p[i].z;
                p_tmp.h = p[i].h;
                p[i].x = p_tmp.x * M.M[0, 0] + p_tmp.y * M.M[1, 0] + p_tmp.z * M.M[2, 0] + p_tmp.h * M.M[3, 0];
                p[i].y = p_tmp.x * M.M[0, 1] + p_tmp.y * M.M[1, 1] + p_tmp.z * M.M[2, 1] + p_tmp.h * M.M[3, 1];
                p[i].z = p_tmp.x * M.M[0, 2] + p_tmp.y * M.M[1, 2] + p_tmp.z * M.M[2, 2] + p_tmp.h * M.M[3, 2];
                p[i].h = p_tmp.x * M.M[0, 3] + p_tmp.y * M.M[1, 3] + p_tmp.z * M.M[2, 3] + p_tmp.h * M.M[3, 3];
            }
        }
        public void Draw(Form1 f)
        {
            Points center = new Points();
            Points vector = new Points();
            float cos;
            Points center_side = new Points();
            Points tmp_p = new Points();
            Bitmap bmp = new Bitmap(f.picture.Width, f.picture.Height);
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
            center.x = 0;
            center.y = 0;
            center.z = 0;
            center_side.x = 0;
            center_side.y = 0;
            center_side.z = 0;
            for (int i = 0; i < p.Length; i++)
            {
                center.x += p[i].x;
                center.y += p[i].y;
                center.z += p[i].z;
            }
            center.x = center.x / p.Length;
            center.y = center.y / p.Length;
            center.z = center.z / p.Length;
            PointF[] pf;
            // Roberts algorithm
            if (f.checkBox1.Checked == true)
            {
                for (int i = 0; i < sides.Length; i++)
                {
                    center_side.x = 0;
                    center_side.y = 0;
                    center_side.z = 0;
                    for (int j = 0; j < sides[i].p.Length; j++)
                    {
                        center_side.x += sides[i].p[j].x;
                        center_side.y += sides[i].p[j].y;
                        center_side.z += sides[i].p[j].z;
                    }
                    center_side.x = center_side.x / sides[i].p.Length;
                    center_side.y = center_side.y / sides[i].p.Length;
                    center_side.z = center_side.z / sides[i].p.Length;
                    vector.x = center.x - center_side.x;
                    vector.y = center.y - center_side.y;
                    vector.z = center.z - center_side.z;
                    cos = vector.x * sides[i].normal.x + vector.y * sides[i].normal.y + vector.z * sides[i].normal.z;
                    if (cos > 0)
                    {
                        sides[i].normal.x *= -1;
                        sides[i].normal.y *= -1;
                        sides[i].normal.z *= -1;
                    }
                    cos = sides[i].normal.z * (-1);
                    if (cos < 0)
                    {
                        for (int j = 0; j < sides[i].p.Length - 1; j++)
                        {
                            pf = new PointF[sides[i].p.Length];
                            for (int n = 0; n < pf.Length; n++)
                            {
                                pf[n] = new PointF();
                                pf[n].X = sides[i].p[n].x + axis.x;
                                pf[n].Y = sides[i].p[n].y + axis.y;
                            }
                            Color color = Color.FromName(sides[i].color);
                            SolidBrush sb = new SolidBrush(color);
                            graph.FillPolygon(sb, pf);
                        }
                    }
                }
            }
            //z-buffer
            else if (f.checkBox2.Checked == true)
            {
                float[] z_buf = new float[f.picture.Width];
                Color[,] f_buf = new Color[f.picture.Height, f.picture.Width];
                float D;
                float z;
                int Ymax = Int32.MinValue, Ymin = Int32.MaxValue;
                // создание фона и системы координат
                for (int j = 0; j < f.picture.Width; j++)
                {
                    for (int i = 0; i < f.picture.Height; i++)
                    {
                        if ((j == (int)(f.picture.Width / 2)) || (i == (int)(f.picture.Height / 2)))
                            f_buf[i, j] = Color.Black;
                        else
                            f_buf[i, j] = f.picture.BackColor;
                        bmp.SetPixel(j, i, f_buf[i, j]);
                    }
                }
                //find min and max value
                for (int i = 0; i < sides.Length; i++)
                {
                    for (int j = 0; j < sides[i].p.Length; j++)
                    {
                        if (Ymin > sides[i].p[j].y)
                            Ymin = (int)Math.Round(sides[i].p[j].y);
                        if (Ymax < sides[i].p[j].y)
                            Ymax = (int)Math.Round(sides[i].p[j].y);
                    }
                }
                for (int y = Ymin; y <= Ymax; y++)
                    if (!((f.picture.Height / 2 + y <= 0) || (f.picture.Height / 2 + y >= f.picture.Height)))
                    {
                        for (int j = 0; j < f.picture.Width; j++)
                            z_buf[j] = Int32.MinValue;
                        for (int i = 0; i < sides.Length; i++)
                        {
                            D = -(sides[i].normal.x * sides[i].p[0].x + sides[i].normal.y * sides[i].p[0].y + sides[i].normal.z * sides[i].p[0].z);
                            int[] x = new int[sides[i].p.Length];
                            int k = 0;
                            //find the point of intersection
                            for (int j = 1; j < sides[i].p.Length - 1; j++)
                            {
                                if (sides[i].p[j].y < y)
                                {
                                    if (sides[i].p[j + 1].y > y)
                                    {
                                        x[k] = (int)Math.Round((sides[i].p[j].x - sides[i].p[j + 1].x) * (y - sides[i].p[j + 1].y) / (sides[i].p[j].y - sides[i].p[j + 1].y) + sides[i].p[j + 1].x);
                                        k++;
                                    }
                                }
                                else if (sides[i].p[j].y > y)
                                {
                                    if (sides[i].p[j + 1].y < y)
                                    {
                                        x[k] = (int)Math.Round((sides[i].p[j].x - sides[i].p[j + 1].x) * (y - sides[i].p[j + 1].y) / (sides[i].p[j].y - sides[i].p[j + 1].y) + sides[i].p[j + 1].x);
                                        k++;
                                    }
                                }
                                else if (sides[i].p[j].y == y)
                                {
                                    if (((sides[i].p[j - 1].y > y) && (sides[i].p[j + 1].y < y)) || ((sides[i].p[j + 1].y > y) && (sides[i].p[j - 1].y < y)))
                                    {
                                        x[k] = (int)sides[i].p[j].x;
                                        k++;
                                    }
                                }
                            }
                            if (((sides[i].p[0].y > y) && (sides[i].p[1].y < y)) || ((sides[i].p[1].y > y) && (sides[i].p[0].y < y)))
                            {
                                x[k] = (int)Math.Round((sides[i].p[0].x - sides[i].p[1].x) * (y - sides[i].p[1].y) / (sides[i].p[0].y - sides[i].p[1].y) + sides[i].p[1].x);
                                k++;
                            }
                            if (sides[i].p[0].y == y)
                            {
                                if (((sides[i].p[sides[i].p.Length - 1].y > y) && (sides[i].p[1].y < y)) || ((sides[i].p[1].y > y) && (sides[i].p[sides[i].p.Length - 1].y < y)))
                                {
                                    x[k] = (int)sides[i].p[0].x;
                                    k++;
                                }
                            }
                            if (((sides[i].p[0].y > y) && (sides[i].p[sides[i].p.Length - 1].y < y)) || ((sides[i].p[sides[i].p.Length - 1].y > y) && (sides[i].p[0].y < y)))
                            {
                                x[k] = (int)Math.Round((sides[i].p[0].x - sides[i].p[sides[i].p.Length - 1].x) * (y - sides[i].p[sides[i].p.Length - 1].y) / (sides[i].p[0].y - sides[i].p[sides[i].p.Length - 1].y) + sides[i].p[sides[i].p.Length - 1].x);
                                k++;
                            }
                            if (sides[i].p[sides[i].p.Length - 1].y == y)
                            {
                                if (((sides[i].p[0].y > y) && (sides[i].p[sides[i].p.Length - 2].y < y)) || ((sides[i].p[sides[i].p.Length - 2].y > y) && (sides[i].p[0].y < y)))
                                {
                                    x[k] = (int)sides[i].p[sides[i].p.Length - 1].x;
                                    k++;
                                }
                            }
                            //sorting
                            for (int j = 0; j < k - 1; j++)
                            {
                                for (int jj = j + 1; jj < k; jj++)
                                {
                                    if (x[j] > x[jj])
                                    {
                                        int tmp_x = x[j];
                                        x[j] = x[jj];
                                        x[jj] = tmp_x;
                                    }
                                }
                            }
                            Vec FallA = new Vec(0, 0, -1);
                            Vec FallB = new Vec(-sides[i].normal.x, -sides[i].normal.y, -sides[i].normal.z);

                            Vec s = new Vec(FallA, FallB);
                            float cos0 = scal(FallA, FallB) / (lenOV(FallA) * lenOV(FallB));
                            float cosB = scal(FallA, s) / (lenOV(FallA) * lenOV(s));

                            for (int j = 0; j < k; j += 2)
                            {
                                for (int x_w = x[j]; x_w <= x[j + 1]; x_w++)
                                    if (!((x_w + f.picture.Width / 2 <= 0) || (x_w + f.picture.Width / 2 >= f.picture.Width)))
                                    {
                                        z = -(sides[i].normal.x * x_w + sides[i].normal.y * y + D) / sides[i].normal.z;
                                        if (z > z_buf[x_w + (int)(f.picture.Width / 2)])
                                        {
                                            z_buf[x_w + (int)(f.picture.Width / 2)] = z;                                            
                                            f_buf[y + (int)(f.picture.Height / 2), x_w + (int)(f.picture.Width / 2)] = Color.FromName(sides[i].color);
                                            float id = f_buf[y + (int)(f.picture.Height / 2), x_w + (int)(f.picture.Width / 2)].G * float.Parse(f.dif.Text) * cos0;
                                            float im = f_buf[y + (int)(f.picture.Height / 2), x_w + (int)(f.picture.Width / 2)].G * float.Parse(f.mir.Text) * (float)Math.Pow(cosB, float.Parse(f.deg.Text));
                                            int I = (int)(Math.Abs(id) + Math.Abs(im));
                                            if (I > 255)
                                                I = 255;
                                            f_buf[y + (int)(f.picture.Height / 2), x_w + (int)(f.picture.Width / 2)] = Color.FromArgb(0, I, 0);
                                        }
                                    }
                            }
                        }
                    }
                for (int j = 0; j < f.picture.Width; j++)
                {
                    for (int i = 0; i < f.picture.Height; i++)
                    {
                        bmp.SetPixel(j, i, f_buf[i, j]);
                    }
                }
            }
            else
                for (int i = 0; i < sides.Length; i++)
                {
                    for (int j = 0; j < sides[i].p.Length; j++)
                    {
                        pf = new PointF[sides[i].p.Length];
                        for (int n = 0; n < pf.Length; n++)
                        {
                            pf[n] = new PointF();
                            pf[n].X = sides[i].p[n].x + axis.x;
                            pf[n].Y = sides[i].p[n].y + axis.y;
                        }
                        Color color = Color.FromName(sides[i].color);
                        SolidBrush sb = new SolidBrush(color);
                        graph.FillPolygon(sb, pf);
                    }
                }
            f.picture.Image = bmp;
        }
    }
}
