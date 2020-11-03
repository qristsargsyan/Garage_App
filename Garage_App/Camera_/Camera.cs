using System;

namespace Garage_App.Camera_
{
    class Camera
    {
        private readonly string brand;
        private readonly string licenseNumber;
        private readonly ConsoleColor color;
        public static DateTime Entrance;
        public static DateTime Exit;

        public Camera(string brand, string licenseNumber, ConsoleColor color, DateTime entrance, DateTime exit)
        {
            this.brand = brand;
            this.licenseNumber = licenseNumber;
            this.color = color;
            Entrance = entrance;
            Exit = exit;
        }

        public Camera() { }

        public override string ToString()
        {
            return
                   $"Car's brand  {brand}\n" +
                   $"Car's license number  {licenseNumber}\n" +
                   $"Car's color {color}\n" +
                   $"Car entrance at  {Entrance}\n" +
                   $"Car exit at  {Exit}\n";
        }
    }
}
