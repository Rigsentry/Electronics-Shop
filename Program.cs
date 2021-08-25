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
            string mystring = null;
            Console.WriteLine("If you want to purchase press 1 otherwise 2");
            mystring = Console.ReadLine();

            switch (mystring)
            {
                case "1":
                    int b = 10;                          
                    int[] keyboards = new int[] { 3, 1 };
                    int[] usb_drives = new int[] { 5, 2, 8 };
                    //  The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
                    int moneySpent = getMoneySpent(keyboards, usb_drives, s);
                    Console.WriteLine(moneySpent);
                    break;

                case "2":
                    int b2 = 5;
                    int[] keyboards2 = new int[] {4 };
                    int[] usb_drives2 = new int[] { 5 };
                    //  The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items                                       
                    int moneySpent2 = getMoneySpent(keyboards2, usb_drives2, b2);
                    Console.WriteLine(moneySpent2);
                    break;
            }
        }
        static int getMoneySpent(int[] keyboards, int[] usb_drives, int totalMoneyAvailable)
        {
            var sortedKeyboardPrices = from keyboard in keyboards
                                       orderby keyboard descending
                                       select keyboard;
            var sortedDrivePrices = from drive in usb_drives
                                    orderby drive ascending
                                    select drive;
            //if not able to purchase anything
            var maxMoneySpendable = -1;

            foreach (var keyboard in sortedKeyboardPrices)
            {
                foreach (var drive in sortedDrivePrices)
                {
                    if (keyboard + drive <= totalMoneyAvailable)
                    {
                        if (keyboard + drive > maxMoneySpendable)
                            maxMoneySpendable = keyboard + drive;
                    }
                    else
                        break;
                }
            }
            return maxMoneySpendable;
        }
    }
}
