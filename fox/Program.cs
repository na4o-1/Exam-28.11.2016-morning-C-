using System;


namespace fox
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //first part
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string ('*',1+i)+"\\"+new string('-',(2*n-1)-2*i)+"/"+ new string('*', 1 + i));
            }
            //second part
            for (int k = 0; k < n/3; k++)
            {
                Console.WriteLine("|"+new string('*',n/2+k)+"\\"+new string ('*',n-2*k )+"/"+ new string('*', n / 2 + k)+"|");
            }
            //tirt part
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(new string('-',1+j )+"\\"+new string('*',(n*2-1)-2*j)+"/"+ new string('-', 1 + j));
            }


        }
    }
}
