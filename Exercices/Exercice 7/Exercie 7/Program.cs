using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exercie_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float prix, total = 0;

            Console.WriteLine("Entrez un prix (0 pour arrêter) : ");
            prix = int.Parse(Console.ReadLine());

            while (prix != 0)
            {
                Console.WriteLine("Entrez un prix (0 pour arrêter) : ");
                prix = int.Parse(Console.ReadLine());

                total += prix;
            }

            Console.WriteLine("Votre prix total est = " + total);
            Console.ReadLine();
        }
    }
}
