using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetChariot1
{
    class NodeChariot : GenericNode
    {
        static int o = 0;
        public Position actuelle;
        public Position finale;
        public int[,] grille;

        public NodeChariot(Position nouvelle,ref int[,]Grille, Position Finale)
        {
            finale = Finale;
            actuelle = nouvelle;
            grille = Grille;
        }

        public override void CalculeHCost()
        {
        }

        public override bool EndState()
        {
            Console.WriteLine(finale.x + " " + finale.y);
            Console.WriteLine(actuelle.x + " " + actuelle.y);

            return (actuelle== finale);
        }

        public override double GetArcCost(GenericNode N2)
        {
            return (1);
        }

        public override List<GenericNode> GetListSucc()
        {
            o++;
            afficherGrille();
            Console.WriteLine(actuelle.x + "  " + actuelle.y);

            List<GenericNode> listeGenericNode = new List<GenericNode>();

            if (actuelle.y > 0 && grille[actuelle.x, actuelle.y - 1] != 1 && grille[actuelle.x, actuelle.y - 1] != 3 && grille[actuelle.x, actuelle.y - 1] != 4)
            {
                Console.WriteLine("Gauche");
                listeGenericNode.Add(new NodeChariot(new Position(actuelle.x, actuelle.y - 1),ref grille, finale));
                grille[actuelle.x, actuelle.y - 1] = 4;
                grille[actuelle.x, actuelle.y] = 0;
            }
            

            if (actuelle.y < (grille.GetLength(0) - 1) && grille[actuelle.x, actuelle.y + 1] != 1 && grille[actuelle.x, actuelle.y + 1] != 3 && grille[actuelle.x, actuelle.y + 1] != 4)
            {
                Console.WriteLine("Droite");
                listeGenericNode.Add(new NodeChariot(new Position(actuelle.x, actuelle.y + 1),ref grille, finale));
                grille[actuelle.x, actuelle.y + 1] = 4;
                grille[actuelle.x, actuelle.y] = 0;
            }

            if (actuelle.x > 0 && grille[actuelle.x - 1, actuelle.y] != 1 && grille[actuelle.x - 1, actuelle.y] != 3 && grille[actuelle.x - 1, actuelle.y] != 4)
            {
                Console.WriteLine("Haut");
                listeGenericNode.Add(new NodeChariot(new Position(actuelle.x-1, actuelle.y), ref grille,  finale));
                grille[actuelle.x - 1, actuelle.y] = 4;
                grille[actuelle.x, actuelle.y] = 0;
            }

            if (actuelle.x < (this.grille.GetLength(1) - 1) && grille[actuelle.x + 1, actuelle.y] != 1 && grille[actuelle.x + 1, actuelle.y] != 3 && grille[actuelle.x + 1, actuelle.y] != 4)
            {
                Console.WriteLine("Bas");
                listeGenericNode.Add(new NodeChariot(new Position(actuelle.x + 1, actuelle.y),ref grille, finale));
                grille[actuelle.x + 1, actuelle.y] = 4;
                grille[actuelle.x, actuelle.y] = 0;
            }

            return (listeGenericNode);
        }

        public override bool IsEqual(GenericNode N2)
        {
            NodeChariot NC = (NodeChariot)N2;
            return (NC.actuelle == this.actuelle);
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
        }

    }
}
