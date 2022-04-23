using System;
using System.Text;

namespace lab04
{
    abstract class Combinaison
    {
        class MaxPlusPetitQueMinException : Exception
        {
            public MaxPlusPetitQueMinException(string msg)
            : base(msg) { }
        }

        class CombinaisonImopossibleÀConstruir : Exception
        {
            public CombinaisonImopossibleÀConstruir(string msg)
            : base(msg) { }
        }
        public int NbNombres { get; private set; }
        public int Min { get; private set; }
        public int Max { get; private set; }

        public int[] SuiteDeNombres { get; private set; }

        public Combinaison(int nbNombres, int min, int max)
        {
            if (min > max)
                throw new MaxPlusPetitQueMinException("La borne max doit être extrictement plus grande que la borne min");

            if (nbNombres > max)
                throw new CombinaisonImopossibleÀConstruir("La combinaison ne peut pas être consistruite sans avoir des repetitions d'éléments");

            NbNombres = nbNombres;
            Min = min;
            Max = max;
            SuiteDeNombres = CréerTableau();
        }

        private int[] CréerTableau()
        {
            int[] tab = new int[NbNombres];
            int e;
            for (int i = 0; i < tab.Length; ++i)
            {
                e = Générateur.Next(Min, Max);
                if (EstAbsent(tab, i, e))
                {
                    tab[i] = e;
                }
                else
                {
                    while (!EstAbsent(tab, i, e))
                    {
                        e = Générateur.Next(Min, Max);
                    }
                    tab[i] = e;
                }
            }
            Array.Sort(tab);
            return tab;

        }

        private bool EstAbsent(int[] tab, int dernierIndiceValide, int e)
        {
            bool estAbsent = true;
            for (int i = 0; i < dernierIndiceValide; ++i)
            {
                if (e == tab[i])
                {
                    estAbsent = false;
                    break;
                }
            }
            return estAbsent;
        }




        // classe à compléter

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{SuiteDeNombres[0],2}");
            for (int i = 1; i < SuiteDeNombres.Length; ++i)
            {
                sb.Append($" - {SuiteDeNombres[i],2}");
            }
            return sb.ToString();
        }
    }
}
