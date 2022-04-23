using System;

namespace lab04
{
    static class Générateur
    {
        const int Germe = 22;
        
        static Random Gen { get; set; }

        /// <summary>
        /// Instanciation et initialisation du générateur de nombres
        /// aléatoires.
        /// </summary>
        static Générateur()
        {
            // On pourra enlever le Germe d'ici une fois que nos tests seraient terminés
            Gen = new Random(Germe);
        }

        /// <summary>
        /// Permet de retourner un entier entre une valeur min et une
        /// valeur max
        /// 
        /// </summary>
        /// <param name="min">Valeur min du nombre à générer</param>
        /// <param name="max">Valeur max du nombre à générer</param>
        /// <returns>un nombre entier aléatoirement choisie dans l'intervalle [min, max[</returns>
        static public int Next(int min, int max)
        {
            // à faire 
            return 0; // instruction dont le seul but est que ça compile
        }
    }
}
