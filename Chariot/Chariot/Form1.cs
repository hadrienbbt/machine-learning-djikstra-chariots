using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chariotIntelligent
{
    public partial class Form1 : Form
    {
        Entrepot entrepot = new Entrepot();
        SolidBrush blue = new SolidBrush (Color.Blue);
        SolidBrush green = new SolidBrush(Color.Green);
        SolidBrush white = new SolidBrush(Color.White);
        SolidBrush black = new SolidBrush(Color.Black);
        Pen contour = new Pen(Color.Black);


        public Form1()
        {
            InitializeComponent();
            initialiseTab();
            entrepot.afficherGrille();
            List<GenericNode> listeTest = entrepot.GetListSucc();
            Console.WriteLine("TEST TRUE : " + entrepot.IsEqual(entrepot));
            foreach (Entrepot entr in listeTest)
            {
                entr.afficherGrille();
                Console.WriteLine("*********************");
                Console.WriteLine("TEST FALSE : " + entrepot.IsEqual(entr));
            }

            Entrepot entrepotResolu = new Entrepot(entrepot.getEndState());
            Console.WriteLine("ETAT FINAL : \n");
            entrepotResolu.afficherGrille();

            if (entrepot.EndState())    Console.WriteLine("L'entrepot actuel est optimal");
            else                        Console.WriteLine("L'entrepot actuel n'est pas optimal");
            // List<GenericNode> solutionAetoile =listeTest.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

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
                            entrepot.grille[i, j] = 1; // rayonnage (1)
                        }
                    }
                }
                entrepot.grille[i, 0] = 2; // zone livraison (2) // libre (0) // chariot (4)
            }
            entrepot.grille[12, 14] = 3;

            this.Paint += new PaintEventHandler(this.dessinTab);
        }

        public void dessinTab(object sender,PaintEventArgs e)
        {
            Graphics graphique = this.CreateGraphics();
            contour.Width = 2;
            for (int j = 0; j < entrepot.grille.GetLength(0); j++)
            {
                for (int i = 0; i< entrepot.grille.GetLength(1); i++)
                {
                    graphique.DrawRectangle(contour, i * 40 + 20, j * 40 + 20, 40, 40);
                    switch (entrepot.grille[j,i])
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
                            graphique.FillEllipse(black, i*40+30, j*40+30, 20, 20);
                            break;

                    }
                }
            }
        }
    }
}
