using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus_16
{
    class CarApp
    {
        public string CarMake;
        public string CarModel;
        public int CarYear;
        public double CarPrice;

        public CarApp(int year, string make, string model, double price)
        {
            CarMake = make;
            CarModel = model;
            CarPrice = price;
            CarYear = year;
        }

        public CarApp()
        {
        }

        public void SetCarModel(string _model)
        {
            CarModel= _model;
        }
        public void SetCarMake(string _make)
        {
            CarMake= _make;
        }
        public void SetCarYear(int _year)
        {
            CarYear = _year;
        }
        public void SetCarPrice(double _price)
        {
            CarPrice = _price;
        }
         
    }
}
