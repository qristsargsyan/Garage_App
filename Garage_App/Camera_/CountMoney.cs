using System;

namespace Garage_App.Camera_
{
    enum ChangeMoney
    {
        AMD,
        USD,
        RUB
    }

    class CountMoney
    {
        ChangeMoney ChangeMoney;

        public CountMoney(ChangeMoney money)
        {
            ChangeMoney = money;
        }

        public int Price
        {
            get
            {
                return ((Camera.Exit - Camera.Entrance).Hours + 1) * 100;
            }
        }

        public void Paid()
        {
            switch (ChangeMoney)
            {
                case ChangeMoney.AMD:
                    Console.WriteLine($"You must pay {Price} AMD");
                    break;
                case ChangeMoney.USD:
                    Console.WriteLine($"You must pay {(Price * 485.7) / 100} USD");
                    break;
                case ChangeMoney.RUB:
                    Console.WriteLine($"You must pay {(Price * 7.4) / 10} RUB");
                    break;
                default:
                    break;
            }
        }

        public override string ToString()
        {
            return $"You must pay {Price}\n";
        }
    }
}
