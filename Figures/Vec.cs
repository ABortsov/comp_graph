using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Vec
    {
        public float x, y, z;
        public Vec(float a, float b, float c)
        {
            x = a;
            y = b;
            z = c;
        }
        public Vec(Vec a, Vec b)
        {
            float scal;
            Vec tmp = new Vec(0, 0, 0);
            scal = (a.x * b.x + a.y * b.y + a.z * b.z);
            tmp.x = b.x * 2 * scal;
            tmp.y = b.y * 2 * scal;
            tmp.z = b.z * 2 * scal;
            x = a.x - tmp.x;
            y = a.y - tmp.y;
            z = a.z - tmp.z;
        }
        public float lenOV (Vec c)
        {
            return (float)Math.Sqrt(c.x * c.x + c.y * c.y + c.z * c.z);
        }
    }
}
