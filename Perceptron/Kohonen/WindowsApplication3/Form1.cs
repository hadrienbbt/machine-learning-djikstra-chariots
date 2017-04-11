using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        static List<Observation> lobs = new List<Observation>();
        static public Random random;
        private Graphics g;	// Objet graphique placé en global
        private Bitmap bmp;
        private Pen pen;		// Crayon placé en global
        private int nbcol;      // nb de colonnes de la carte de Kohonen
        private int nblignes;   // nb de lignes de la carte

        CarteSOM SOM;
        static public List<Classe> listclasses = new List<Classe>();

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage( pictureBox1.Image);
            ControlerData.chargerFichier("../../datasetclassif.txt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nbcol = Convert.ToInt32(textBox1.Text);
            nblignes = Convert.ToInt32(textBox2.Text);
            bmp = (Bitmap)pictureBox1.Image;
            pen = new Pen(Color.White, 1);
            g.FillRectangle(pen.Brush, 0, 0, bmp.Width, bmp.Height);
            double u1, u2,r1, r2 ;
            int hasard;


            // Création des données
            List<List<Double>> classeAapprentissage = ControlerData.vectFactory(1);
            List<List<Double>> classeBapprentissage = ControlerData.vectFactory(0);

            //Uniformisation
            List<List<double>> lvecteursapprentissage = ControlerData.intercaler(classeAapprentissage, classeBapprentissage);
            List<int> lsortiesdesirees = ControlerData.intercaler(ControlerData.getAllClasseA(), ControlerData.getAllClasseB());

            // Insertion des données
            lobs.Clear();
            lobs = ControlerData.ObservationFactory(lvecteursapprentissage,0);

            // Creation de la carte SOM
            SOM = new CarteSOM(nbcol, nblignes, 2, bmp.Width);

            AfficheDonnees();
            AfficheCarteSOM();
           pictureBox1.Refresh();
        }

        public void AfficheDonnees()
        {
            for (int i = 0; i < lobs.Count; i++)
            {
                bmp.SetPixel(Convert.ToInt32(lobs[i].Getx()), Convert.ToInt32(lobs[i].Gety()), Color.Red);
            }
        }

        private void AfficheCarteSOM()
        {
           
            int x, y;

            pen.Color = Color.Blue;
            for (int i = 0; i < nbcol; i++)
                for (int j = 0; j < nblignes; j++)
                {
                    x = Convert.ToInt32(SOM.GetNeurone(i,j).GetPoids(0));
                    y = Convert.ToInt32(SOM.GetNeurone(i,j).GetPoids(1));
                    g.DrawEllipse(pen, x - 2, y - 2, 4, 4);

                }
            pictureBox1.Refresh();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SOM.AlgoKohonen(lobs, Convert.ToDouble(textBox3.Text));
            pen.Color = Color.White;
            g.FillRectangle(pen.Brush, 0, 0, bmp.Width, bmp.Height);
            AfficheDonnees();
            AfficheCarteSOM();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listclasses.Clear();
            // Regroupement pour obtenir 2 classes
            SOM.regroupement(lobs,2 );
            pen.Color = Color.White;
            g.FillRectangle(pen.Brush, 0, 0, bmp.Width, bmp.Height);
            AfficheDonnees();

            // Affichage final des 2 classes
            int x, y;
            pen.Color = Color.Blue;
            foreach (Neurone n in listclasses[0].GetNeurones())
                {
                    x = Convert.ToInt32(n.GetPoids(0));
                    y = Convert.ToInt32(n.GetPoids(1));
                    g.DrawEllipse(pen, x - 2, y - 2, 4, 4);
                }

            pen.Color = Color.Yellow;
            foreach (Neurone n in listclasses[1].GetNeurones())
                {
                    x = Convert.ToInt32(n.GetPoids(0));
                    y = Convert.ToInt32(n.GetPoids(1));
                    g.DrawEllipse(pen, x - 2, y - 2, 4, 4);
                }

            pictureBox1.Refresh();  
        }

       
    }
}