using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Menu
    {
        Center center = new Center();

        public void DisplayMenu()
        {

            Console.WriteLine("=== Bucky's Humane Society ===");
            Console.ReadLine();
            Console.WriteLine("Please enter your Name...");
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Welcome {0}", userName);
            Console.ReadLine();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. To add an animal");
            Console.WriteLine("2. Remove an animal");
            Console.WriteLine("3. Find an Adopter");
            Console.WriteLine("4. Make a transaction");
            Console.WriteLine("5. Check the status of an animal");
            Console.WriteLine("6. Exit the program");

            int inputNum = Convert.ToInt32(Console.ReadLine());

            switch (inputNum)
            {
                case 1:
                    center.CreateCages();

                    break;
                case 2:
                   // center.RemoveDogFromList(dog);
                    break;

                
                
            }


        }
    } 
}
