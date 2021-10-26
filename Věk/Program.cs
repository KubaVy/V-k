using System;

namespace Věk
{
    class Program
    {
        static void Main(string[] args)
        {
            double rok;
            Console.WriteLine("Zadej rok narozeni:");
            Double.TryParse(Console.ReadLine(), out rok);

            if (rok > 2021)
            {
                Console.WriteLine();
                Console.WriteLine("Zadej normální čísla");



            }
            else if (rok < 2008)
            {
                Console.WriteLine();
                Console.WriteLine("Jsi malý fagan");
            }
            else if (rok < 2002)
            {
                Console.WriteLine();
                Console.WriteLine("Jsi chudý nepracující student");
            }
            else if (rok > 1996)
            {
                Console.WriteLine();
                Console.WriteLine("Jsi dospělý");
            }
            else if (rok > 1955)
            {
                Console.WriteLine();
                Console.WriteLine("Jsi plesnivý dědek nebo babizna");

            }
        
                    
                    
        }   
    }
}


