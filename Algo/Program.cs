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

        private static int GererMenu(List<string> menu)
        {
            foreach (var ligne in menu)
            {
                Console.WriteLine(ligne);
            }

            int choix;
            choix = int.Parse(Console.ReadLine());
            return choix;
        }
    }
}
