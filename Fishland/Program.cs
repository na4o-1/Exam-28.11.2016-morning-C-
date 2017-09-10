using System;

namespace Fishland
{
    class Program
    {
        static void Main()
        {
           
            double priceMackrelKg = Double.Parse(Console.ReadLine());
            double priceSpratlKg = Double.Parse(Console.ReadLine());
            double PalamudKgQuantity = Double.Parse(Console.ReadLine());
            double hoMakrelKgQuantity = Double.Parse(Console.ReadLine());
            double shellfishKgQuantity = Double.Parse(Console.ReadLine());
           
            Double pricePalamud = priceMackrelKg + priceMackrelKg * 0.6;
            double sumPalamud = PalamudKgQuantity * pricePalamud;

            Double priceHoMakrel = priceSpratlKg + priceSpratlKg * 0.8;
            double sumHoMacrel = priceHoMakrel * hoMakrelKgQuantity;

            Double priceshellfish = 7.5;
            double sumShellfish = priceshellfish * shellfishKgQuantity;

            Double check = sumPalamud + sumHoMacrel + sumShellfish;

            Console.WriteLine($"{check:f2}" );
        }
    }
}
