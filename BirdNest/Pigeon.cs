using System;
using System.Collections.Generic;
using System.Text;

namespace BirdNest
{
    class Pigeon : Bird
    {
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] pigeonEgg = new Egg[numberOfEggs];
            for (int i = 0; i < numberOfEggs; i++) {
                if (Bird.Randomizer.Next(4) == 0)
                {
                    pigeonEgg[i] = new BrokenEgg( "white");
                }
                else
                {
                    pigeonEgg[i] = new Egg(Bird.Randomizer.NextDouble() * 2 + 1, "white"); 
                }
            }

            return pigeonEgg;
        }
    }
}
