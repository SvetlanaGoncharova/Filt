using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filtres
{
    class GreyWorld : FewFiltres
    {
        private float Avg = 0;
        private int Red = 0, Green = 0, Blue = 0;
        private int size=0;

        public GreyWorld(Bitmap sourceImage)
        {
            Color sourceColor;
             size = (sourceImage.Width - 1) * (sourceImage.Height - 1);
            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    sourceColor = sourceImage.GetPixel(i, j);
                    Red += sourceColor.R;
                    Green += sourceColor.G;
                    Blue += sourceColor.B;
                }
            }
            Avg = (float)((Red + Green + Blue) / (3 * size));
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {

            Color sourceColor = sourceImage.GetPixel(x, y);

            int k = Clamp((int)(sourceColor.R * Avg*size /Red),0,255);
            int l = Clamp((int)(sourceColor.G * Avg*size /Green),0,255);
            int m = Clamp((int)(sourceColor.B * Avg*size / Blue),0,255);

            Color resultColor = Color.FromArgb(k, l, m);

            return resultColor;
        }
    }
}
