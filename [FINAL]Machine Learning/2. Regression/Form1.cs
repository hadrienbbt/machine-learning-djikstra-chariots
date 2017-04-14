using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Regression
{
    public partial class Form1 : Form
    {
        Reseau reseau;
        static Graphics g;
        static Bitmap bmp1, bmp2;

        public Form1()
        {
            InitializeComponent();
            ControlerData.chargerFichier("../../datasetregression.txt");
            bmp1 = new Bitmap(500, 500);
            pictureBox1.Image = bmp1;

            bmp2 = new Bitmap(500, 500);
            pictureBox2.Image = bmp2;
        }
        private void InitBtn_Click(object sender, EventArgs e)
        {
            // Initialisation d'un réseau de neurones avec le nombre d'entrées, 
            // le nombre de couches et le nbre de neurones par couches
            reseau = new Reseau(Convert.ToInt32(textBoxnbentrees.Text),
                                        Convert.ToInt32(textBoxnbcouches.Text),
                                        Convert.ToInt32(textBoxnbneurcouche.Text));
        }
        private void ApprentissageBtn_Click(object sender, EventArgs e)
        {
            // En entrée on a une liste de k valeurs réelles correspondant aux k neurones
            // de la 1ère couche dite couche des entrées ou entrées tout court
            // On dispose en général d'une base de données de vecteurs d'entrées
            // c'est pour cela qu'on a une liste de vecteurs, donc une liste de liste 
            List<List<double>> lvecteursentrees = ControlerData.vectFactory(); // x et y entre 0 et 500, z entre 0 et 1
            List<List<double>> lvecteursentreesnormalisees = ControlerData.normaliserVecteur(lvecteursentrees, ControlerData.getPlusGrand("x"));

            // On a 1 seule sortie associée à chaque vecteur d'entrée
            // donc on a seulement 1 liste de réels
            // Attention, on suppose ici que le nième élément de cette liste est
            // la sortie désirée du nième vecteur de levecteurentrees
            List<double> lsortiesdesirees = ControlerData.getAllAttendus();

            reseau.backprop(lvecteursentreesnormalisees, lsortiesdesirees,
                                Convert.ToDouble(textBoxalpha.Text),
                                Convert.ToInt32(textBoxnbiter.Text));
            DessinImage1();
            pictureBox1.Invalidate();
            DessinImage2(lvecteursentrees, lvecteursentreesnormalisees, lsortiesdesirees);
            pictureBox2.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x, z;

            for (x = 0; x < bmp1.Width; x++)
                for (z = 0; z < bmp1.Height; z++)
                {
                    bmp1.SetPixel(x, z, Color.Black);
                    bmp2.SetPixel(x, z, Color.Black);
                }
        }

        private void AfficheInfoBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            reseau.AfficheInfoNeurone(Convert.ToInt32(textBoxnumcouche.Text),
                                       Convert.ToInt32(textBoxnumneur.Text),
                                       listBox1);
        }

        /**********************************************************************/
        public void DessinImage1()
        {
            List<List<double>> vecteursEntree = new List<List<double>>();

            for (int i = 0; i < 500; i++) // 25000 points d'image
            {
                for (int j = 0; j < 500; j++)
                {
                    vecteursEntree.Add(new List<double> {i/500.0,j/500.0});
                }
            }

            List<double> lsortiesobtenues = reseau.ResultatsEnSortie(vecteursEntree);

            int sortieCourante = 0;
            for (int i = 0; i < 500; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    int gray = (int)(lsortiesobtenues[sortieCourante] * 255);
                    bmp1.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                    sortieCourante++;
                }

            }

        }
        public void DessinImage2(List<List<double>> lvecteursentrees, List<List<double>> lvecteursentreesnormalise, List<double> lsortiesdesirees)
        {
            List<double> lsortiesobtenues = reseau.ResultatsEnSortie(lvecteursentreesnormalise);
            int sortieCourante = 0;

            // Affichage de l'erreur max obtenue
            double erreurMax = rechercherErreurMax(lsortiesobtenues, lsortiesdesirees);
            erreurLbl.Text = erreurMax.ToString();
            
            // Affichage du taux d'erreur résiduel
            double TauxErreur = rechercherTauxErreurResiduel(lsortiesobtenues, lsortiesdesirees);
            erreurLbl2.Text = TauxErreur.ToString();


            foreach (List<double> vect in lvecteursentrees)
            {
                double erreur = Math.Abs(255*(lsortiesdesirees[sortieCourante] - lsortiesobtenues[sortieCourante]));
                double coeffErreur = erreur/erreurMax;
                double gray = erreurMax == 0 ? 0 : (255*coeffErreur); // échelle
                bmp2.SetPixel((int)vect[0], (int)vect[1], Color.FromArgb((int)gray, (int)gray, (int)gray));
                sortieCourante++;
            }

        }

        public double rechercherErreurMax(List<double> lsortiesobtenues, List<double> lsortiesdesirees)
        {
            double max = 0;
            for (int i = 0; i < lsortiesdesirees.Count; i++)
            {
                double erreur = Math.Abs(255 * (lsortiesdesirees[i] - lsortiesobtenues[i]));
                if (erreur > max) max = erreur;
            }
            return max;
        }

        public double rechercherTauxErreurResiduel(List<double> lsortiesobtenues, List<double> lsortiesdesirees)
        {
            double sommeErreurs = 0;
            for (int i = 0; i < lsortiesdesirees.Count; i++)
            {
                sommeErreurs += Math.Abs(255 * (lsortiesdesirees[i] - lsortiesobtenues[i]));
            }
            sommeErreurs = sommeErreurs / lsortiesobtenues.Count();

            return sommeErreurs;
        }

    }
}
