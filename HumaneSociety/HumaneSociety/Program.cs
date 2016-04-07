using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.DisplayMenu();
           
            Center center = new Center();
            Adopter greg = new Adopter();
            Animal fido = new Animal();
            center.CreateCages();
            greg.Adopt(fido);
            greg.ShowPetList();
            //greg.PrintProfile();
            Console.ReadKey();
           

        }
    }
}
