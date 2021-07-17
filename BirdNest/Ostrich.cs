using System;
using System.Collections.Generic;
using System.Text;

namespace BirdNest
{
    class Ostrich : Bird
    {
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] ostrichEgg = new Egg[numberOfEggs];
            for (int i = 0; i < numberOfEggs; i++)
            {
                ostrichEgg[i] = new Egg(Bird.Randomizer.NextDouble() + 12, "speckled"); 
            }

            return ostrichEgg;
        }
    }
}
