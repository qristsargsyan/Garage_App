using Garage_App.Camera_;
using System;

namespace Garage_App
{
    class Program
    {
        static void Main(string[] args)            
        {
            SmartPark smartPark = new SmartPark();
            smartPark.Table();
            SmartPark.CarData("Audi", "34LL304", ConsoleColor.Red, DateTime.Parse("9:14"), DateTime.Parse("12:13"));
            SmartPark.Money(ChangeMoney.USD);
        }
    }
}
