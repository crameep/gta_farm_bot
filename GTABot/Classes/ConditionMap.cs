using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTABot.Classes
{
    public class ConditionMap
    {

        public RectMap RectMap { get; set; }

        public String Name { get; set; }

        public int Match { get; set; }

        public bool Required { get; set; }


        public ConditionMap()
        {
            RectMap = new RectMap() { X = 0, Y = 0, Width = 1024, Height = 768, Hash = 0 };
            Name = "Default RectMap";
            Match = 100;
            Required = true;
        }

    }
}
