using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtres
{
    class MotionBlur : MatrixFilter
    {
        public MotionBlur()
        {
            int n = 7;
            int sizeX = n;
            int sizeY = n;

            kernel = new float[sizeX, sizeY];
            for (int i = 0; i < sizeX; i++)
                for (int j = 0; j < sizeY; j++)
                {
                    if (i == j)
                    { kernel[i, j] = (float)1 / n; break; }
                }

        }
    }
}
