using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez une phrase : ");
            string phrase = Console.ReadLine();

            string newphrase = phrase.Replace(' ', '_');

            Console.WriteLine(newphrase);
            Console.ReadLine();
        }
    }
}
