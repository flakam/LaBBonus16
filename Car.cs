using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus_16
{
    class Car
    {
       public int year;
        public int Year
        {
            get
            {
                return year;
            }
        }
        public string make;
        public string Make
        {
            get
            {
                return make;
            }
        }
        public string model;
        public string Model
        {
            get
            {
                return model;
            }
        }
       // private double price;
       // public double Price//property
       // {
          //  get
          //{
            //    return price; //instance;
          // }
          public double Price { get; set; }//everyone will see this it is public
        //}
        public Car()//just to have a model car
        {
            this.year = 1882;
            this.Price = 100;
            this.model = "Cart with wheels and a donkey";
            this.make = "Ford";
        }
        public Car(int year,string make,string model, double price)//this is to customize your car
        {
            this.year = year;
            this.make = make;
            this.model = model;
            this.Price = price;

        }
        

        
    }
}
