using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Question3
{
    static class ControlerData
    {
        private static string filename; 
		private static Random rnd = new Random();

        public static void chargerFichier(string oneFileName) { filename = oneFileName; }

        public static Dictionary<string, Double> ObtenirValeursParEchantillon(int numEchantillon)
        {
            // Cas d'exception
            if (numEchantillon >= ControlerData.getNBEchantillons() || numEchantillon < 0) throw new Exception("numLine invalide");

            Dictionary<string, Double> res = new Dictionary<string, Double>();
            int counter = 0;
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(filename);

            for (int i = 0; i < numEchantillon; i++)
            {
                file.ReadLine(); file.ReadLine(); file.ReadLine();
            }

            line = file.ReadLine();
            res["num"] = Double.Parse(line);
            line = file.ReadLine();
            res["x"] = Double.Parse(line);
            line = file.ReadLine();
            res["y"] = Double.Parse(line);

            file.Close();
            return res;
        }

        public static int getAttenduSelonEchantillon(int numEchantillon) // A = 1 ; B = 0
        {
            return numEchantillon <= 1500 ? 1 : 0;
        }

        public static List<Dictionary<string, Double>> getAllValues()
        {
            List<Dictionary<string, Double>> res = new List<Dictionary<string, Double>>();
            Dictionary<string, Double> tmp;

            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(filename);

            for (int i = 0; i < getNBEchantillons(); i++)
            {
                tmp = new Dictionary<string, Double>();
                line = file.ReadLine();
                tmp["num"] = Double.Parse(line);
                line = file.ReadLine();
                tmp["x"] = Double.Parse(line);
                line = file.ReadLine();
                tmp["y"] = Double.Parse(line);
                res.Add(tmp);

            }
            file.Close();
            return res;
        }

        public static int getNBLines()
        {
            int counter = 0;
            System.IO.StreamReader file = new System.IO.StreamReader(filename);
            while (file.ReadLine() != null) {counter++; }
            file.Close();
            return counter;
        }

        public static int getNBEchantillons()
        {
            return ControlerData.getNBLines()/3;
        }

        public static List<List<double>> vectFactory()
        {
            List<Dictionary<string,double>> tmp = ControlerData.getAllValues();
            List<double> tmp2;
            List<List<double>> res = new List<List<double>>();

            foreach (var item in tmp)
            {
                tmp2 = new List<double>();
                tmp2.Add(item["x"]);
                tmp2.Add(item["y"]);
                res.Add(tmp2);
            }
           
            return res;
        }

        public static List<List<double>> vectFactory(int classe) // A = 1 ; B = 0
        {
            List<List<Double>> res = new List<List<double>>();
            int offset = classe == 1 ? 0 : 1500;
            int tailleEch = 1500;

            StreamReader sr = new StreamReader(filename);
            for (int i = 0; i < offset*3; i++) sr.ReadLine();
            string line = sr.ReadLine();

            for (int i = 0; i < tailleEch; i++)
            {
                res.Add(new List<double> ());
                line = sr.ReadLine();
                res[res.Count - 1].Add(Double.Parse(line));
                line = sr.ReadLine();
                res[res.Count - 1].Add(Double.Parse(line));
                sr.ReadLine();
            }

            return res;
        }

		public static void Shuffle<T>(this IList<T> list)
		{
			int n = list.Count;
			while (n > 1)
			{
				n--;
				int k = ControlerData.rnd.Next(n + 1);
				T value = list[k];
				list[k] = list[n];
				list[n] = value;
			}
		}

		public static List<int> nouvelOrdre(int taille)
        {
			// Initialiser une liste des 3000 premiers int
			List<int> pioche = new List<int>();
			for (int i = 0; i < taille; i++) pioche.Add(i);

            ControlerData.Shuffle(pioche);

			return pioche;
        }

		public static List<int> melanger(List<int> liste, List<int> ordre) {
			List<int> res = new List<int>();
			for (int i = 0; i < 3000; i++) res.Add(0);

			int counter = 0;
			foreach (var position in ordre)
			{
				res[position] = liste[counter];
				counter++;
			}

			return res;
		}

		public static List<List<double>> melanger(List<List<double>> liste, List<int> ordre)
		{
			List<List<double>> res = new List<List<double>>();
			for (int i = 0; i < 3000; i++) res.Add(new List<double>());

			int counter = 0;
			foreach (var position in ordre)
			{
				res[position] = liste[counter];
				counter++;
			}

			return res;
		}

        public static List<List<double>> intercaler(List<List<double>> l1, List<List<double>> l2)
        {
            List<List<double>> res = new List<List<double>>();
            

            for (int i = 0; i < (l1.Count > l2.Count ? l1.Count : l2.Count); i++)
            {
                if (i < l1.Count) res.Add(l1[i]);
                if (i < l2.Count) res.Add(l2[i]);

            }
            return res;
        }

        public static List<int> intercaler(List<int> l1, List<int> l2)
        {
            List<int> res = new List<int>();


            for (int i = 0; i < (l1.Count > l2.Count ? l1.Count : l2.Count); i++)
            {
                if (i < l1.Count) res.Add(l1[i]);
                if (i < l2.Count) res.Add(l2[i]);

            }
            return res;
        }

        public static List<int> getAllClasseA()
        {
            List<int> mesuresA = new List<int>();

            for (int i = 0; i < 1500; i++)
            {
                mesuresA.Add(ControlerData.getAttenduSelonEchantillon(i));
            }

            return mesuresA;

        }

        public static List<int> getAllClasseB()
        {
            List<int> mesuresB = new List<int>();

            for (int i = 1501; i <= 3000; i++)
            {
                mesuresB.Add(ControlerData.getAttenduSelonEchantillon(i));
            }

            return mesuresB;
        }

        public static double getPlusGrand(string key)
        {
            List<Dictionary<string, Double>> tmp = ControlerData.getAllValues();
            Double x = 0;
            foreach (var elem in tmp)
            {
                if (elem[key] > x) x = elem[key];
            }
            return x;
        }

        public static List<List<Double>> normaliserVecteur(List<List<Double>> listeBase, double valMaxX, double valMaxY)
        {
            List<List<Double>> res = new List<List<double>>();

            for (int i = 0; i < listeBase.Count; i++)
            {
                res.Add(new List<double>());
                res[i].Add(listeBase[i][0]/valMaxX);
                res[i].Add(listeBase[i][1]/valMaxY);
            }

            Console.WriteLine(res);
            return res;
        }
    }
}
