using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ProjetChariot1
{

    // Note : 1 correspond au rayonnage, 2 à la zone de livraison, 3 aux colis et 4 au chariots

    // PROBLEME ! Dans calcul du chemin le plus court, prise en compte de la grille remplis de 4 (exploration), alors que devrait sur grille initiale remplis de 4 aux collisions et aux zonez chargement occupés


    public partial class Form1 : Form
    {
        // Brush utilisé pour le dessin de l'interface
        SolidBrush blue = new SolidBrush(Color.Blue);
        SolidBrush green = new SolidBrush(Color.Green);
        SolidBrush white = new SolidBrush(Color.White);
        SolidBrush black = new SolidBrush(Color.Black);
        SolidBrush red = new SolidBrush(Color.Red);
        SolidBrush gray = new SolidBrush(Color.Gray);
        Pen contour = new Pen(Color.Black);


        // Regroupe les collisions des nodes d'un chariot avec les nodes d'autres chariots. Sera transmis à NodeChariotTemps
        static List<Position> listeCollisions;

        // Représente l'entrepot
        int[,] maGrille;

        // Liste des chariots existants
        List<Chariot> mesChariots;

        // Tableaux des chemins de nodes (donc des listes de noes ) finaux de chaque chaque chariot
        List<NodeChariotTemps>[] mesChemins;

        // Chariot en durs pour les tests
        Chariot m1;
        Chariot m2;
        Chariot m3;
        Chariot m4;
        Chariot m5;

        // Permet d'éviter des répétitions intempestives des dessins
        bool dessin;

        public Form1(int [] Coordonnes)
        {
            InitializeComponent();
            listeCollisions = new List<Position>();
            mesChariots = new List<Chariot>();
            initialiseChariot(Coordonnes);

            mesChemins = new List<NodeChariotTemps>[mesChariots.Count()];

            for (int i = 0; i < mesChariots.Count(); i++)
            {
                mesChemins[i] = new List<NodeChariotTemps>();
            }

            dessin = true;

            initialiseTab(); // initialisation de la grille

            if (dessin)
            {
                this.Paint += new PaintEventHandler(this.dessinTab); // dessin de la grille (entrepot)
            }
        }

        public Form1()
        {
            InitializeComponent();
            mesChariots = new List<Chariot>();
            m1 = new Chariot(new Position(0, 1), new Position(12, 14), maGrille);
            m2 = new Chariot(new Position(24, 12), new Position(6, 15), maGrille);
            m3 = new Chariot(new Position(1, 20), new Position(12, 5), maGrille);
            m4 = new Chariot(new Position(24, 0), new Position(11, 1), maGrille);
            m5 = new Chariot(new Position(15, 10), new Position(6, 22), maGrille);
            listeCollisions = new List<Position>();

            // ajout des chariots en dur

            mesChariots.Add(m1);
            mesChariots.Add(m2);
            mesChariots.Add(m3);
            // mesChariots.Add(m4);
            // mesChariots.Add(m5);

            mesChemins = new List<NodeChariotTemps>[mesChariots.Count()];

            for (int i = 0; i < mesChariots.Count(); i++)
            {
                mesChemins[i] = new List<NodeChariotTemps>();
            }

            dessin = true;

            initialiseTab(); // initialisation de la grille

            if (dessin)
            {
                this.Paint += new PaintEventHandler(this.dessinTab); // dessin de la grille (entrepot)
            }
        }

        void initialiseChariot(int[] Coord)
        {
            // Récupère les données entrées dans le forms d'initialisation manuelle des chariots
            // Initialisation de la liste mesChariots 
            for (int i = 0; i < Coord.Length; i += 4)
            {
                Chariot ch = new Chariot();
                ch.act = new Position(Coord[i], Coord[i + 1]);
                ch.des = new Position(Coord[i + 2], Coord[i + 3]);
                mesChariots.Add(ch);
            }
        }

        public void initialiseTab()
        {
            // Initialisation de la grille vide
            maGrille = new int[25, 25];
            for (int i = 0; i < 25; i++)
            {
                if (i % 2 == 0 && i != 0 && i != 24)
                {
                    for (int j = 2; j < 23; j++)
                    {
                        if (j != 11 && j != 12 && j != 13)
                        {
                            maGrille[i, j] = 1;
                        }
                    }
                }
                maGrille[i, 0] = 2;
            }
        }

        private void dessinTab(object sender, PaintEventArgs e)
        {
            // dessin de l'entrepot
            if (dessin)
            {
                Graphics graphique = this.CreateGraphics();
                contour.Width = 2;
                for (int j = 0; j < maGrille.GetLength(0); j++)
                {
                    graphique.DrawString(j.ToString(), new Font("Arial", 16), black, j * 40 + 25, -2);
                    for (int i = 0; i < maGrille.GetLength(1); i++)
                    {
                        graphique.DrawRectangle(contour, i * 40 + 20, j * 40 + 20, 40, 40);
                        switch (maGrille[j, i])
                        {
                            case 0: // 0 représente les cases de circulations
                                graphique.FillRectangle(white, i * 40 + 20, j * 40 + 20, 40, 40);
                                break;
                            case 1: // 1 représente les cases étagères
                                graphique.FillRectangle(blue, i * 40 + 20, j * 40 + 20, 40, 40);
                                break;
                            case 2: // 2 représente les zones de chargement
                                graphique.FillRectangle(gray, i * 40 + 20, j * 40 + 20, 40, 40);
                                break;
                        }
                    }
                }
                foreach (Chariot c in mesChariots)
                {
                    // dessin des chariots initial en noir
                    graphique.FillEllipse(black, c.act.y * 40 + 30, c.act.x * 40 + 30, 20, 20);
                    graphique.DrawString("X", new Font("Arial", 20), new SolidBrush(Color.Black), c.des.y * 40 + 25, c.des.x * 40 + 25);
                }
                dessin = false;
            }
        }



        private void GO_Click(object sender, EventArgs e)
        {
            // Les chariots sont placés, l'algorithme pour trouver les meilleurs chemins selon le temps commence
            int compteur = 0;  // compteur permettant de connaitre le numéro du chariot qui est en cours de traitement
            bool cheminFinal = true; // Si un chemin final est trouvé sans collision, prends la valeur true
            List<GenericNode> Lres = null;
            List<GenericNode> Lres2 = null;

            foreach (Chariot c in mesChariots)
            {
                // Pour chaque chariot, on instancie lcollisions, la grille ainsi que le boolean cheminFinal
                List<Position> lcollisions = new List<Position>(); // retiens les collisions temporaires 
                if (cheminFinal)
                {
                    initialiseTab(); 
                }
                cheminFinal = false;
                Graphics graphique = this.CreateGraphics();


                while (!cheminFinal)
                {
                    // Tant qu'un chemin final n'est pas trouvé pour le chariot en cours
                    Position positionChargeSvg = new Position(c.des.x, c.des.y); // On sauvegarde la position finale (change pour le retour à la zone de chargement).
                    //Ainsi, on peut recommencer la recherche du chemin optimale en reprenant l'aglorithme à 0

                    mesChemins[compteur] = new List<NodeChariotTemps>(); // initialisation d'un nouveau chemin de node
                    NodeChariotTemps.initialiserTout(c.act, c.des, maGrille, 0, false); // initialisation de la classe NodeChariotTemps
                    NodeChariotTemps.instancieCollisions(listeCollisions); // on transmet les colliisions éventuellements détectés
                    listeCollisions = new List<Position>();  // remise à 0 de la liste

                    NodeChariotTemps N0 = new NodeChariotTemps(c.act, 1); // On crée la node de départ 
                    Graph g = new Graph();
                    Lres = g.RechercheSolutionAEtoile(N0);
                    if (Lres.Count == 0)
                    {
                        labelsolution.Text = "Pas de solution";
                    }
                    else
                    {
                        labelsolution.Text = "Une solution a été trouvée";
                        foreach (GenericNode N in Lres)
                        {
                            NodeChariotTemps NC = (NodeChariotTemps)N;
                            //listBox1.Items.Add(N);
                            mesChemins[compteur].Add(NC); // ajout de chaque node du chemin vers mesChemins
                        }
                    }
                    labelcountopen.Text = "Nb noeuds finale ouverts : " + g.CountInOpenList().ToString();
                    labelcountclosed.Text = "Nb noeuds finale fermés : " + g.CountInClosedList().ToString();
                    //g.GetSearchTree(treeView1);
                    Graph g2 = new Graph();
                    initialiseTab(); // on réinitialise la grille pour le retour : on applique le meme algorithme, vers la zone de chargement
                    NodeChariotTemps derniereNode = (NodeChariotTemps)Lres[Lres.Count - 1]; // La node de départ est la dernière trouvée
                    NodeChariotTemps.initialiserTout(derniereNode.actuelle, NodeChariotTemps.finale, maGrille, 0, true); 
                    NodeChariotTemps NN0 = new NodeChariotTemps(derniereNode.actuelle, 1); // on commence l'algorithme avec une nouvelle node
                    Lres2 = g2.RechercheSolutionAEtoile(NN0);
                    if (Lres2.Count == 0)
                    {
                        labelsolution.Text = "Pas de solution";
                    }
                    else
                    {
                        labelsolution.Text = "Une solution a été trouvée";
                        foreach (GenericNode N in Lres2)
                        {
                            NodeChariotTemps NC = (NodeChariotTemps)N;
                            //listBox1.Items.Add(N);
                            mesChemins[compteur].Add(NC); // ajout des nodes au chemin en cours
                        }
                        if (compteur > 0) // si on est après le premier chariot, on compare
                        {
                            if (compare(compteur) != null) // Si il y a une collision détectée
                            {
                                List<Position> zonesOccupees = TrouverZonesInterdites(compteur); // Les positions finales sont interdites
                                lcollisions.Add(compare(compteur)); // ajout de la collision
                                initialiseTab(); // réinitialisation du tableau : ainsi, on créer un nouveau tableau avec des 4 à la places des collisions

                                for (int i = 0; i < lcollisions.Count(); i++) // Pour chaque collisions détectés
                                {
                                    maGrille[lcollisions[i].x, lcollisions[i].y] = 4; // on met 4 à cette position, un chariot s'y trouve déjà
                                    listeCollisions.Add(new Position(lcollisions[i].x, lcollisions[i].y)); // la liste des collisions à transmettre est remplie
                                }

                                for (int i = 0; i < zonesOccupees.Count(); i++) // Idem avec les zones occupées (position finales des autres chariots)
                                {
                                    maGrille[zonesOccupees[i].x, zonesOccupees[i].y] = 4;
                                    listeCollisions.Add(zonesOccupees[i]);
                                }
                                Lres = Lres2 = new List<GenericNode>(); // On remet les listes de notes à 0
                                c.des = positionChargeSvg; // la position finale est remis à la valeur initiale
                            }
                            else // sinon, aucune collision n'est détectée
                            {
                                cheminFinal = true; // le chemin final est trouvé
                                compteur++; // on passe donc au chariot suivant
                            }
                        }
                        else // si c'est le premier chemin, il n'ya donc pas de collision
                        {
                            cheminFinal = true;
                            compteur++;
                        }
                    }
                }
               dessinAvanceChariot(Lres, Lres2, graphique); // on lance le dessin du chariot une fois le chemin trouvé
            }
        }

        private Position compare(int i)
        {
            // compare le chemin i avec tous les autres chemins
            for (int u = 0; u < mesChemins.Length; u++) // Pour toutes les nodes du chemins 
            {
                if (u != i && mesChemins[u].Count() > 0) // Si le chemin est différents de lui même, et s'il est plus grand que 0 (donc le chemin à été trouvé)
                {
                    if (mesChemins[i].Count() < mesChemins[u].Count()) // Si le chemin à analysé est moins long que celui auquel il est comparé
                    {
                        for (int j = 0; j < mesChemins[u].Count(); j++) // Parcours du chemin à comparé
                        {
                            if (j < mesChemins[i].Count()) // Tant que la node en cours n'est pas la node finale du chemin analysé
                            {
                                if (mesChemins[i][j].contient(mesChemins[u], j) != null) // on test si la node est contenu dans le chemin comparé, et au même index (== collision)
                                {
                                    return mesChemins[i][j].contient(mesChemins[u], j); // Si oui, on retourne sa position
                                }
                            } // Si la node finale est atteinte, on regarde si elle ne rendre pas en collision avec un chemin plus long qui passerait déjà par cette position
                            else
                            {
                                if (mesChemins[i].Last().contient(mesChemins[u], j) != null)
                                {
                                    return mesChemins[i].Last().contient(mesChemins[u], j);
                                }
                            }
                        }
                    }
                    else if (mesChemins[i].Count() > mesChemins[u].Count()) // Idem, mais avec un chemin plus long
                    {
                        for (int j = 0; j < mesChemins[i].Count(); j++)
                        {
                            if (j < mesChemins[u].Count())
                            {
                                if (mesChemins[i][j].contient(mesChemins[u], j) != null)
                                {
                                    return mesChemins[i][j].contient(mesChemins[u], j);
                                }
                            }
                            else
                            {
                                if (mesChemins[i][j].contient(mesChemins[u].Last()) != null)
                                {
                                    return mesChemins[i][j].contient(mesChemins[u].Last());
                                }
                            }
                        }
                    }
                    else if (mesChemins[i].Count() == mesChemins[u].Count()) // Cas spécial : les chemins sont égaux
                    {

                        for (int j = 0; j < mesChemins[i].Count(); j++)
                        {
                            if (mesChemins[i][j].contient(mesChemins[u], j) != null)
                            {
                                return mesChemins[i][j].contient(mesChemins[u], j);
                            }
                        }
                    }
                }
            }
            return null;
        }

        private List<Position> TrouverZonesInterdites(int i)
        {
            // Permet de trouver les positions finales des chariots, sauf le numéro i, et ainsi les interdire comme destination
            List<Position> l = new List<Position>();
            for (int u = 0; u < mesChemins.Count(); u++)
            {
                if (u != i && mesChemins[u].Count() > 0)
                {
                    l.Add(mesChemins[u].Last().actuelle);
                }
            }
            return l;
        }



        private void dessinAvanceChariot(List<GenericNode> Lres, List<GenericNode> Lres2, Graphics g)
        {
            // dessin de l'avance du chariot
            {
                int i = 0;
                var t = new Thread(() => // On créer un thread par chariot, pour qu'il aient une indépendance
                 {
                     foreach (GenericNode N in Lres)  // Pour l'aller, couleur rouge
                     {
                         // Pour chaque node, on dessine puis on attends les temps décris par le sujet, en se servant du champs cout
                         NodeChariotTemps NC = (NodeChariotTemps)N;
                         Thread.Sleep(NC.cout * 1000 ); // on mutiplie le cout par une seconde d'attente
                         g.FillEllipse(red, NC.actuelle.y * 40 + 30, NC.actuelle.x * 40 + 30, 20, 20); // on dessine l'avancé 

                         if (i > 0)
                         {
                             NodeChariotTemps NCav = (NodeChariotTemps)Lres[i - 1];
                             g.FillEllipse(white, NCav.actuelle.y * 40 + 30, NCav.actuelle.x * 40 + 30, 20, 20); // on efface la position précédente 
                         }
                         i++;
                     }
                     Thread.Sleep(3000);
                     i = 0;
                     foreach (GenericNode N in Lres2) // Pour le retour, couleur verte
                     {
                         NodeChariotTemps NC = (NodeChariotTemps)N;
                         Thread.Sleep(NC.cout * 1000);
                         g.FillEllipse(green, NC.actuelle.y * 40 + 30, NC.actuelle.x * 40 + 30, 20, 20);
                         if (i > 0)
                         {
                             NodeChariotTemps NCav = (NodeChariotTemps)Lres2[i - 1];
                             if (NCav.actuelle.y > 0)
                             {
                                 g.FillEllipse(white, NCav.actuelle.y * 40 + 30, NCav.actuelle.x * 40 + 30, 20, 20);
                             }
                             else
                             {
                                 g.FillEllipse(gray, NCav.actuelle.y * 40 + 30, NCav.actuelle.x * 40 + 30, 20, 20);
                             }
                         }
                         i++;
                     }
                 });
                t.Start();
            }
        }

        public void afficherGrille() // Permet d'afficher la grille pour débugage
        {
            for (int i = 0; i < maGrille.GetLength(0); i++)
            {
                for (int j = 0; j < maGrille.GetLength(1); j++)
                {
                    Console.Write(maGrille[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("****\n");
        }
 

    }


}
