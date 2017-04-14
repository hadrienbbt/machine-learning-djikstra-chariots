using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetChariot1
{

    // Heuristiques à implément : si chariot dans allée, pas besoin d'en pendre une autre
    // Point de retour = zone de décharge la plus proche
    public class NodeChariotTemps : GenericNode
    {
        public Position actuelle { get; set; }
        public static Position finale { get; set; }
        public static int hauteur;
        public static int[,] grille;
        public static bool charge; // Faux si l'objet n'as pas été pris, vrai sinon 
        public int cout; // 1 si tout droit, 3 si en rotation
        public static List<Position> mesCollisions;// Retiens les collisions rencontrés 

        public NodeChariotTemps(Position nouvelle, int Cout) : base() // Node de temps
        {
            actuelle = nouvelle;
            cout = Cout;
        }



        public static void initialiserTout(Position Actuelle, Position Finale, int[,] Grille, int Hauteur, bool Charge) // On initialise certain paramètres, hors de la node
        {
            finale = Finale;
            grille = Grille;
            charge = Charge;
            hauteur = Hauteur;
        }


        public override void CalculeHCost()
        {
            this.HCost = 1;
        }

        public override bool EndState()
        {
            if ((actuelle.Equals(new Position(finale.x - 1, finale.y)) || actuelle.Equals(new Position(finale.x + 1, finale.y)))&&!charge) // Si la position finale pour atteindre la marchandise est atteinte
            {
                finale.x = PlusCourtRetour(); // On cherche le chemin le plus cours à la zone de chargement
                finale.y = 0;
                return true;
            }
            else if((actuelle.Equals(new Position(finale.x, finale.y)) || actuelle.Equals(new Position(finale.x, finale.y))) && charge) // Si la position finale pour atteindre la zone est atteinte
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override double GetArcCost(GenericNode N2)
        {
            NodeChariotTemps NC = (NodeChariotTemps)N2; // retour du cout de déplacement
            return (NC.cout);
        }

        public override List<GenericNode> GetListSucc()
        {
            List<GenericNode> listeGenericNode = new List<GenericNode>();
            int nouveauCout = 0; // Cout de la node à ajouter
            Position ajout; // Position de la node à ajouter

            if (actuelle.y > 0 && grille[actuelle.x, actuelle.y - 1] != 1 && grille[actuelle.x, actuelle.y - 1] != 3 && grille[actuelle.x, actuelle.y - 1] != 4) 
            {
                //Déplacement à gauche : si la case gauche est différente de 1 (étagère), 3(marchandise) ou 4 (chariot) seulement
                grille[actuelle.x, actuelle.y] = 0;
                grille[actuelle.x, actuelle.y - 1] = 4; // on déplace le chariot 
                if (actuelle.orientation != 1)
                {
                    nouveauCout = 3; // Si une nouvelle orientation est prise, le cout est de 3
                }
                else
                {
                    nouveauCout = 1; // Si il va tout droit, le cout est de 1
                }
                ajout = new Position(actuelle.x, actuelle.y - 1, 1); // La nouvelle position du chariot
                listeGenericNode.Add(new NodeChariotTemps(ajout, nouveauCout)); // Ajout à la liste de node 
            }

             // Idem pour droite, haut, bas

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

            if (actuelle.x > 0 && grille[actuelle.x - 1, actuelle.y] != 1 && grille[actuelle.x - 1, actuelle.y] != 3 && grille[actuelle.x - 1, actuelle.y] != 4)
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
                ajout = new Position(actuelle.x - 1, actuelle.y, 3);
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
                ajout = new Position(actuelle.x + 1, actuelle.y, 4);
                listeGenericNode.Add(new NodeChariotTemps(ajout, nouveauCout));
            }
            return (listeGenericNode);
        }

        public override bool IsEqual(GenericNode N2)
        {
            NodeChariotTemps NC = (NodeChariotTemps)N2;
            return (NC.actuelle.Equals(this.actuelle));
        }


        public void afficherGrille()
        {// Affichage de la grille pour debuguage
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

        public Position contient(List<NodeChariotTemps> list, int indexNode)
        {
            // Vérification que la node actuellement comparée n'est pas présente dans une liste :
            // Utilisé pour détecter les collisions
            if (list[indexNode].actuelle.x == this.actuelle.x && list[indexNode].actuelle.y == this.actuelle.y)
            {
                return new Position(actuelle.x,actuelle.y);
            }
            else
            {
                return null;
            }
        }

        public Position contient(NodeChariotTemps t)
        {
            // Vérification que la node actuelle n'est pas la même que la node t:
            // Permet de vérifier que la node finale d'un autre chemin n'est pas similaire
            if(t.actuelle.x==actuelle.x && t.actuelle.y == actuelle.y)
            {
                return (new Position(actuelle.x, actuelle.y));
            }
            else
            {
                return null;
            }
        }

        public int PlusCourtRetour()
        {
            // calcul du plus cours retour une fois la marchandise récupérée
            for (int i = 0; i < 25; i++)
            {
                grille[i, 0] = 2; // On remet la zone d'arrivée à 2, pour enlever les 4 placés lors de la recherche

            }
            foreach (Position p in mesCollisions)
            {
                grille[p.x, p.y] = 4; // A chaque collisions détectées, on place un 4 , comme si un chariot s'y trouvait déjà
            }

            int distance = 100; // Calcul de la distance la plus petit, on initialise donc à une haute valeur
            int index=0; // on retourne l'index du plus cours chemin, correspondant à la coordonées [0,index] 

            for(int i = 0; i < 25; i++) // Pour les 25 places de déchargement
            {
                if(Math.Abs( i-actuelle.x) < distance) // Si la distance est plus petite que la précédente calculée
                {
                    if (grille[i,0] != 4) // Et si la place est disponible 
                    {
                        distance = Math.Abs(i - actuelle.x); // la nouvelle distance est la plus petite
                        index = i; // La position est donc [0,index]
                    }
                }
            }
            return index;
        }

        public static void instancieCollisions(List<Position> T)
        {
            mesCollisions = T; // Instancie la liste des collisions à partir de Form1
        }



    }
}
