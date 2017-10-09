using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{

        class Program
        {
            static void Main(string[] args)
            {


                int NumberOfCars;
                Console.WriteLine("Welcome to the Grand Circus Motors admin console! \nHow many cars are you entering:");
                NumberOfCars = int.Parse(Console.ReadLine());

                // 1. Create an array to hold the objeccts
                Car[] CarInventory = new Car[NumberOfCars];

            // 2. creating the Car objects inside our array (CarInventory)
            for (int i = 0; i < CarInventory.Length; i++)
               {
                CarInventory[i] = new Car();// make an object 
                }  

                // 3. Initialize the objects 
                for (int i = 0; i < CarInventory.Length; i++)
                {
                    Console.WriteLine("Enter Car #1 Make");
                    CarInventory[i].Make = Console.ReadLine();

                    Console.WriteLine("Enter Car Model");
                    CarInventory[i].Model = Console.ReadLine();

                    Console.WriteLine("Enter Car Year");
                    CarInventory[i].Year = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Car Price");
                    CarInventory[i].Price = double.Parse(Console.ReadLine());
                }



                Console.WriteLine("\n...\nCurrent Inventory:");
                Console.WriteLine("Make\tModel\tYear\tPrice");
                foreach (Car CA in CarInventory)
                {
                    Console.WriteLine($"{CA.Make}\t{CA.Model}\t{CA.Year}\t{CA.Price}");

                }




            
        }
    }
}
    

