using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chariotIntelligent
{
    public class Entrepot
    {
        public int[,] grille { get; protected set; }
        public int NBC { get; protected set; }
        public List<Chariot> chariots { get; protected set; }

        public Entrepot()
        {
            grille = new int[25,25];
            initialiserGrille();
            NBC = 10;
            chariots = new List<Chariot>();
            ajouterChariotsGrille();
            afficherGrille();
        }

        public void initialiserGrille()
        {
            for (int i = 0; i < 25; i++)
            {
                if (i%2 == 0 && i != 0 && i != 24)
                {
                    for (int j = 2; j < 23; j++)
                    {
                        if (j != 11 && j != 12 && j!= 13)
                        {
                            grille[i, j] = 1;
                        }
                    }
                }
                grille[i, 0] = 2;
            }
        }
        public void afficherGrille()
        {
            for (int i = 0; i < grille.GetLength(0); i++)
            {
                for (int j = 0; j < grille.GetLength(1); j++)
                {
                    Console.Write(grille[i,j]);
                }
                Console.WriteLine();
            }
        }
        public void ajouterChariotsGrille()
        {
            for (int i = 0; i < NBC; i++)
            {
                Chariot c = new Chariot(this);
                grille[c.position.x, c.position.y] = 4;
                chariots.Add(c);
            }
        }

    }
}
