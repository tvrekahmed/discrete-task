﻿using Perfectnumbers;


namespace Perfectnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;

            Console.WriteLine("please enter your starting number");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("your ending number");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("perfect Numbers between {0} and {1} are :", n1, n2);


            for (i = n1; i <= n2; i++)
            {
                int sum = 0;    
                for (j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum+= j;
                }
                if (i == sum)
                    Console.WriteLine("{0}", i);
            }
        }




    }
    
}