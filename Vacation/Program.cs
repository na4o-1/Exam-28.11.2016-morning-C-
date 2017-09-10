using System;

namespace Vacation
{
    class Program
    {
        static void Main()
        {
            int adultsNum = int.Parse(Console.ReadLine());
            int studentsNum = int.Parse(Console.ReadLine());
            int NightsNum = int.Parse(Console.ReadLine());
            string transport = (Console.ReadLine().ToLower());

            double oneNightforGroup = 82.99;
            double priceSleepGrup = oneNightforGroup * NightsNum;

            int grup = studentsNum + adultsNum;

            double adultsPrise = 0.0;
            double studentsPrise = 0.0;

            string trainAssString = "train";
            string busAssString = "bus";
            string boatAssString = "boat";
            string airplaneAssString = "airplane";

            if (transport == trainAssString)
            {
                adultsPrise = 24.99 * adultsNum;
                studentsPrise = 14.99 * studentsNum;
                if (grup >= 50)
                {
                    adultsPrise = adultsPrise - (adultsPrise * 0.5);
                    studentsPrise = studentsPrise - (studentsPrise * 0.5);
                }
            }
            else if (transport == busAssString)
            {
                adultsPrise = 32.50 * adultsNum;
                studentsPrise = 28.50 * studentsNum;

            }
            else if (transport == boatAssString)
            {
                adultsPrise = 42.99 * adultsNum;
                studentsPrise = 39.99 * studentsNum;
            }
            else if (transport == airplaneAssString)
            {
                adultsPrise = 70.00 * adultsNum;
                studentsPrise = 50.00 * studentsNum;
            }
            double transportprice = (adultsPrise + studentsPrise)*2;
            double pricetotal = priceSleepGrup + transportprice;

            double Commission = pricetotal * 0.10;
            double sum = pricetotal + Commission;

            Console.WriteLine($"{sum:f2}");
        }
    }
}
