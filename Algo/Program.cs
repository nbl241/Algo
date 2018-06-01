using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private static int GererMenu(List<MenuItem> menu)
        {
            foreach (MenuItem ligne in menu)
            {
                Console.WriteLine($"{ligne.Numero}- {ligne.Libelle}");
            }

            Console.WriteLine("saisir un choix");
            int choix;
            choix = int.Parse(Console.ReadLine());
            while(true)
            {
                foreach (MenuItem Item in menu)
                {
                    if (choix == Item.Numero)
                    {
                        return choix;
                    }
                }
                Console.WriteLine("Erreur lors de la saisie");
                choix = int.Parse(Console.ReadLine());
            }

            //return -1;

            //return menu.SingleOrDefault(x => x.Numero == choix) != null ? choix : -1;
        }
    }

    class MenuItem
    {
        public int Numero { get; set; }

        public string Libelle { get; set; }
    }
}
