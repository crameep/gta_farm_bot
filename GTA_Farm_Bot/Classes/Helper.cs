using Accord.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Accord.Imaging.Filters.SimplePosterization;

namespace GTA_Farm_Bot.Classes
{
    class Helper
    {

        public static Bitmap BlurFilter(Bitmap bmp)
        {
            Blur filter = new Blur();
            return filter.Apply(bmp);
        }

        public static Bitmap PosterizeFilter(Bitmap bmp, byte posterizationInterval = 150)
        {
            SimplePosterization filter = new SimplePosterization();
            filter.PosterizationInterval = posterizationInterval;
            return filter.Apply(bmp);
        }
    }
}
