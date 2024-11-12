using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char genre;

            do
            {
                Console.WriteLine("Quel est votre genre : ");
                genre = Console.ReadKey().KeyChar;
            } while (genre != 'H' && genre != 'F');

            if (genre == 'H')
            {
                Console.WriteLine("Bonjour Monsieur !");
                
            }
            else
            {
                Console.WriteLine("Bonjour Madame !");
              
            }
            Console.ReadLine();
        }
    }
}
