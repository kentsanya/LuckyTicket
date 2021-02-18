using System;

namespace LuckyTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the ticket number (4 to 8 digits)");
                string numberTicket = Console.ReadLine();
                int Length = numberTicket.Length-1;
                long leftpart=0, rigthpart=0;
                if (Length % 2 != 0) 
                {
                    numberTicket = numberTicket.Insert(0, "0");
                    Length += 1;
                }
                    
                
                for (int i = 0; i<=Length/2;i++) 
                {
                    leftpart += long.Parse(numberTicket[i].ToString());
                    rigthpart += long.Parse(numberTicket[Length - i].ToString());
                }
                if (leftpart == rigthpart)
                    Console.WriteLine("Lucky");
                else Console.WriteLine("Unlucky");
                Console.ReadKey();
            }
        }
    }
}
