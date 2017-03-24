using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetChariot1
{
    class Chariot
    {
        public Position des; // destination
        public Position act; // act
        List<NodeChariot> listeNodeChariot;
        public int[,] grille;



        public Chariot(Position Act, Position Des, int[,] Grille)
        {
            grille = Grille;
            des = Des;
            act = Act;
            listeNodeChariot = new List<NodeChariot>();
        }

        //public bool[] mouvement()
        //{
        //    bool[] mvmts = new bool[4];
        //    if (act.y > 0 && grille[act.x, act.y - 1] != 1 && grille[act.x, act.y - 1] != 3 && grille[act.x, act.y - 1] != 4)
        //    {
        //        mvmts[0] = true;
        //    }
        //    else
        //    {
        //        mvmts[0] = false;
        //    }


        //    if (act.y < (grille.GetLength(0) - 1) && grille[act.x, act.y + 1] != 1 && grille[act.x, act.y + 1] != 3 && grille[act.x, act.y + 1] != 4)
        //    {
        //        mvmts[1] = true;
        //    }
        //    else
        //    {
        //        mvmts[1] = false;
        //    }

        //    if (act.x > 0 && grille[act.x - 1, act.y] != 1 && grille[act.x - 1, act.y] != 3 && grille[act.x - 1, act.y] != 4)
        //    {
        //        mvmts[2] = true;
        //    }
        //    else
        //    {
        //        mvmts[2] = false;
        //    }

        //    if (act.x < (this.grille.GetLength(1) - 1) && grille[act.x + 1, act.y] != 1 && grille[act.x + 1, act.y] != 3 && grille[act.x + 1, act.y] != 4)
        //    {
        //        mvmts[3] = true;
        //    }
        //    else
        //    {
        //        mvmts[3] = false;
        //    }

        //    return mvmts;
        //}
    }
}


