using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Perceptron1couche
{
    static class ControlerData
    {
        private static string filename;
        
        public static void chargerFichier(string oneFileName) { filename = oneFileName; }

        public static Dictionary<string, Double> getValuesAtLine(int numLine)
        {
            // Cas d'exception
            if (numLine >= ControlerData.getNBLines() || numLine < 0) throw new Exception("numLine invalide");

            Dictionary<string,Double> res = new Dictionary<string, Double>();
            int counter = 0;
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(filename);
            do
            {
                line = file.ReadLine();
                counter++;
            } while (counter <= numLine);

            string[] tabValues = line.Split('/');
            res["attendu"] = tabValues[0] == "A" ? 1 : 0; // A = sortie 1 et B = sortie 0 selon énoncé
            res["x"] = Double.Parse(tabValues[1]);
            res["y"] = Double.Parse(tabValues[2]);

            file.Close();
            return res;
        }

        public static int getAttenduSelonEchantillon(int numEchantillon) {
            return int.Parse(getValuesAtLine(numEchantillon)["attendu"].ToString());
        }

        public static List<Dictionary<string, Double>> getAllValues()
        {
            List<Dictionary<string, Double>> res = new List<Dictionary<string, Double>>();

            for (int i = 0; i < getNBLines(); i++)  res.Add(getValuesAtLine(i));

            return res;
        }

        public static int getNBLines()
        {
            int counter = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(filename);
            while ((line = file.ReadLine()) != null) {counter++; }
            file.Close();
            return counter;
        }

        public static List<Entree> EntreeFactory(int numEchantillon)
        {
            List<Entree> res = new List<Entree>();
            Dictionary<string, Double> echantillon = ControlerData.getValuesAtLine(numEchantillon);

            res.Add(new Entree("x", echantillon["x"]));
            res.Add(new Entree("y", echantillon["y"]));
            res.Add(new Entree("c", 1));

            return res;
        }
    }
}
