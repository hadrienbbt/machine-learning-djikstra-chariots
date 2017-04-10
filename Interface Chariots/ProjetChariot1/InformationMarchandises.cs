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
    public partial class InformationMarchandises : Form
    {
        Pen contour = new Pen(Color.Black);
        private int hauteur;
        public InformationMarchandises(int h)
        {
            InitializeComponent();
            contour.Width = 2;
            hauteur = h;
        }
        private void InformationMarchandises_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(this.dessinerEtagere);
        }

        public void dessinerEtagere(object sender, PaintEventArgs e)
        {
            Graphics graphique = CreateGraphics();
            string hteur = hauteur.ToString();
            NumEtagereLbl.Text = "Etagère n°: " +hteur;
            // SolidBrush blue = new SolidBrush(Color.CornflowerBlue);
            for (int i = 8; i > 0; i--) // Le nombre d'étagères a été fixé à 8
            {
                graphique.DrawRectangle(contour, 40, i * 80, 210, 100);
            }

            Console.WriteLine(hauteur);
            graphique.DrawString("X", new Font("Arial", 20), new SolidBrush(Color.Black), 130, 80 * (9-hauteur) + 30);

        }
    }
}

