using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetChariot1
{
    public partial class Form2 : Form
    {

        SolidBrush blue = new SolidBrush(Color.Blue);
        SolidBrush green = new SolidBrush(Color.Green);
        SolidBrush white = new SolidBrush(Color.White);
        SolidBrush black = new SolidBrush(Color.Black);
        SolidBrush red = new SolidBrush(Color.Red);
        Pen contour = new Pen(Color.Black);

        bool dessin = true;

        Chariot monChariot;
        Position positionDepart;
        Position positionDestination;
        int[,] maGrille;
        public Form2()
        {
            InitializeComponent();
            Console.WriteLine("Load");
            maGrille = new int[25, 25];
            positionDepart = new Position(24, 0);
            positionDestination = new Position(11, 14);
            monChariot = new Chariot(positionDepart, positionDestination, maGrille);
            initialiseTab();
            Console.WriteLine("Fin Load");
        }



        public void initialiseTab()
        {
                 for (int i = 0; i < 25; i++)
                {
                    if (i % 2 == 0 && i != 0 && i != 24)
                    {
                        for (int j = 2; j < 23; j++)
                        {
                            if (j != 11 && j != 12 && j != 13)
                            {
                                maGrille[i, j] = 1; // rayonnage (1)
                            }
                        }
                    }
                    maGrille[i, 0] = 2; // zone livraison (2) // libre (0) // chariot (4)
                }
                maGrille[12, 14] = 3;
                maGrille[monChariot.act.x, monChariot.act.y] = 4;
                this.Paint += new PaintEventHandler(this.dessinTab);

        }

        private void dessinTab(object sender, PaintEventArgs e)
        {
        if (dessin)
        {
            Console.WriteLine("Dessin");
            Graphics graphique = this.CreateGraphics();
            contour.Width = 2;
            for (int j = 0; j < maGrille.GetLength(0); j++)
            {
                for (int i = 0; i < maGrille.GetLength(1); i++)
                {
                    graphique.DrawRectangle(contour, i * 40 + 20, j * 40 + 20, 40, 40);
                    switch (maGrille[j, i])
                    {
                        case 0:
                            graphique.FillRectangle(white, i * 40 + 20, j * 40 + 20, 40, 40);
                            break;
                        case 1:
                            graphique.FillRectangle(blue, i * 40 + 20, j * 40 + 20, 40, 40);

                            break;
                        case 2:
                            graphique.FillRectangle(green, i * 40 + 20, j * 40 + 20, 40, 40);
                            break;
                        case 3:
                            graphique.FillRectangle(blue, i * 40 + 20, j * 40 + 20, 40, 40);
                            graphique.DrawString("X", new Font("Arial", 20), new SolidBrush(Color.Black), i * 40 + 25, j * 40 + 25);
                            break;
                        case 4:
                            graphique.FillRectangle(white, i * 40 + 20, j * 40 + 20, 40, 40);
                            graphique.FillEllipse(black, i * 40 + 30, j * 40 + 30, 20, 20);
                            break;

                    }
                }
                }
                dessin = false;
            }
        }



   

        private void GO_BT_Click(object sender, EventArgs e)
        {
            Graphics graphique = this.CreateGraphics();

            Graph g = new Graph();
            NodeChariotChemin.initialiserTout(monChariot.act, monChariot.des, maGrille);
            NodeChariotChemin N0 = new NodeChariotChemin(monChariot.act);


            // N0.afficherGrille();
            Console.WriteLine("####################\n");

            List<GenericNode> Lres = g.RechercheSolutionAEtoile(N0);
            if (Lres.Count == 0)
            {
                labelsolution.Text = "Pas de solution";
            }
            else
            {
                labelsolution.Text = "Une solution a été trouvée";
                foreach (GenericNode N in Lres)
                {
                    listBox1.Items.Add(N);
                    NodeChariotChemin NC = (NodeChariotChemin)N;
                    graphique.FillRectangle(white, NC.actuelle.y * 40 + 20, NC.actuelle.x * 40 + 20, 40, 40);
                    graphique.FillEllipse(red, NC.actuelle.y * 40 + 30, NC.actuelle.x * 40 + 30, 20, 20);
                }

            }
            labelcountopen.Text = "Nb noeuds finale ouverts : " + g.CountInOpenList().ToString();
            labelcountclosed.Text = "Nb noeuds finale fermés : " + g.CountInClosedList().ToString();
            g.GetSearchTree(treeView1);
            dessin = true;
        }
    }
}
