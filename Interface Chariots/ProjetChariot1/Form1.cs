using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        SolidBrush red = new SolidBrush(Color.Red);
        Pen contour = new Pen(Color.Black);

        Chariot monChariot;
        Position positionMarchandise;
        Position positionDepart;
        Position positionDestination;

        int[,] maGrille;
        Dictionary<Position, int> marchandises;
        int XFenetre, YFenetre,positionX, positionY, compteur;
        private bool modifierPosition, bloquerPosition;

        private int nbChariotMarchandise;

        public Form1()
        {
            InitializeComponent();
            YFenetre = Bounds.Top + 70;
            XFenetre = Bounds.Left + 20;
            marchandises = new Dictionary<Position, int>(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            maGrille = new int[25, 25];
            nbChariotMarchandise = 3; // Autant de chariots que de marchandises (nb fixé arbitrairement)
            initialiserTab();
        }

        public void initialiserTab()
        {
            Random k = new Random();
            int xMarchandise, yMarchandise, hauteur;

            for (int i = 0; i < 25; i++)
            {
                if (i%2 == 0 && i != 0 && i != 24)
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

            for (int i = 0; i <= nbChariotMarchandise; i++) // On positionne aléatoirement sur la grille les marchandises
            {
                do
                {
                    xMarchandise = k.Next(0, 25);
                    yMarchandise = k.Next(0, 25);
                }
                while (maGrille[xMarchandise, yMarchandise] != 1);

                maGrille[xMarchandise, yMarchandise] = 3;
                hauteur = k.Next(1, 9);
                positionMarchandise = new Position(xMarchandise,yMarchandise);
                marchandises.Add(positionMarchandise,hauteur);
            }

            this.Paint += new PaintEventHandler(this.dessinerGrille);
        }

        private void MarchandisesBtn_Click(object sender, EventArgs e)
        {
            // On identifie la marchandise sélectionnée

            MessageBox.Show(
                "Pour avoir des informations sur les marchandises, cliquez sur l'une des X présentes sur la grille.");
        }

        private void dessinerGrille(object sender, PaintEventArgs e)
        {
            Graphics graphique = this.CreateGraphics();
            contour.Width = 2;

            for (int j = 0; j < maGrille.GetLength(0); j++)
            {
                for (int i = 0; i < maGrille.GetLength(1); i++)
                {
                    graphique.DrawRectangle(contour, i*40 + 20, j*40 + 20, 40, 40);
                    switch (maGrille[j, i])
                    {
                        case 0:
                            graphique.FillRectangle(white, i*40 + 20, j*40 + 20, 40, 40);
                            break;
                        case 1:
                            graphique.FillRectangle(blue, i*40 + 20, j*40 + 20, 40, 40);

                            break;
                        case 2:
                            graphique.FillRectangle(green, i*40 + 20, j*40 + 20, 40, 40);
                            break;
                        case 3:
                            graphique.FillRectangle(blue, i*40 + 20, j*40 + 20, 40, 40);
                            graphique.DrawString("X", new Font("Arial", 20), new SolidBrush(Color.Black), i*40 + 25,j*40 + 25);
                            break;
                    }
                }
            }
        }
        private void positionnerChariot()
        {
            positionDepart = new Position(positionX, positionY);
            monChariot = new Chariot(positionDepart, positionDestination, maGrille);

            Graphics graphique = this.CreateGraphics();
            SolidBrush orange = new SolidBrush(Color.Coral);
            SolidBrush pink = new SolidBrush(Color.MediumVioletRed);
            SolidBrush khaki = new SolidBrush(Color.Khaki);
            SolidBrush gray = new SolidBrush(Color.LightSlateGray);

            switch (compteur)
            {
                case 0:
                    graphique.FillEllipse(orange, 27 + 40 * positionX, 27 + 40 * positionY, 25, 25);
                    break;
                case 1:
                    graphique.FillEllipse(pink, 27 + 40 * positionX, 27 + 40 * positionY, 25, 25);
                    break;
                case 2:
                    graphique.FillEllipse(khaki, 27 + 40 * positionX, 27 + 40 * positionY, 25, 25);
                    break;
                case 3:
                    graphique.FillEllipse(gray, 27 + 40 * positionX, 27 + 40 * positionY, 25, 25);
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphique = this.CreateGraphics();
            Graph g = new Graph();
            NodeChariot.initialiserTout(monChariot.act, monChariot.des, maGrille);
            NodeChariot N0 = new NodeChariot(monChariot.act);

            List<GenericNode> Lres = g.RechercheSolutionAEtoile(N0);
            if (Lres.Count == 0)
            {
                labelsolution.Text = "Pas de solution";
            }
            else
            {
                foreach (GenericNode N in Lres)
                {
                    listBox1.Items.Add(N);
                    NodeChariot NC = (NodeChariot) N;
                    graphique.FillRectangle(white, NC.actuelle.y*40 + 20, NC.actuelle.x*40 + 20, 40, 40);
                    graphique.FillEllipse(red, NC.actuelle.y*40 + 30, NC.actuelle.x*40 + 30, 20, 20);
                }

            }

            g.GetSearchTree(treeView1);
        }
        private void SelectionChariot(object sender, MouseEventArgs e)
        { 
                if (modifierPosition) // Si l'utilisateur bouge la fenêtre, on recalcule la position-curseur
                {
                    positionX = (MousePosition.X - XFenetre - 30)/40;
                    positionY = (MousePosition.Y - YFenetre - 10)/40;
                }
                else // Si la fenêtre winform n'a pas été déplacée
                {
                    positionX = (MousePosition.X - (this.Left + XFenetre) - 10)/40;
                    positionY = (MousePosition.Y - YFenetre - 30)/40;
                }

                Position positionCurseur = new Position(positionY, positionX);

                foreach (KeyValuePair<Position, int> marchandise in marchandises)
                    {

                        if (positionCurseur.x == marchandise.Key.x && positionCurseur.y == marchandise.Key.y)
                        {
                        InformationMarchandises m = new InformationMarchandises(marchandise.Value);
                        m.Show();
                        }
                    }

                if (!bloquerPosition)
                {
                if (maGrille[positionY, positionX] != 1 && maGrille[positionY, positionX] != 4 && maGrille[positionY, positionX] != 3)
                    {
                        PositionChoisieLbl.Text = "(" + positionX + "," + positionY + ") \n";
                        PositionChoisieLbl.Visible = true;
                        positionnerChariot();
                        compteur++;
                        if (compteur > nbChariotMarchandise)
                        {
                            bloquerPosition = true;
                        }
                }


            }
        }
        private void Redimensionnement_Fenetre_Fin(object sender, EventArgs e)
        {
            XFenetre = this.Bounds.Left;
            YFenetre = (this.Bounds.Top+50);
            modifierPosition = true;
        }
    }
}
