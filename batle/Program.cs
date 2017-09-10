using System;

namespace batle
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayer = int.Parse(Console.ReadLine());
            int secondPlayer = int.Parse(Console.ReadLine());
            int maxBatle = int.Parse(Console.ReadLine());
            int batleCnt = 0;
            for (int d1 = 1; d1 <= firstPlayer; d1++)
            {
                for (int d2 = 1; d2 <= secondPlayer ; d2++)
                {
                    batleCnt++;
                    Console.Write($"({d1} <-> {d2}) ");
                    if (batleCnt >= maxBatle)
                    {
                       return  ;
                    }
                }
            }

        }
    }
}
