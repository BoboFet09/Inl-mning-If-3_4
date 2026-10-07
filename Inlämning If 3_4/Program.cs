using System;
using System.ComponentModel.Design;
namespace inlämning3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många minuter är låten du vill spela? (svara endast med en siffra)");
            int minuter = int.Parse(Console.ReadLine());
            if (minuter <= 3)
            {
                Console.WriteLine("Då kan vi spela den");
                int sekunder = int.Parse(Console.ReadLine());


            }
            else if (minuter > 4)
                {
                Console.WriteLine("Tyvärr, låten är för lång för att spelas");
            }
            else if (minuter == 4)
            {
                Console.WriteLine("Hur många sekunder ytterliggare låten? (svara endast med ett nummer)");
                int sekunder = int.Parse(Console.ReadLine());
                if (sekunder <= 20)
                {
                    Console.WriteLine("Då kan vi spela den");

                }
                else if (sekunder > 20)
                {
                    Console.WriteLine("Tyvärr, låten är för lång för att spelas");
                }
               

            }
        }
    }
}