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

    // Note : 1 correspond au rayonnage, 2 à la zone de livraison, 3 aux colis et 4 au chariots

    public partial class Form1 : Form
    {
        SolidBrush blue = new SolidBrush(Color.Blue);
        SolidBrush green = new SolidBrush(Color.Green);
        SolidBrush white = new SolidBrush(Color.White);
        SolidBrush black = new SolidBrush(Color.Black);
        SolidBrush red = new SolidBrush(Color.Red);
        Pen contour = new Pen(Color.Black);

        Chariot monChariot;
        Position positionDepart;
        Position positionDestination;
        int[,] maGrille;
        bool dessin;

        public Form1()
        {
            InitializeComponent();
            maGrille = new int[25, 25];
            positionDepart = new Position(24, 20);
            positionDestination = new Position(12, 14);
            monChariot = new Chariot(positionDepart, positionDestination, maGrille);
            dessin = true;
            initialiseTab();
            if (dessin)
            {
                this.Paint += new PaintEventHandler(this.dessinTab);
            }
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
                            maGrille[i, j] = 1;
                        }
                    }
                }
                maGrille[i, 0] = 2;
            }
            maGrille[12, 14] = 3;

        }

        private void dessinTab(object sender, PaintEventArgs e)
        {
            if (dessin) {
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



        private void button1_Click(object sender, EventArgs e)
        {
            maGrille[monChariot.act.x, monChariot.act.y] = 4;
            Graphics graphique = this.CreateGraphics();

            Graph g = new Graph();
            NodeChariotTemps.initialiserTout(monChariot.act, monChariot.des, maGrille,0,false);
            NodeChariotTemps N0 = new NodeChariotTemps(monChariot.act,1);


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
                    NodeChariotTemps NC = (NodeChariotTemps)N;
                    graphique.FillRectangle(white, NC.actuelle.y * 40 + 20, NC.actuelle.x * 40 + 20, 40, 40);
                    graphique.FillEllipse(red, NC.actuelle.y * 40 + 30, NC.actuelle.x * 40 + 30, 20, 20);
                }

            }
                labelcountopen.Text = "Nb noeuds finale ouverts : " + g.CountInOpenList().ToString();
                labelcountclosed.Text = "Nb noeuds finale fermés : " + g.CountInClosedList().ToString();
                g.GetSearchTree(treeView1);
            
            Position livraison = new Position(25, 20);
            Graph g2 = new Graph();
            maGrille =  new int[25, 25];
            initialiseTab();
            NodeChariotTemps derniereNode = (NodeChariotTemps)Lres[Lres.Count - 1];
            NodeChariotTemps.initialiserTout(derniereNode.actuelle, livraison, maGrille, 0,true);
            NodeChariotTemps NN0 = new NodeChariotTemps(derniereNode.actuelle, 1);
            NN0.prendreObjet();
            List<GenericNode> Lres2;
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
                    listBox1.Items.Add(N);
                    NodeChariotTemps NC = (NodeChariotTemps)N;
                    graphique.FillRectangle(white, NC.actuelle.y * 40 + 20, NC.actuelle.x * 40 + 20, 40, 40);
                    graphique.FillEllipse(green, NC.actuelle.y * 40 + 30, NC.actuelle.x * 40 + 30, 20, 20);
                }

            }
        }

        public void dessinAvanceChariot(int cout, int x, int y, SolidBrush myBrush)
        {
          //  switch(cout)
        }

        public void dessinChargement(int tempsCharge)
        {
            // ICI, dessin chargement le temps de temps charge, calculé à NN0. prendre objet
        }


    }
}
