using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filtres
{
    class Glass:FewFiltres
    {
        Random NewRandon = new Random();
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            
            Color sourceColor = sourceImage.GetPixel(x, y);
            int k = Clamp((int)(x+(NewRandon.Next(2)-0.5)*10), 0, sourceImage.Width - 1);
            int l = Clamp((int)(y+(NewRandon.Next(1)-0.5)*10), 0, sourceImage.Height - 1);
            
            Color resultColor = sourceImage.GetPixel(k, l);
            return resultColor;
        }
    }
}
