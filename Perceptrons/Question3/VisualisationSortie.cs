using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question3
{
	public partial class VisualisationSortie : Form
	{
		static Graphics g;
		static Bitmap bmp1;
		private PictureBox ImageSortiePBox;
		Reseau reseau;
		private List<int> lsortiesdesirees;
		private double marge = 0.2;

		public VisualisationSortie()
		{
			InitializeComponent();
			ControlerData.chargerFichier("../../datasetclassif.txt");
			bmp1 = new Bitmap(800, 800);
			ImageSortiePBox.Image = bmp1;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			List<List<Double>> classeAapprentissage = ControlerData.vectFactory(1);
			List<List<Double>> classeBapprentissage = ControlerData.vectFactory(0);

			List<List<double>> lvecteursapprentissage = ControlerData.intercaler(classeAapprentissage, classeBapprentissage);
			List<List<double>> lvecteursentreesnormalisees = ControlerData.normaliserVecteur(lvecteursapprentissage, 800, 800);

			lsortiesdesirees = ControlerData.intercaler(ControlerData.getAllClasseA(),ControlerData.getAllClasseB());

			// obtenir un nouvel ordre de présentation des vecteurs pour le réseau
			List<int> newOrder = ControlerData.nouvelOrdre(lvecteursentreesnormalisees.Count);
			lsortiesdesirees = ControlerData.melanger(lsortiesdesirees, newOrder);
			lvecteursentreesnormalisees = ControlerData.melanger(lvecteursentreesnormalisees, newOrder);

			reseau.backprop(lvecteursentreesnormalisees, lsortiesdesirees,
								Convert.ToDouble(textBoxalpha.Text),
								Convert.ToInt32(textBoxnbiter.Text));
            List<double> lsortiestestErreurRes = reseau.ResultatsEnSortie(lvecteursentreesnormalisees);
            rechercherTauxErreurResiduel(lsortiestestErreurRes, lsortiesdesirees, this.marge);

            DessinImage();
			DessinPoints();
			ImageSortiePBox.Invalidate();
		}

		private void VisualisationSortie_Load(object sender, EventArgs e)
		{
			int x, z;

			for (x = 0; x < bmp1.Width; x++)
				for (z = 0; z < bmp1.Height; z++)
				{
					bmp1.SetPixel(x, z, Color.Black);
				}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Initialisation d'un réseau de neurones avec le nombre d'entrées, 
			// le nombre de couches et le nbre de neurones par couches
			reseau = new Reseau(Convert.ToInt32(textBoxnbentrees.Text),
										Convert.ToInt32(textBoxnbcouches.Text),
										Convert.ToInt32(textBoxnbneurcouche.Text));
		}

		public void DessinImage()
		{
			List<List<double>> vecteursEntree = new List<List<double>>();

			for (int i = 0; i < 800; i++) // 640000 points d'image
			{
				for (int j = 0; j < 800; j++)
				{
					vecteursEntree.Add(new List<double> {i/800.0, j/800.0});
				}
			}

			List<double> lsortiesobtenues = reseau.ResultatsEnSortie(vecteursEntree);

			int sortieCourante = 0;

			for (int i = 0; i < 800; i++)
			{
				for (int j = 0; j < 800; j++)
				{
					Color couleur = Color.Black;
					if (lsortiesobtenues[sortieCourante] > 0.8)
						couleur = Color.Blue;
					if (lsortiesobtenues[sortieCourante] < 0.2)
						couleur = Color.Yellow;
					bmp1.SetPixel(i, j, couleur);
					sortieCourante++;
				}

			}
		}

		public void DessinPoints()
		{
			List<List<double>> pointsA = ControlerData.vectFactory(1);
			List<List<double>> pointsB = ControlerData.vectFactory(0);

			foreach (var vect in pointsA)
			{
				bmp1.SetPixel((int)vect[0],(int)vect[1],Color.White);
			}

			foreach (var vect in pointsB)
			{
				bmp1.SetPixel((int)vect[0], (int)vect[1], Color.Black);
			}

		}


		public double rechercherErreurMax(List<double> lsortiesobtenues, List<int> lsortiesdesirees)
		{
			double max = 0;
			for (int i = 0; i < lsortiesdesirees.Count; i++)
			{
				double erreur = Math.Abs(lsortiesdesirees[i] - lsortiesobtenues[i]);
				if (erreur > max) max = erreur;
			}
			return max;
		}

		public void rechercherTauxErreurResiduel(List<double> lsortiesobtenues, List<int> lsortiesdesirees, double marge)
		{
			int compteurBonnesReponses = 0;
			int compteurMauvaiseReponses = 0;
			int compteurInclassables = 0;

			// On procède à un filtrage des sorties obtenues pour qu'elles correspondent aux désirées
			for (int i = 0; i < lsortiesobtenues.Count; i++)
			{
				if (lsortiesobtenues[i] > 1-marge) lsortiesobtenues[i] = 1;
				if (lsortiesobtenues[i] < marge) lsortiesobtenues[i] = 0;
			}

            // On repasse ensuite la liste pour comparer les sorties obtenues et désirées
            for (int i = 0; i < lsortiesobtenues.Count; i++)
            {
				if (lsortiesobtenues[i] == lsortiesdesirees[i]) compteurBonnesReponses++;
				else if (lsortiesobtenues[i] < 1 - marge || lsortiesobtenues[i] > marge) compteurInclassables++;
				else compteurMauvaiseReponses++;
			}

            double pourcentageIncertitude = ((double)compteurInclassables / (double)lsortiesobtenues.Count)*100;

            this.incertitudes.Text = pourcentageIncertitude.ToString() + " %";
            this.nbErreurs.Text = compteurMauvaiseReponses.ToString();
            this.nbInclassable.Text = compteurInclassables.ToString();
        }
	}
}
