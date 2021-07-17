﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BirdNest
{
    class BrokenEgg : Egg
    {
        public BrokenEgg( string color) : base(0, $"broken {color}")
        {
            Console.WriteLine("A bird laid a broke egg");
        }
    }
}
