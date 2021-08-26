using System;
using System.Collections.Generic;

namespace Electronics_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget1 = 60;
            var keyboards1 = new List<int>() { 40, 50, 60 };
            var drives1 = new List<int>() { 5, 8, 12 };

            var budget2 = 10;
            var keyboards2 = new List<int>() { 3, 1 };
            var drives2 = new List<int>() { 5, 2, 8 };

            var budget3 = 5;
            var keyboards3 = new List<int>() { 4 };
            var drives3 = new List<int>() { 5 };

            Console.WriteLine("Example 1 - The maximun amount for this budget is: " + getMoneySpent(budget1, keyboards1, drives1));
            Console.WriteLine("Example 2 - The maximun amount for this budget is: " + getMoneySpent(budget2, keyboards2, drives2));
            Console.WriteLine("Example 3 - The maximun amount for this budget is: " + getMoneySpent(budget3, keyboards3, drives3));

            static int getMoneySpent(int budget, List<int> keyboards, List<int> drives)
            {
                var tempValue = 0;
                var maximunValue = -1;

                foreach (var keyboard in keyboards)
                {
                    foreach (var drive in drives)
                    {
                        tempValue = keyboard + drive;

                        if (tempValue <= budget && tempValue > maximunValue)
                        {
                            maximunValue = tempValue;
                        }
                    }
                }
                return maximunValue;
            }
        }
    }
}
