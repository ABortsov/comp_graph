using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Matrix
    {
        public float[,] M = new float[4, 4];
        public void init()
        {
            for ( int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    if (i == j)
                        M[i, j] = 1;
                    else
                        M[i, j] = 0;
                }
        }

        public void transfer(float x, float y, float z)
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    if (i == j)
                        M[i, j] = 1;
                    else
                        M[i, j] = 0;
                }
            M[3, 0] = x;
            M[3, 1] = y;
            M[3, 2] = z;
        }

        public void RotateOnOX(float angle)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j)
                        M[i, j] = 1;
                    else
                        M[i, j] = 0;
                }
            }
            angle = angle * (float)Math.PI / 180;
            M[1, 1] = (float)Math.Cos(angle);
            M[1, 2] = (float)Math.Sin(angle);
            M[2, 1] = (float)-Math.Sin(angle);
            M[2, 2] = (float)Math.Cos(angle);
        }

        public void RotateOnOY(float angle)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j)
                        M[i, j] = 1;
                    else
                        M[i, j] = 0;
                }
            }
            angle = angle * (float)Math.PI / 180;
            M[0, 0] = (float)Math.Cos(angle);
            M[2, 0] = (float)-Math.Sin(angle);
            M[0, 2] = (float)Math.Sin(angle);
            M[2, 2] = (float)Math.Cos(angle);
        }

        public void RotateOnOZ(float angle)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j)
                        M[i, j] = 1;
                    else
                        M[i, j] = 0;
                }
            }
            angle = angle * (float)Math.PI / 180;
            M[0, 0] = (float)Math.Cos(angle);
            M[0, 1] = (float)-Math.Sin(angle);
            M[1, 0] = (float)Math.Sin(angle);
            M[1, 1] = (float)Math.Cos(angle);
        }

        public void Scale(float size)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j)
                        M[i, j] = size;
                    else
                        M[i, j] = 0;
                }
            }
            M[3, 3] = 1;
        }
    }
}
