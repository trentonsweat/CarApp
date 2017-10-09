using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarApp
{
    class Car
    {   // Members 
        private string make;
        private string model;
        private int year;
        private double price;

       

        // properties 
        public string Make
        {
            set { make = value; }// changes the value of data 

            get { return make; }// returns data

        }

        public string Model
        {
            set { model = value; }
            get { return model; }

        }

        public int Year
        {
            set { year = value; }
            get { return year; }

        }

        public double Price
        {
            set { price = value; }
            get { return price; }

        }



        // methods 
        public void AddCarDetails()
        {
            Console.WriteLine("Make");
            Make = Console.ReadLine();

            Console.WriteLine("Model");
            Model = Console.ReadLine();

            Console.WriteLine("Year");
            Year = int.Parse(Console.ReadLine());

            Console.WriteLine("Price\n");
            Price = double.Parse(Console.ReadLine());


        }

        // constructors 

        public Car()// default constructor 
        {
            make = "";
            model = "";
            year = 0;
            price = 0;
        }


        public Car(string CarMake, string CarModel, // constructor
            int CarYear, double CarPrice)
        {
            make = CarMake;
            model = CarModel;
            year = CarYear;
            price = CarPrice;

        }
    }
}
