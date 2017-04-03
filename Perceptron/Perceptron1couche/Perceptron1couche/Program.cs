﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron1couche
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chargement du fichier
            ControlerData.chargerFichier("../../classificationAnimal.txt");

            // Tests classe ControllerData
            Console.WriteLine(ControlerData.getNBLines());
            Console.WriteLine(ControlerData.getValuesAtLine(0));
            Console.WriteLine(ControlerData.getValuesAtLine(5));
            Console.WriteLine(ControlerData.getValuesAtLine(ControlerData.getNBLines()-1));
            Console.WriteLine(ControlerData.getAllValues());
            Console.WriteLine(ControlerData.EntreeFactory(0));

            int nbEchantillons = ControlerData.getNBLines();
            int attenduCourant;
            int nbIterations = 0;
            int nbIterationsMax = 20;

            Perceptron p = new Perceptron(ControlerData.EntreeFactory(0)); // initialiser le perceptron avec la première ligne et des poids aléatoires
            do
            {
                p.nbErreur = 0;
                for (int echantillonCourant = 0; echantillonCourant < nbEchantillons; echantillonCourant++)
                {
                    p.nouvelEchantillon(ControlerData.EntreeFactory(echantillonCourant));
                    attenduCourant = ControlerData.getAttenduSelonEchantillon(echantillonCourant);
                    // Effectuer l'algo
                    // Calculer la sortie
                    p.calculerSortie();
                    Console.WriteLine(p.sortie +" = "+ attenduCourant);
                    if (p.sortie != attenduCourant) // Si on obtient pas ce que l'on attendait
                    {
                        p.nbErreur++; // Augmenter le nombre d'erreurs
                        p.ajusterPoid(); // Ajuster les poids
                    }
                }
                nbIterations++;
                Console.WriteLine("Nouvelle itération");
            } while (p.nbErreur != 0 || nbIterations == nbIterationsMax);

            List<double> poids = p.getPoids();
            Console.ReadKey();
        }
    }
}
