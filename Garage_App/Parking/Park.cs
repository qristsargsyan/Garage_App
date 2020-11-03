using System;

namespace Garage_App.Parking
{
    class Park
    {
        public static int totalSpace = 20;
        public static int busySpaceCount;

        CarParkingSpace[,] space;

        static int[,] parkMap = new int[4, 5];


        static bool Free(int r, int c)
        {
            if (parkMap[r, c] == 1)
            {
                return false;
            }
            else
            {
                parkMap[r, c] = 1;
                return true;
            }
        }

        public Park()
        {
            space = new CarParkingSpace[4, 5];
        }

        public CarParkingSpace this[int row, int column]
        {
            get
            {
                return space[row, column];
            }
            set
            {
                if (Free(row, column))
                {
                    space[row, column] = value;
                }
                else
                {
                    busySpaceCount--;
                    throw new Exception("This space arleady is busy");
                }
            }
        }


        public static void Table()
        {
            for (int i = 0; i < parkMap.GetLength(0); i++)
            {
                for (int j = 0; j < parkMap.GetLength(1); j++)
                {
                    if (parkMap[i, j] == 0)
                    {
                        Console.Write("|____|");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write($"|    |");
                        Console.ResetColor();
                    }
                }
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            return $"Park total space is {totalSpace} (3 row,4 column)\n" +
                   $"Now busy space count is {busySpaceCount}\n";
        }
    }
}
