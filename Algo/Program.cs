﻿using System;
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
                new MenuItem { Libelle ="menu " },
                new MenuItem { Libelle ="menu "},
                new MenuItem { Libelle ="menu "},
            };

            int resultat = GererMenu(list);
            Console.WriteLine(resultat);
            Console.ReadLine();
        }

        /// <summary>
        /// Affiche un menu, test et recupere la saisie de l'utilisateur
        /// </summary>
        /// <param name="menu">la liste des choix possible</param>
        /// <returns>le choix de l'utilisateur</returns>

        private static int GererMenu(List<MenuItem> menu)
        {
            int Num = 0;
            Num++;

            //Affiche les elements d menu
            foreach (MenuItem ligne in menu)
            {
                Console.WriteLine($"{ligne.Numero = Num++}- {ligne.Libelle}");
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

    /// <summary>
    /// Represente une ligne d'un menu
    /// </summary>

    class MenuItem
    {
        public int Numero { get; set; }

        public string Libelle { get; set; }
    }
}
