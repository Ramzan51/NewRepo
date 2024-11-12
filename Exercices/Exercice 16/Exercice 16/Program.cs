using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saisissez une phrase : ");
            string phrase = Console.ReadLine();

            Console.WriteLine("Saisissez un mot dans la phrase : ");
            string mot = Console.ReadLine();

            // Recherche de la position mot dans la phrase
            int position = phrase.IndexOf(mot);

            // Teste si le mot a été trouvé
            if (phrase.IndexOf(mot) != -1 )
            {
                Console.WriteLine(phrase.Substring(position));
            }
            else
            {
                Console.WriteLine("Y'a pas ");
            }

            // affichage de la phrase à partir de ce mot
            Console.ReadLine();
        }
    }
}
