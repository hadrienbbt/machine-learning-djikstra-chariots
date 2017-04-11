using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WindowsFormsApplication1
{
    static class ControlerData
    {
        private static string filename;
        
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
                line = file.ReadLine(); line = file.ReadLine(); line = file.ReadLine(); line = file.ReadLine();
            }

            line = file.ReadLine();
            res["num"] = Double.Parse(line);
            line = file.ReadLine();
            res["x"] = Double.Parse(line);
            line = file.ReadLine();
            res["y"] = Double.Parse(line);
            line = file.ReadLine();
            res["z"] = Double.Parse(line);

            file.Close();
            return res;
        }

        public static double getAttenduSelonEchantillon(int numEchantillon) {
            return ObtenirValeursParEchantillon(numEchantillon)["z"];
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
                line = file.ReadLine();
                tmp["z"] = Double.Parse(line);
                res.Add(tmp);

            }
            file.Close();
            return res;
        }

        public static int getNBELines()
        {
            int counter = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(filename);
            while ((line = file.ReadLine()) != null) {counter++; }
            file.Close();
            return counter;
        }

        public static int getNBEchantillons()
        {
            return ControlerData.getNBELines()/4;
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

        public static List<double> getAllAttendus()
        {
            List<double> res = new List<double>();
            List<Dictionary<string,double>> valeurs = ControlerData.getAllValues();

            foreach (var element in valeurs)
            {
                res.Add(element["z"]);
            }

            return res;
        }

        public static int getPlusGrand(string key)
        {
            List<Dictionary<string, Double>> tmp = ControlerData.getAllValues();
            Double x = 0;
            foreach (var elem in tmp)
            {
                if (elem[key] > x) x = elem[key];
            }
            return Int32.Parse(x.ToString());
        }

        public static List<List<Double>> normaliserVecteur(List<List<Double>> listeBase, int valMax)
        {
            List<List<Double>> res = new List<List<double>>();

            for (int i = 0; i < listeBase.Count; i++)
            {
                res.Add(new List<double>());
                for (int j = 0; j < listeBase[i].Count; j++)
                {
                    res[i].Add(listeBase[i][j]/valMax);
                }
            }

            Console.WriteLine(res);
            return res;
        }
    }
}
