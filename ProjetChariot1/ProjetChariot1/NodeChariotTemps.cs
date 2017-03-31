using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetChariot1
{
    class NodeChariotTemps:GenericNode
    {
        public Position actuelle;
        public static Position finale;
        public static int hauteur;
        public static int[,] grille = new int[25, 25];
        public static bool charge;
        public  int cout;

        public NodeChariotTemps(Position nouvelle, int Cout) : base()
        {
            actuelle = nouvelle;
            cout = Cout;
        }



        public static void initialiserTout(Position Actuelle, Position Finale, int[,] Grille, int Hauteur)
        {
            finale = Finale;
            grille = Grille;
            charge = false;
            hauteur = Hauteur;
        }


        public override void CalculeHCost()
        {
            this.HCost = 1;
        }

        public override bool EndState()
        {
            return (actuelle.Equals(new Position(finale.x-1,finale.y)) || actuelle.Equals(new Position(finale.x + 1, finale.y)));
        }

        public override double GetArcCost(GenericNode N2)
        {
            NodeChariotTemps NC = (NodeChariotTemps)N2;
            return (NC.cout);
        }

        public override List<GenericNode> GetListSucc()
        {
            List<GenericNode> listeGenericNode = new List<GenericNode>();
            int nouveauCout=0;
            Position ajout;
            if (actuelle.y > 1 && grille[actuelle.x, actuelle.y - 1] != 1 && grille[actuelle.x, actuelle.y - 1] != 3 && grille[actuelle.x, actuelle.y - 1] != 4)
            {//GAUCHE
                grille[actuelle.x, actuelle.y] = 0;
                grille[actuelle.x, actuelle.y - 1] = 4;
                if (actuelle.orientation != 1)
                {
                    nouveauCout = 3;
                }
                else
                {
                    nouveauCout = 1;
                }
                 ajout = new Position(actuelle.x, actuelle.y - 1, 1);
                listeGenericNode.Add(new NodeChariotTemps(ajout,nouveauCout));
            }


            if (actuelle.y < (grille.GetLength(0) - 1) && grille[actuelle.x, actuelle.y + 1] != 1 && grille[actuelle.x, actuelle.y + 1] != 3 && grille[actuelle.x, actuelle.y + 1] != 4)
            {//DROITE
                grille[actuelle.x, actuelle.y + 1] = 4;
                grille[actuelle.x, actuelle.y] = 0;
                if (actuelle.orientation != 2)
                {
                    nouveauCout = 3;
                }
                else
                {
                    nouveauCout = 1;
                }
                 ajout = new Position(actuelle.x, actuelle.y + 1, 2);
                listeGenericNode.Add(new NodeChariotTemps(ajout, nouveauCout));
            }

            if (actuelle.x > 1 && grille[actuelle.x - 1, actuelle.y] != 1 && grille[actuelle.x - 1, actuelle.y] != 3 && grille[actuelle.x - 1, actuelle.y] != 4)
            {//HAUT
                grille[actuelle.x - 1, actuelle.y] = 4;
                grille[actuelle.x, actuelle.y] = 0;
                if (actuelle.orientation != 3)
                {
                    nouveauCout = 3;
                }
                else
                {
                    nouveauCout = 1;
                }
                 ajout = new Position(actuelle.x-1, actuelle.y , 3);
                listeGenericNode.Add(new NodeChariotTemps(ajout, nouveauCout));
            }

            if (actuelle.x < (grille.GetLength(1) - 1) && grille[actuelle.x + 1, actuelle.y] != 1 && grille[actuelle.x + 1, actuelle.y] != 3 && grille[actuelle.x + 1, actuelle.y] != 4)
            {//BAS
                grille[actuelle.x + 1, actuelle.y] = 4;
                grille[actuelle.x, actuelle.y] = 0;
                if (actuelle.orientation != 4)
                {
                    nouveauCout = 3;
                }
                else
                {
                    nouveauCout = 1;
                }
                 ajout = new Position(actuelle.x+1, actuelle.y , 4);
                listeGenericNode.Add(new NodeChariotTemps(ajout, nouveauCout));
            }
            charge = this.EndState() ? true : false;


            return (listeGenericNode);
        }

        public override bool IsEqual(GenericNode N2)
        {
            NodeChariotTemps NC = (NodeChariotTemps)N2;
            return (NC.actuelle.Equals(this.actuelle));
        }


    }
}
