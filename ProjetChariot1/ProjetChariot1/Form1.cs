using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetChariot1
{
    public partial class Form1 : Form
    {
        SolidBrush blue = new SolidBrush(Color.Blue);
        SolidBrush green = new SolidBrush(Color.Green);
        SolidBrush white = new SolidBrush(Color.White);
        SolidBrush black = new SolidBrush(Color.Black);
        Pen contour = new Pen(Color.Black);

        Chariot monChariot;
        Position positionDepart;
        Position positionDestination;
        int[,] maGrille;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Load");
            maGrille = new int[25, 25];
            positionDepart = new Position(0, 4);
            positionDestination = new Position(11, 14);
            monChariot = new Chariot(positionDepart, positionDestination,maGrille);
            initialiseTab();
            this.Paint += new PaintEventHandler(this.dessinTab);
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
        }

        private void dessinTab(object sender, PaintEventArgs e)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graph g = new Graph();
            NodeChariot N0 = new NodeChariot(positionDepart,ref maGrille, positionDestination);
            N0.finale = positionDestination;
            N0.grille = maGrille;
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
                    NodeChariot NC = (NodeChariot)N;
                    //NC.afficherGrille();
                    Console.WriteLine(" # # # # # #\n");
                }

            }
                labelcountopen.Text = "Nb noeuds des ouverts : " + g.CountInOpenList().ToString();
                labelcountclosed.Text = "Nb noeuds des fermés : " + g.CountInClosedList().ToString();
                g.GetSearchTree(treeView1);
            }

    }
}
