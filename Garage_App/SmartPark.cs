using Garage_App.Camera_;
using Garage_App.Parking;
using System;

namespace Garage_App
{
    sealed class SmartPark
    {
        private static Park parking = new Park();

        private static Camera camera;

        private static CountMoney countMoney;

        public Park Park { get; private set; }

        public void Table()
        {
            Park park = new Park();
            Console.WriteLine(park);
            Park.Table();
            Console.WriteLine();
            Console.Write("Please enter the row ");
            int row = int.Parse(Console.ReadLine());
            Console.Write($"Please enter the column ");
            int column = int.Parse(Console.ReadLine());
            parking[row, column] = new CarParkingSpace();
        }

        public static void CarData(string brand, string licenseNumber, ConsoleColor color, DateTime entrance, DateTime exit)
        {
            camera = new Camera(brand, licenseNumber, color, entrance, exit);
            Park.Table();
            Console.Write(camera);
        }

        public static void Money(ChangeMoney money)
        {
            countMoney = new CountMoney(money);
            countMoney.Paid();
            Console.WriteLine();
        }
    }
}
