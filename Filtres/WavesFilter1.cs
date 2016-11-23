using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filtres
{
    class WavesFilter1:FewFiltres
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            double pi = 3.14;
            Color sourceColor = sourceImage.GetPixel(x, y);
            int k = Clamp((int)(x+20*Math.Sin(2*pi*y/60)), 0, sourceImage.Width - 1);
            int l = Clamp(y , 0, sourceImage.Height - 1);

            Color resultColor = sourceImage.GetPixel(k, l);
            return resultColor;
        }
    }
}
