using System;


namespace softunicamp
{
    class Program
    {
        static void Main()
        {
            int grupCnt = int.Parse(Console.ReadLine());

            int peaple = 0;

            double car = 0.0;
           double bus = 0.0;
           double smallBus = 0.0;
           double bigBus = 0.0;
           double  train = 0.0;

            for (int i = 0; i < grupCnt; i++)
            {
                int peapleInGrup = int.Parse(Console.ReadLine());

                peaple += peapleInGrup;

                if (peapleInGrup <= 5)
                {
                    car = car + peapleInGrup;
                }
                else if (peapleInGrup <= 12)
                {
                    bus += peapleInGrup;
                }
                else if (peapleInGrup <= 25)
                {
                    smallBus  += peapleInGrup;
                }
                else if (peapleInGrup <= 40)
                {
                    bigBus += peapleInGrup;
                }
                else if (peapleInGrup > 40)
                {
                    train += peapleInGrup;
                }

            }
            double carPrecent =car / peaple * 100;
            double busPrecent = bus / peaple * 100;
            double smallBusPrecent = smallBus / peaple * 100;
            double bigBusPrecent = bigBus  / peaple * 100;
            double trainPrecent = train / peaple * 100;

            Console.WriteLine($"{carPrecent:f2}%");
            Console.WriteLine($"{busPrecent:f2}%");
            Console.WriteLine($"{smallBusPrecent:f2}%");
            Console.WriteLine($"{bigBusPrecent:f2}%");
            Console.WriteLine($"{trainPrecent:f2}%");

        }
    }
}
