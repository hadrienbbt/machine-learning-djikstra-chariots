using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Perceptron1couche
{
    public class Perceptron
    {
        // int : numéro de l'entrée
        // Double : poid associé
        private Dictionary<Entree,Double> poidsParEntree = new Dictionary<Entree, Double>();
        public int nbErreur { get; set; }
        public int seuil    { get; set; }
        public int sortie   { get; set; }
        private Random rnd = new Random();

        public Perceptron(List<Entree> desEntrees) {
            // Initialiser aléatoirement toutes les entrées
            foreach (Entree e in desEntrees) poidsParEntree.Add(e, rnd.Next(-50, 50));
            this.nbErreur = 0;
            this.seuil = 0;
        }

        // Donne de nouvelles valeurs aux entrées
        public void nouvelEchantillon(List<Entree> nouvellesEntrees)
        {
            int i = 0;
            foreach (KeyValuePair<Entree, Double> entry in poidsParEntree)
            {
                // do something with entry.Value or entry.Key
                entry.Key.setValue(nouvellesEntrees[i].getValue());
                i++;
            }
        }

        // Calcule une sortie selon l'état courant du perceptron
        public void calculerSortie()
        {
            this.sortie = this.seuillage(this.calculerSommePonderee());
        }

        // Calcule somme ponderee
        public double calculerSommePonderee()
        {
            double somme = 0;
            foreach (KeyValuePair<Entree, Double> attribut in this.poidsParEntree)
            {
                somme += attribut.Key.getValue() * attribut.Value; // Ei * wi
            }
            return somme;
        }

        public int seuillage(double value) { return value <= this.seuil ? 0 : 1; }

        public void ajusterPoid()
        {
            if(this.sortie == 0) // Wi <- Wi + Ei	pour chaque Wi
                foreach (Entree entry in this.poidsParEntree.Keys.ToList())
                    this.poidsParEntree[entry] += entry.getValue();
            else // Wi <- Wi – Ei	pour chaque Wi
                foreach (Entree entry in this.poidsParEntree.Keys.ToList())
                    this.poidsParEntree[entry] -= entry.getValue();
        }

        public List<double> getPoids()
        {
            List<double> res = new List<double>();

            foreach (KeyValuePair<Entree, double> entry in this.poidsParEntree)
                res.Add(entry.Value);
            return res;
        }

        // Accesseurs
        public Dictionary<Entree, Double> getEntrees() { return this.poidsParEntree; }
        public void setEntrees (Dictionary<Entree, Double> desEntrees) { this.poidsParEntree = desEntrees; }

    }
}
