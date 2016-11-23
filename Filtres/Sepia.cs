using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filtres
{
    class Sepia:FewFiltres
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int Intensity = (int)(sourceColor.R * 0.36 + sourceColor.G * 0.53 + sourceColor.B * 0.11);
            double k=30;
            int min = 0;
            int max = 255;
            int R=Clamp((int)(Intensity+2*k),min,max);
            int G = Clamp((int)(Intensity + 0.5 * k), min, max);
            int B = Clamp((int)(Intensity - 1 * k), min, max);
            Color resultColor = Color.FromArgb(R, G, B);
            return resultColor;
            
        }
    }
}
