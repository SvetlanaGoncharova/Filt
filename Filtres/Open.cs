using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

/*namespace Filtres

   class Open : FewFiltres
    {
                private int[,] mask = new int[3, 3];
        private int radiusX;
        private int radiusY;

        public Open()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    mask[i, j] = 1;
                }
           radiusX = mask.GetLength(0) / 2;
           radiusY = mask.GetLength(1) / 2;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {

            int resultR = 0;
            int resultG = 0;
            int resultB = 0;

            int maxR, maxG, maxB;

            for (int j = -radiusY; j <= radiusY; j++)
            {
                for (int i = -radiusX; i <= radiusX; i++)
                {
                    int idX = Clamp(x + i, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + j, 0, sourceImage.Height - 1);
                    maxR = sourceImage.GetPixel(idX, idY).R;
                    maxG = sourceImage.GetPixel(idX, idY).G;
                    maxB = sourceImage.GetPixel(idX, idY).B;
                    if ((mask[i + radiusX, j + radiusY] == 1) && (maxR > resultR))
                        resultR = maxR;
                    if ((mask[i + radiusX, j + radiusY] == 1) && (maxG > resultG))
                        resultG = maxG;
                    if ((mask[i + radiusX, j + radiusY] == 1) && (maxB > resultB))
                        resultB = maxB;

                }
            }
            return Color.FromArgb(
                 Clamp((int)resultR, 0, 255),
                 Clamp((int)resultG, 0, 255),
                 Clamp((int)resultB, 0, 255)
                 );
            resultR = 255;
            resultG = 255;
             resultB = 255;
             int maxR1, maxG1, maxB1;

            for (int j = -radiusY; j <= radiusY; j++)
            {
                for (int i = -radiusX; i <= radiusX; i++)
                {
                    int idX = Clamp(x + i, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + j, 0, sourceImage.Height - 1);
                    minR1 = sourceImage.GetPixel(idX, idY).R;
                    minG1 = sourceImage.GetPixel(idX, idY).G;
                    minB1 = sourceImage.GetPixel(idX, idY).B;
                    if ((mask[i + radiusX, j + radiusY] == 1) && (minR1 < resultR))
                        resultR = minR1;
                    if ((mask[i + radiusX, j + radiusY] == 1) && (minG1 < resultG))
                        resultG = minG1;
                    if ((mask[i + radiusX, j + radiusY] == 1) && (minB < resultB))
                        resultB = minB1;

                }
            }
            return Color.FromArgb(
                 Clamp((int)resultR, 0, 255),
                 Clamp((int)resultG, 0, 255),
                 Clamp((int)resultB, 0, 255)
                 );
        }

    }
}
*/