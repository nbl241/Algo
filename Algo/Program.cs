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
                menu.InsererLigne(new MenuItem { Numero = 1, Libelle = "menu 1" });
                menu.InsererLigne(new MenuItem { Numero = 3, Libelle = "menu 3" });
                menu.InsererLigne(new MenuItem { Numero = 3, Libelle = "menu 3BIS" });
                menu.InsererLigne(new MenuItem { Numero = 4, Libelle = "menu 4" });

                int resultat = menu.Choisir();
                Console.WriteLine(resultat);
                Console.ReadLine();
            }
        }
    }
}
