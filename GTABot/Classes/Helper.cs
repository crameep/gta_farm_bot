
using PS4MacroAPI;
using PS4MacroAPI.Internal;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GTABot.Classes
{
    class Helper
    {
        public static Rectangle RectmapToRectangle(RectMap rectMap)
        {
            Rectangle r = new Rectangle()
            {
                X = rectMap.X,
                Y = rectMap.Y,
                Height = rectMap.Height,
                Width = rectMap.Width
            };
            return r;
        }

        public static string GetScriptFolder()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }
    }
}