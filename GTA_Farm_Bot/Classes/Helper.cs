using Accord.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA_Farm_Bot.Classes
{
    class Helper
    {

        public static Bitmap BlurFilter(Bitmap bmp)
        {
            Blur filter = new Blur();
            return filter.Apply(bmp);
        }

    }
}
