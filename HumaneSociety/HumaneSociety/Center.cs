using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Center
    {
        private string name;
        private double register = 0;
        private int numberOfCages = 15;
        List<Cage> cageList;
        List<Adopter> adopterList;
        Employee employee;
        Adopter adopter;
        Dog dog;
        Animal animal;


      
        public Center()
        {
            cageList = new List<Cage>();
            adopter = new Adopter();
            employee = new Employee();
            dog = new Dog();
        }

        public string Name { get; set; }


        public void CreateCages()
        {
        for (int i = 0; i < numberOfCages; i++)
            {
                Cage cages = new Cage();
                cageList.Add(cages);
                
            }
        }

        public void AddToCage(Animal animal, int cageNumb)
        {
          //  cageList[cageNumb] = animal;
        }

       
        public void CollectMoneyForPet(Adopter adopter)
        {
            register += dog.purchasePrice;
        }
     

        //public void AddDogToList(Dog dog)
        //{
        
        //    for(int list = 0; list < dogList.Count; list++)
        //   {
        //   dogList.Add(dog);
        //   }  
           
        //}

        //public void RemoveDogFromList(Dog dog)
        //{
        //for(int list = 0; list < dogList.Count; list++)
        //    {
        //        dogList.Remove(dog);
        //    }

        //}

        public void AddAdopterList(Adopter adopter)
        {
        for(int list = 0; list < adopterList.Count; list++)
            {
                adopterList.Add(adopter);
            }
        }

    }
}
