using System;

namespace LuckyTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            //Looping to organize re-entry
            while (true)
            {
                Console.WriteLine("Enter the ticket number (4 to 8 digits)");
                string numberTicket = Console.ReadLine();
                int Length = numberTicket.Length;
                int leftpart=0, rigthpart=0;
                //Checking for an even number of digits
                if (numberTicket.Length % 2 != 0) 
                {
                    numberTicket = numberTicket.Insert(0, "0");
                    Length += 1;
                }
                //Calculating the sum of the right and left sides of the ticket number
                for (int i = 0; i<=Length/2;i++) 
                {
                    leftpart += int.Parse(numberTicket[i].ToString());
                    rigthpart += int.Parse(numberTicket[(Length-1) - i].ToString());
                }
                if (leftpart == rigthpart)
                    Console.WriteLine("Lucky");
                else Console.WriteLine("Unlucky");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
