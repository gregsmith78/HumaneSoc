using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Employee
    {
        string name;
        int age;
        string gender;
        Dog dog = new Dog();


        public string Name { get; set; }

        //public double GiveShot(Dog dog)
        //{
        //    dog.immuneLevel += 100;
        //    dog.hadShots = true;
        //    Console.WriteLine("Caught up shots!");
        //    return dog.immuneLevel;

        //}
        public void Feed(Dog dog)
        {
            if (dog.isHungry)
            {
                Console.WriteLine("Feed me Seymore!");
            }
            else
            {
                Console.WriteLine("Belly is full!");
                dog.isHungry = false;
            }
        }
    }
}
