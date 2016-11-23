using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtres
{
    class Harshness2:MatrixFilter
    {
        public Harshness2()
        {
            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                    if ((j == 1)&&(i==1))
                    { kernel[i, j] = 9; }
                    else { kernel[i, j] = -1; }

            }
        }
    }
}
