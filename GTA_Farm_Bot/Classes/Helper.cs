using Accord.Imaging.Filters;
using PS4MacroAPI;
using PS4MacroAPI.Internal;
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

        public static void SceneDebugger(ScriptBase script, RectMap rectMap, Scene scene)
        {

            var mainscript = script as Script;
            

            if (mainscript.GTAform.GetDebugging() && mainscript.GTAform.GetSceneDebug() == scene.Name)
            {
                ulong lastHash = mainscript.GTAform.GetImageHash();
                Bitmap image = script.CropFrame(Helper.RectmapToRectangle(rectMap));
                double comparedHashes = ImageHashing.Similarity(rectMap.Hash, ImageHashing.AverageHash(image));
                mainscript.GTAform.LogThis("Compared " + scene.Name + " Images with our hash " + comparedHashes + "% similarity");
                mainscript.updateImage(image);
            }

        }
    }
}
