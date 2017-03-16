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
        static Entrepot e = new Entrepot();
        SolidBrush blue = new SolidBrush (Color.Blue);
        SolidBrush green = new SolidBrush(Color.Green);
        SolidBrush white = new SolidBrush(Color.White);
        SolidBrush black = new SolidBrush(Color.Black);

        Pen contour = new Pen(Color.Black);
        int[,] entrepot = e.grille;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initialiseTab();

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
                            entrepot[i, j] = 1; // rayonnage (1)
                        }
                    }
                }
                entrepot[i, 0] = 2; // zone livraison (2) // libre (0) // chariot (4)
            }
            entrepot[12, 14] = 3;
            entrepot[15, 18] = 4;

            this.Paint += new PaintEventHandler(this.dessinTab);
        }

        public void dessinTab(object sender,PaintEventArgs e)
        {
            Graphics graphique = this.CreateGraphics();
            contour.Width = 2;
            for (int i = 0; i < entrepot.GetLength(0); i++)
            {
                for (int j = 0; j < entrepot.GetLength(1); j++)
                {
                    graphique.DrawRectangle(contour, i * 40 + 20, j * 40 + 20, 40, 40);
                    switch (entrepot[j, i])
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
