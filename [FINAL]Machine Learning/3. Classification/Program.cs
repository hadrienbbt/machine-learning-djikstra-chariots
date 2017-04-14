using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classification
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Tests du ControlerData
           /* ControlerData.chargerFichier("../../datasetclassif.txt");
            List<List<Double>> classeAtest = ControlerData.vectFactory(false, 1);
            List<List<Double>> classeAapprentissage = ControlerData.vectFactory(true, 1);
            List<List<Double>> classeBtest = ControlerData.vectFactory(false, 0);
            List<List<Double>> classeBapprentissage = ControlerData.vectFactory(true, 0);
            List<List<double>> lvecteursapprentissage = ControlerData.intercaler(classeAapprentissage, classeBapprentissage);
            List<List<double>> lvecteursentreesnormalisees = ControlerData.normaliserVecteur(lvecteursapprentissage, ControlerData.getPlusGrand("x"), ControlerData.getPlusGrand("y"));
            */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VisualisationSortie());
        }
    }
}
