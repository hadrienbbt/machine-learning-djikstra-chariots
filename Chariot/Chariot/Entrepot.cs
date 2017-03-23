﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chariotIntelligent
{
    public class Entrepot:GenericNode
    {
        public int[,] grille { get; protected set; }
        public int NBC { get; protected set; }
        public List<Chariot> chariots = new List<Chariot>();
        public Chariot chariotEnCours;

        public Entrepot()
        {
            grille = new int[25,25];
            initialiserGrille();
            NBC = 10;
            //ajouterChariotsGrille();
            Chariot c = new Chariot(this);
            chariots.Add(c);
            grille[c.position.x, c.position.y] = 4;
           // afficherGrille();
        }

        public Entrepot(int[,] newGrille)
        {
            grille = newGrille;
            for (int i = 0; i < grille.GetLength(0); i++)
            {
                for (int j = 0; j < grille.GetLength(1); j++)
                {
                    if (grille[i, j] == 4)
                    {
                        Chariot c = new Chariot(i, j);
                        this.chariots.Add(c);
                    }
                }
            }
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

        public override bool IsEqual(GenericNode N2)
        {
            throw new NotImplementedException();
        }

        public override double GetArcCost(GenericNode N2)
        {
            throw new NotImplementedException();
        }

        public override bool EndState()
        {
            throw new NotImplementedException();
        }

        public override List<GenericNode> GetListSucc()
        {
            int posX = chariots[0].position.x;
            int posY = chariots[0].position.y;
            int[,] grilleTemp = new int[this.grille.GetLength(0), this.grille.GetLength(1)];

            List<GenericNode> listeGenericNode = new List<GenericNode>();

            if (posY>0 && grille[posX,posY-1] != 1 && grille[posX, posY-1] != 3 && grille[posX, posY-1] != 4)
            {
                // décalage à gauche
                for (int i = 0; i < grille.GetLength(0); i++)
                {
                    for (int j = 0; j < grille.GetLength(1); j++)
                    {
                        if (i == posX && j == (posY-1)) grilleTemp[i, j] = 4;
                        else
                        {
                            if (i == posX && j == posY) grilleTemp[i, j] = 0;
                            else grilleTemp[i, j] = grille[i, j];
                        }
                    }
                }
                Console.WriteLine("décalage à gauche");
                listeGenericNode.Add(new Entrepot(grilleTemp));
                grilleTemp = new int[this.grille.GetLength(0), this.grille.GetLength(1)];

            }


            if (posY < (grille.GetLength(0)-1) && grille[posX, posY + 1] != 1 && grille[posX, posY+1] != 3 && grille[posX, posY+1] != 4)
            {
                // décalage à droite

                for (int i = 0; i < grille.GetLength(0); i++)
                {
                    for (int j = 0; j < grille.GetLength(1); j++)
                    {
                        if (i == posX && j == (posY+1)) grilleTemp[i, j] = 4;
                        else
                        {
                            if (i == posX && j == posY) grilleTemp[i, j] = 0;
                            else grilleTemp[i, j] = grille[i, j];
                        }
                    }
                }
                Console.WriteLine("décalage à droite");
                listeGenericNode.Add(new Entrepot(grilleTemp));
                grilleTemp = new int[this.grille.GetLength(0), this.grille.GetLength(1)];
            }

            if (posX > 0 && grille[posX-1, posY] != 1 && grille[posX-1, posY] != 3 && grille[posX-1, posY] != 4) { 

                // décalage en haut
                for (int i = 0; i < grille.GetLength(0); i++)
                {
                    for (int j = 0; j < grille.GetLength(1); j++)
                    {
                        if (i == (posX-1) && j == posY) grilleTemp[i, j] = 4;
                        else
                        {
                            if (i == posX && j == posY) grilleTemp[i, j] = 0;
                            else grilleTemp[i, j] = grille[i, j];
                        }
                    }
                }
                Console.WriteLine("décalage en haut");
                listeGenericNode.Add(new Entrepot(grilleTemp));
                grilleTemp = new int[this.grille.GetLength(0), this.grille.GetLength(1)];
            }

            if (posX < (this.grille.GetLength(1)-1) && grille[posX+1, posY] != 1 && grille[posX+1, posY] != 3 && grille[posX+1, posY] != 4)
            {

                // décalage en bas
                for (int i = 0; i < grille.GetLength(0); i++)
                {
                    for (int j = 0; j < grille.GetLength(1); j++)
                    {
                        if (i == (posX+1) && j == posY) grilleTemp[i, j] = 4;
                        else
                        {
                            if (i == posX && j == posY) grilleTemp[i, j] = 0;
                            else grilleTemp[i, j] = grille[i, j];
                        }
                    }
                }
                Console.WriteLine("décalage en bas");
                listeGenericNode.Add(new Entrepot(grilleTemp));
                grilleTemp = new int[this.grille.GetLength(0), this.grille.GetLength(1)];
            }


            return listeGenericNode;
        }

        public override void CalculeHCost()
        {
            throw new NotImplementedException();
        }
    }
}
