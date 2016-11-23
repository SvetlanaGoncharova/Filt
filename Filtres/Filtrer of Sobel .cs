using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtres
{
    class Filtrer_of_Sobel : MatrixFilter
    {
        public Filtrer_of_Sobel()
        {
            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];
            /*for (int j = 1; j < sizeY; j++)
            {
                if (j == 1) kernel[1, j] = -2;
                else kernel[1, j] = -1;
            }*/
            kernel[0, 0] = -1;
            kernel[0, 1] = -2;
            kernel[0, 2] = -1;
            for (int i = 1; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                    if (j == 1)
                    { kernel[i, j] = kernel[i - 1, j] + 2; }
                    else { kernel[i, j] = kernel[i - 1, j] + 1; }

            }
        }

    }
}
