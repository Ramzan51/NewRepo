using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // saisie contrôlée du feu
            char feu;
            do
            {
                Console.WriteLine();
                Console.Write("feu (R/O/V) = ");
                feu = Console.ReadKey().KeyChar;
            } while (feu != 'R' && feu != 'O' && feu != 'V');
            // Affichage de l'ordre
            Console.WriteLine();
            switch (feu)
            {
                case 'R':
                    Console.WriteLine("s'arrêter");
                    break;
                case 'O':
                    Console.WriteLine("ralentir");
                    break;
                case 'V':
                    Console.WriteLine("passer");
                    break;
            }
            Console.ReadLine();
        }
    }
    
}
