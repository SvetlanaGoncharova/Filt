using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filtres
{
    class turn : FewFiltres
    {

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int x0 = (sourceImage.Width - 1) / 2;
            int y0 = (sourceImage.Height - 1) / 2;
            int tg = 45;

            Color resultColor;
           
            int k = (int)((x - x0) * Math.Cos(tg) - (y - y0) * Math.Sin(tg) + x0);
            int l = (int)((x - x0) * Math.Sin(tg) + (y - y0) * Math.Cos(tg) + y0);

            if ((k >= 0) && (l >= 0) && (k <= sourceImage.Width - 1) && (l <= sourceImage.Height - 1))
            { resultColor = sourceImage.GetPixel(k, l); }
            else
            { resultColor = Color.LightPink; }

            return resultColor;
        }
    }
}
