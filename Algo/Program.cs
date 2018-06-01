using Algo.MonMenu;
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
            {
                Menu menu = new Menu();
                menu.InsererLigne(new MenuItem { Numero = 1, Libelle = "Voyages" });
                menu.InsererLigne(new MenuItem { Numero = 2, Libelle = "Clients" });
                menu.InsererLigne(new MenuItem { Numero = 3, Libelle = "Dossiers" });

                menu.Afficher();
                int resultat = menu.Choisir();
                switch (resultat)
                {
                    case 1:
                        SousMenuVoyages();
                        break;
                    case 2:
                        SousMenuClients();
                        break;
                    case 3:
                        SousMenuDossier();
                        break;
                }
                Console.ReadLine();



                Console.WriteLine(resultat);
                Console.ReadLine();
            }
        }

        private static void SousMenuDossier()
        {
            Menu sousMenu = new Menu();
            sousMenu.InsererLigne(new MenuItem { Numero = 1, Libelle = "Creer" });
            sousMenu.InsererLigne(new MenuItem { Numero = 2, Libelle = "Rechercher" });
            sousMenu.InsererLigne(new MenuItem { Numero = 3, Libelle = "Supprimer" });

            sousMenu.Afficher();
            int resultatSousMenu = sousMenu.Choisir();
            switch (resultatSousMenu)
            {
                case 1:
                    Console.WriteLine("Vous souhaiter : Dossier => Creer");
                    break;
                case 2:
                    Console.WriteLine("Vous souhaiter : Dossier => Rechercher");
                    break;

                case 3:
                    Console.WriteLine("Vous souhaiter : Dossier => Supprimer");
                    break;
            }
        }

        private static void SousMenuClients()
        {
            Menu sousMenu = new Menu();
            sousMenu.InsererLigne(new MenuItem { Numero = 1, Libelle = "Creer" });
            sousMenu.InsererLigne(new MenuItem { Numero = 2, Libelle = "Rechercher" });
            sousMenu.InsererLigne(new MenuItem { Numero = 3, Libelle = "Supprimer" });

            sousMenu.Afficher();
            int resultatSousMenu = sousMenu.Choisir();
            switch (resultatSousMenu)
            {
                case 1:
                    Console.WriteLine("Vous souhaiter : Clients => Creer");
                    break;
                case 2:
                    Console.WriteLine("Vous souhaiter : Clients => Rechercher");
                    break;

                case 3:
                    Console.WriteLine("Vous souhaiter : Clients => Supprimer");
                    break;
            }
        }

        private static void SousMenuVoyages()
        {
            Menu sousMenu = new Menu();
            sousMenu.InsererLigne(new MenuItem { Numero = 1, Libelle = "Destination" });
            sousMenu.InsererLigne(new MenuItem { Numero = 2, Libelle = "Compagnies" });

            sousMenu.Afficher();
            int resultatSousMenu = sousMenu.Choisir();
            switch (resultatSousMenu)
            {
                case 1:
                    Console.WriteLine("Vous souhaiter : voyages => destination");
                    break;
                case 2:
                    Console.WriteLine("Vous souhaiter : voyages => compagnies");
                    break;
            }
        }
    }
}