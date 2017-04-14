using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron1couche
{
    public class Entree
    {
        private string label { get; set; }
        private Double value { get; set; }

        public Entree(string unLabel, Double uneValeur)
        {
            this.label = unLabel;
            this.value = uneValeur;
        }

        // Accesseurs
        public Double getValue() { return this.value; }
        public void setValue(Double uneValeur) { this.value = uneValeur; }
    }
}
