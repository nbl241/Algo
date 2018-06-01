using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.MonMenu
{
    class Menu
    {
        private List<MenuItem> menuItems;

        public Menu()
        {
            menuItems = new List<MenuItem>();
        }

        /// <summary>
        /// Insere un MenuItem dans le menu.
        /// </summary>
        /// <param name="item">Element a inserer dans le menu</param>
        /// <exception cref="ArgumentException">Si le numero de l'item est deja present dans le menu</exception>

        public void InsererLigne(MenuItem item)
        {
            /*foreach (var ligne in menuItems)
            {
                if (ligne.Numero == item.Numero)
                {
                    throw new ArgumentException(
                    $"Le numero {item.Numero} existe deja dans le menu");
                }
            }*/

            if(menuItems.Exists(x=> x.Numero == item.Numero))
            {
                throw new ArgumentException(
                    $"Le numero {item.Numero} existe deja dans le menu");
            }
            menuItems.Add(item);
        }

        /// <summary>
        /// Afficher les elements d'un menu
        /// </summary>

        public void Afficher()
        {
            //Affiche les elements du menu
            foreach (MenuItem ligne in menuItems)
            {
                Console.WriteLine($"{ligne.Numero}- {ligne.Libelle}");
            }
        }

        /// <summary>
        /// Affiche un menu et test la saisie de l'utilisateur
        /// </summary>
        /// <param name="menuItems">la liste des choix possible</param>
        /// <returns>le choix de l'utilisateur</returns>

        public int Choisir()
        {
            //recuperation du choix de l'utilisateur
            Console.WriteLine("saisir un choix");
            int choix;
            choix = int.Parse(Console.ReadLine());

            //test du choix par rapport aux elements du menu
            while (true)
            {
                foreach (MenuItem Item in menuItems)
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
}
