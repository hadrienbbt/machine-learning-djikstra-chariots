using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Test de la classe ControlerData
            /*ControlerData.chargerFichier("../../datasetregression.txt");
            Console.WriteLine(ControlerData.getNBEchantillons());
            var all = ControlerData.vectFactory();
            var x = ControlerData.ObtenirValeursParEchantillon(ControlerData.getNBEchantillons()-1);
            x = ControlerData.ObtenirValeursParEchantillon(0);
            var y = ControlerData.getAllValues();
            var z = ControlerData.getAllAttendus();
            Console.WriteLine(ControlerData.getPlusGrand());
            */
            Application.Run(new Form1());
        }
    }
}
