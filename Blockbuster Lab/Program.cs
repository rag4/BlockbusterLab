using System;

namespace Blockbuster_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to GC Blockbuster");
            Blockbuster b = new Blockbuster();
            Movie m = b.CheckOut();
            Console.Write("\nWould you like to watch the movie (Y/N):   ");
            char check = Console.ReadLine()[0];
            Console.WriteLine();
            while (char.ToUpper(check) == 'Y')
            {                
                if (char.ToUpper(check) == 'Y')
                {
                    m.Play();
                }
                Console.Write("\nWatch another scene (Y/N):   ");
                check = Console.ReadLine()[0];
                Console.WriteLine();
            }
        }
    }
}
