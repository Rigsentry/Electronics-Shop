using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //int b = 60;
            //int[] keyboards = new int[] { 40, 50, 60 };
            //int[] drives = new int[] { 5, 8, 12 };

            //int b = 10;
            //int[] keyboards = new int[] { 3, 1 };
            //int[] drives = new int[] { 5, 2, 8 };

            int b = 5;
            int[] keyboards = new int[] { 4 };
            int[] drives = new int[] { 5 };
            int max = -1;
            for(int i=0; i<keyboards.Count(); i++)
            {
                for (int j=0; j<drives.Count(); j++)
                {
                    int currentSum = keyboards[i] + drives[j];
                    if (currentSum <= b && currentSum > max)
                    {
                        max = currentSum;
                    }
                }
            }
            Console.WriteLine(max);
            Console.ReadLine();

        }
    }
}
