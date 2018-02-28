using Accord.Imaging.Filters;
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

        public static Bitmap GrayWorldFilter(Bitmap bmp)
        {
            GrayWorld filter = new GrayWorld();
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

        public static void SceneDebugger(
            ScriptBase script, 
            RectMap rectMap, 
            Scene scene, 
            bool blurred = false,
            bool posterized = false,
            int interval = 0,
            String s = null,
            byte posterInterval = 150,
            bool grayworld = false)
        {

            var mainscript = script as Script;
            

            if (mainscript.GTAform.GetDebugging() && mainscript.GTAform.GetSceneDebug() == scene.Name)
            {
                ulong lastHash = mainscript.GTAform.GetImageHash();
                Bitmap image = script.CropFrame(Helper.RectmapToRectangle(rectMap));
                ulong hash = ImageHashing.AverageHash(image);
                if (posterized) image = Helper.PosterizeFilter(image, posterInterval);
                if (blurred) image = Helper.BlurFilter(image);
                if (grayworld) image = Helper.GrayWorldFilter(image);
                double comparedHashes = ImageHashing.Similarity(rectMap.Hash, hash);
                image.Save(scene.Name.Replace(" ","") + "_" + hash + "_" + comparedHashes + ".png");
                if (s == null) s = scene.Name;
                mainscript.GTAform.LogThis("Compared " + s + " Images with our hash " + comparedHashes + "% similarity");
                mainscript.updateImage(image);
                //Sleep incase we have multiple images to check :)
                mainscript.Sleep(interval);
            }

        }

        public static string GetScriptFolder()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }
    }
}
