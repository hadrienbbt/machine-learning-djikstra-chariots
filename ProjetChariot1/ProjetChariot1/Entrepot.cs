using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetChariot1
{
    class Entrepot
    {
        public int[,] grille;
        public Chariot c;

        public Entrepot(int[,]Grille,Chariot C)
        {
            c = C;
            grille = Grille;
        }
    }
}
