using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetChariot1
{
    class NodeChariot : GenericNode
    {
        public int o = 0;
        public static Chariot Ch;
        public Position actuelle, finale;
        public static int[,] grille=new int[25,25];

        public NodeChariot(Position Actuelle, Position Finale, int[,]Grille)
        {
            actuelle = Actuelle;
            finale = Finale;
            Ch = new Chariot();
            Ch.act = actuelle;
            Ch.des = finale;
            grille = Grille;
        }



        public NodeChariot(Position Nouvelle)
        {
            Ch.act = Nouvelle;
        }


        public override void CalculeHCost()
        {
        }

        public override bool EndState()
        {
            Console.WriteLine("Endstate : " +Ch.act.x+" - " + Ch.act.y +"  == " + Ch.des.x +" - "+Ch.des.y+"\n\n");
            return (Ch.act.Equals(Ch.des));
        }

        public override double GetArcCost(GenericNode N2)
        {
            return (1);
        }

        public override List<GenericNode> GetListSucc()
        {
            o++;

            afficherGrille();
            Console.WriteLine("Position actuelle chariot : "+Ch.act.x+"  "+Ch.act.y + "\n\n");
            List <GenericNode> listeGenericNode = new List<GenericNode>();

            if (Ch.act.y > 1 && grille[Ch.act.x, Ch.act.y - 1] != 1 && grille[Ch.act.x, Ch.act.y - 1] != 3 && grille[Ch.act.x, Ch.act.y - 1] != 4)
            {
                grille[Ch.act.x, Ch.act.y] = 0;
                grille[Ch.act.x, Ch.act.y - 1] = 4;
                Console.WriteLine("Gauche");
                listeGenericNode.Add(new NodeChariot(new Position(Ch.act.x, Ch.act.y - 1)));
                Ch.act.y++;
                //afficherGrille();
            }
            

            if (Ch.act.y < (grille.GetLength(0) - 1) && grille[Ch.act.x, Ch.act.y + 1] != 1 && grille[Ch.act.x, Ch.act.y + 1] != 3 && grille[Ch.act.x, Ch.act.y + 1] != 4)
            {
                grille[Ch.act.x, Ch.act.y + 1] = 4;
                grille[Ch.act.x, Ch.act.y] = 0;
                Console.WriteLine("Droite");
                listeGenericNode.Add(new NodeChariot(new Position(Ch.act.x, Ch.act.y + 1)));
                Ch.act.y--;
                //afficherGrille();
            }

            if (Ch.act.x > 1 && grille[Ch.act.x - 1, Ch.act.y] != 1 && grille[Ch.act.x - 1, Ch.act.y] != 3 && grille[Ch.act.x - 1, Ch.act.y] != 4)
            {
                grille[Ch.act.x - 1, Ch.act.y] = 4;
                grille[Ch.act.x, Ch.act.y] = 0;
                Console.WriteLine("Haut");
                listeGenericNode.Add(new NodeChariot(new Position(Ch.act.x-1, Ch.act.y)));
                Ch.act.x++;
               // afficherGrille();
            }

            if (Ch.act.x < (grille.GetLength(1) - 1) && grille[Ch.act.x + 1, Ch.act.y] != 1 && grille[Ch.act.x + 1, Ch.act.y] != 3 && grille[Ch.act.x + 1, Ch.act.y] != 4)
            {
                grille[Ch.act.x + 1, Ch.act.y] = 4;
                grille[Ch.act.x, Ch.act.y] = 0;
                Console.WriteLine("Bas");
                listeGenericNode.Add(new NodeChariot(new Position(Ch.act.x + 1, Ch.act.y)));
                Ch.act.x--;
               // afficherGrille();
            }
            Ch.grille=grille;

            return (listeGenericNode);
        }

        public override bool IsEqual(GenericNode N2)
        {
            NodeChariot NC = (NodeChariot)N2;
          // Console.WriteLine("Is Equal NodeComparé " + NC.actuelle.x + " - " + NC.actuelle.y + "  a  " + Ch.act.x + " - " + Ch.act.y + "\n\n");
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
            Console.WriteLine("****\n");
        }

    }
}
