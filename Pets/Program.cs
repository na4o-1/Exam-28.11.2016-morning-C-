using System;


namespace Pets
{
    class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int leftFoodKg = int.Parse(Console.ReadLine());

            double dayFoodDogKg = double.Parse(Console.ReadLine());
            double dayFoodCatKg = double.Parse(Console.ReadLine());
            double dayFoodTurtleGr = double.Parse(Console.ReadLine());

            double dayFoodTurtleKg = dayFoodTurtleGr / 1000;

            double needForDogDay = days * dayFoodDogKg;
            double needForCatDay = days * dayFoodCatKg;
            double needForTurtleDay = days * dayFoodTurtleKg;

            double totalNeedFood = needForDogDay + needForCatDay + needForTurtleDay;

            double diff = Math.Abs(totalNeedFood - leftFoodKg);

            if (leftFoodKg >= totalNeedFood)
            {
                Console.WriteLine($"{ Math.Floor(diff) } kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling (diff) } more kilos of food are needed.");
            }
        }
    }
}
