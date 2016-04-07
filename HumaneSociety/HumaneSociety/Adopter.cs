using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Adopter
    {
         string name;
         int age;
         bool hasMoney;
         double income;
         string profession;
         double wallet;
         Animal animal;
         List<Animal> pets = new List<Animal>();
         //Center center = new Center();
        

        public string Name { get; set; }

        public int Age { get; set; }
        
        public double Income { get; set; }
       
        public string Profession { get; set; }
      

        public void PrintProfile()
        {
            Console.WriteLine("Adopter Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Profession: " + profession);
            Console.WriteLine("Income: " + income);
        }

          public void Adopt(Animal animal)
        {
            pets.Add(animal);
            
        }
        //public double PayForPet(Adopter adopter)
        //{

        //}

        public void ShowPetList()
        {
        foreach(Animal item in pets)
            {
                Console.WriteLine(item);
            }
        }
        

    }
}
