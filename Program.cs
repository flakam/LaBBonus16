using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Bonus_16
{
    class Program
    {
        static void Main(string[] args)
        {
           Car c = new Car();
           Console.WriteLine(c.Make);
           Console.WriteLine(c.Model);
           Console.WriteLine(c.Price);
           Console.WriteLine(c.Year);
            List <CarApp> NewCar = new List<CarApp>();
            Console.WriteLine("How many cars do you want to add?");
            int i = int.Parse(Console.ReadLine());
            for (int j = 0; j < i; j++)
            {
                CarApp user1 = new CarApp();
                Console.WriteLine("Enter a car model");
                string input1 = Console.ReadLine();
                user1.SetCarModel(input1);
                Console.WriteLine("Enter a car maker");
                string input2 = Console.ReadLine();
                user1.SetCarMake(input2);
                Console.WriteLine("Enter car price");
                double input3 = double.Parse(Console.ReadLine());
                user1.SetCarPrice(input3);
                Console.WriteLine("Enter car year");
                int input4 = int.Parse(Console.ReadLine());
                user1.SetCarYear(input4);
                NewCar.Add(new CarApp(input4, input2,input1, input3));
                Console.WriteLine();                  
            }
            for (int k = 0; k < NewCar.Count; k++)
            { int t= k + 1;
                CarApp nn = NewCar[k];
                Console.WriteLine("Car "+t+ " Maker: " + nn.CarMake+" Model: "+nn.CarModel+" Price: "+nn.CarPrice.ToString("C2", CultureInfo.CurrentCulture) + " Year "+nn.CarYear+" ");
            }
            
        }
        
    }
}
