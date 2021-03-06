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

        class CombinaisonImpossibleÀConstruireException : Exception
        {
            public CombinaisonImpossibleÀConstruireException(string msg)
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

            if (nbNombres > (max - min))
                throw new CombinaisonImpossibleÀConstruireException("La combinaison ne peut pas être consistruite, le nombre d'éléments n'est pas entre le minimum et maximum");

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
                do
                {
                     e = Générateur.Next(Min, Max);
                }
                while(!EstAbsent(tab, i, e));
                tab[i] = e;
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
