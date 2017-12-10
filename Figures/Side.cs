using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Figures
{
    class Side
    {
        public Points[] p;
        public Points normal = new Points();
        public string color;
        public Side()
        {
        }
        public Side(Points[] poin, int[] points_on_side, string col)
        {
            Points[] points_like_vektor = new Points[2];
            p = new Points[points_on_side.Length];
            color = col;
            for (int i = 0; i < points_on_side.Length; i++)
            {
                p[i] = new Points();
                p[i].x = poin[points_on_side[i] - 1].x;
                p[i].y = poin[points_on_side[i] - 1].y;
                p[i].z = poin[points_on_side[i] - 1].z;
                p[i].h = poin[points_on_side[i] - 1].h;
            }
            for (int i = 0; i < 2; i++)
            {
                points_like_vektor[i] = new Points();
            }
            points_like_vektor[0].x = p[1].x - p[0].x;
            points_like_vektor[0].y = p[1].y - p[0].y;
            points_like_vektor[0].z = p[1].z - p[0].z;
            points_like_vektor[0].h = 0;
            points_like_vektor[1].x = p[p.Length - 1].x - p[0].x;
            points_like_vektor[1].y = p[p.Length - 1].y - p[0].y;
            points_like_vektor[1].z = p[p.Length - 1].z - p[0].z;
            points_like_vektor[1].h = 0;
            normal.x = points_like_vektor[0].y * points_like_vektor[1].z - points_like_vektor[1].y * points_like_vektor[0].z;
            normal.y = points_like_vektor[0].x * points_like_vektor[1].z - points_like_vektor[1].x * points_like_vektor[0].z;
            normal.z = points_like_vektor[0].x * points_like_vektor[1].y - points_like_vektor[1].x * points_like_vektor[0].y;
            normal.x = p[0].x - normal.x;
            normal.y = p[0].y - normal.y;
            normal.z = p[0].z - normal.z;
        }
        public void Side_On_Matrix(Matrix M)
        {
            Points[] points_like_vektor = new Points[2];
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
            for (int i = 0; i < 2; i++)
            {
                points_like_vektor[i] = new Points();
            }
            points_like_vektor[0].x = p[1].x - p[0].x;
            points_like_vektor[0].y = p[1].y - p[0].y;
            points_like_vektor[0].z = p[1].z - p[0].z;
            points_like_vektor[0].h = 0;
            points_like_vektor[1].x = p[p.Length - 1].x - p[0].x;
            points_like_vektor[1].y = p[p.Length - 1].y - p[0].y;
            points_like_vektor[1].z = p[p.Length - 1].z - p[0].z;
            points_like_vektor[1].h = 0;
            normal.x = points_like_vektor[0].y * points_like_vektor[1].z - points_like_vektor[1].y * points_like_vektor[0].z;
            normal.y = -(points_like_vektor[0].x * points_like_vektor[1].z - points_like_vektor[1].x * points_like_vektor[0].z);
            normal.z = points_like_vektor[0].x * points_like_vektor[1].y - points_like_vektor[1].x * points_like_vektor[0].y;
        }
    }
}
