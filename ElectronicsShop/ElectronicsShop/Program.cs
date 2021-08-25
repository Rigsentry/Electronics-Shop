using System;

namespace ElectronicsShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int b1 = 60;
            int[] keyboards1 = new int[] { 40, 50, 58 };
            int[] drives1 = new int[] { 5, 8, 12 };

            int b2 = 10;
            int[] keyboards2 = new int[] { 3, 1 };
            int[] drives2 = new int[] { 5, 2, 8 };

            int b3 = 5;
            int[] keyboards3 = new int[] { 4 };
            int[] drives3 = new int[] { 5 };
            Console.WriteLine("Output 1:");
            GetMoneySpent(b1, keyboards1, drives1);
            
            Console.WriteLine("Output 2:");
            GetMoneySpent(b2, keyboards2, drives2);

            Console.WriteLine("Output 3:");
            GetMoneySpent(b3, keyboards3, drives3);

        }

        static void GetMoneySpent(int budget, int[] keyboards, int[] drives)
        {
            int i, j;
            Array.Sort(keyboards);
            Array.Sort(drives);
            int currentMostExpensive = 0;
            if (keyboards[0] + drives[0] > budget)
            {
                currentMostExpensive = -1;
            }
            else
            {
                for (i = 0; i < keyboards.Length; i++)
                {
                    for (j = 0; j < drives.Length; j++)
                    {
                        if ((keyboards[i] + drives[j]) > currentMostExpensive && (keyboards[i] + drives[j]) <= budget)
                        {
                            currentMostExpensive = (keyboards[i] + drives[j]);
                        }
                    }
                }
            }

            Console.WriteLine(currentMostExpensive);
        }
    }
}
