﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sCubeMarbleChallenge
{
    public class Marble
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public Double Weight { get; set; }

        public override String ToString()
        {
            //{ id: 1, color: "blue", name: "Bob", weight: 0.5 },
            return "{ id: " + ID + ", color: " + Color + ", name:" + Name + ", weight:" + Weight+"}";
        }
    }
   
}
