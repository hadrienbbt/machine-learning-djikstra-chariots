using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetChariot1
{
    class NodeChariotChemin : GenericNode
    {
        public Position actuelle;
        public static Position finale;
        public static int[,] grille = new int[25, 25];



        public static void initialiserTout(Position Actuelle, Position Finale, int[,] Grille)
        {
            finale = Finale;
            grille = Grille;
        }



        public NodeChariotChemin(Position Nouvelle):base()
        {
            actuelle = Nouvelle;
        }


        public override void CalculeHCost()
        {

            this.HCost = Math.Abs((finale.x - this.actuelle.x) + (finale.y - this.actuelle.y));
            Console.WriteLine("Cout =" + (finale.x - this.actuelle.x) + " - " + (finale.y - this.actuelle.y));
            Console.WriteLine(this.HCost);
            // Estimation vol oiseau
        }

        public override bool EndState()
        {
            return (actuelle.Equals(finale));
        }

        public override double GetArcCost(GenericNode N2)
        {
            return (1);
        }

        public override List<GenericNode> GetListSucc()
        {

            afficherGrille();
            Console.WriteLine("Position actuelle chariot : " + actuelle.x + "  " + actuelle.y + "\n\n");
            List<GenericNode> listeGenericNode = new List<GenericNode>();

            if (actuelle.y > 1 && grille[actuelle.x, actuelle.y - 1] != 1 && grille[actuelle.x, actuelle.y - 1] != 3 && grille[actuelle.x, actuelle.y - 1] != 4)
            {
                grille[actuelle.x, actuelle.y] = 0;
                grille[actuelle.x, actuelle.y - 1] = 4;
                Console.WriteLine("Gauche");
                Position ajout = new Position(actuelle.x, actuelle.y - 1);
                listeGenericNode.Add(new NodeChariotChemin(ajout));
                //afficherGrille();
            }


            if (actuelle.y < (grille.GetLength(0) - 1) && grille[actuelle.x, actuelle.y + 1] != 1 && grille[actuelle.x, actuelle.y + 1] != 3 && grille[actuelle.x, actuelle.y + 1] != 4)
            {
                grille[actuelle.x, actuelle.y + 1] = 4;
                grille[actuelle.x, actuelle.y] = 0;
                Console.WriteLine("Droite");
                Position ajout = new Position(actuelle.x, actuelle.y + 1);
                listeGenericNode.Add(new NodeChariotChemin(ajout));
                //afficherGrille();
            }

            if (actuelle.x > 1 && grille[actuelle.x - 1, actuelle.y] != 1 && grille[actuelle.x - 1, actuelle.y] != 3 && grille[actuelle.x - 1, actuelle.y] != 4)
            {
                grille[actuelle.x - 1, actuelle.y] = 4;
                grille[actuelle.x, actuelle.y] = 0;
                Console.WriteLine("Haut");
                Position ajout = new Position(actuelle.x - 1, actuelle.y);
                listeGenericNode.Add(new NodeChariotChemin(ajout));
                // afficherGrille();
            }

            if (actuelle.x < (grille.GetLength(1) - 1) && grille[actuelle.x + 1, actuelle.y] != 1 && grille[actuelle.x + 1, actuelle.y] != 3 && grille[actuelle.x + 1, actuelle.y] != 4)
            {
                grille[actuelle.x + 1, actuelle.y] = 4;
                grille[actuelle.x, actuelle.y] = 0;
                Console.WriteLine("Bas");
                Position ajout = new Position(actuelle.x + 1, actuelle.y);
                listeGenericNode.Add(new NodeChariotChemin(ajout));
                // afficherGrille();
            }
            return (listeGenericNode);
        }

        public override bool IsEqual(GenericNode N2)
        {
            NodeChariotChemin NC = (NodeChariotChemin)N2;
            // Console.WriteLine("Is Equal NodeComparé " + NC.actuelle.x + " - " + NC.actuelle.y + "  a  " + actuelle.x + " - " + actuelle.y + "\n\n");
            return (NC.actuelle.Equals(this.actuelle));
        }

        public void afficherGrille()
        {
            for (int i = 0; i < grille.GetLength(0); i++)
            {
                for (int j = 0; j < grille.GetLength(1); j++)
                {
                    Console.Write(grille[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("****\n");
        }



    }
}
