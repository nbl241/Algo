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
            List<MenuItem> list = new List<MenuItem>
            {
                new MenuItem {Numero = 1, Libelle ="menu 1"},
                new MenuItem {Numero = 3, Libelle ="menu 3"},
                new MenuItem {Numero = 4, Libelle ="menu 4"},
            };
            int resultat = GererMenu(list);
            Console.WriteLine(resultat);
            Console.ReadLine();
        }

        private static int GererMenu(List<MenuItem> menu)
        {
            //Affiche les elements d menu
            foreach (MenuItem ligne in menu)
            {
                Console.WriteLine($"{ligne.Numero}- {ligne.Libelle}");
            }

            //recuperation du choix de l'utilisateur
            Console.WriteLine("saisir un choix");
            int choix;
            choix = int.Parse(Console.ReadLine());

            //test du choix par rapport aux elements du menu
            while (true)
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
        }
    }

    class MenuItem
    {
        public int Numero { get; set; }

        public string Libelle { get; set; }
    }
}
