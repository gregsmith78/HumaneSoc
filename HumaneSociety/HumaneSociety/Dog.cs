using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
   public class Dog : Animal
    {
        public string name;
        public string breed;
        public int hadShots;
        public bool hasBeenFed;
        public bool isHungry = true;
        public double immuneLevel = 0;
        public double purchasePrice = 0;
        public int cageNumb;

        public string Name { get; set; }

        public string Breed { get; set; }

        public Dog()
        {
           // name = Name;
           // breed = Breed;
        }
      public int DetermineIfNeedShots(Animal animal)
      {
            Random rand = new Random();
            hadShots = rand.Next(1, 2);

            if (hadShots == 1)
            {
                Console.WriteLine("Animal needs shot.");
                //GiveShot();

            }
            else
            {
                Console.WriteLine("Animal is up-to-date with shots.");
            }
            return hadShots;
      }

      public void GiveShot(Animal animal)
      {
            Console.WriteLine("Shot has been given.");
      }
    }
}
