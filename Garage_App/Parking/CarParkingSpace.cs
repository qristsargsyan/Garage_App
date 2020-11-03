namespace Garage_App.Parking
{
    class CarParkingSpace
    {
        private int parkingLength = 5;
        private int parkingWidth = 3;

        public CarParkingSpace()
        {
            Park.busySpaceCount++;
        }

        public override string ToString()
        {
            return $"Parking space length = {parkingLength} metr\n" +
                   $"Parking space width = {parkingWidth} metr\n";
        }
    }
}
