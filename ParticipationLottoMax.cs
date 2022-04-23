using System;
using System.Text;

namespace lab04
{
    class ParticipationLottoMax : Participation 
    {
       const float COUT_PARTICIPATION = 5;
       const int NB_COMBINAISAONS = 3;

       public ParticipationLottoMax()
       :base( COUT_PARTICIPATION)
       {
           CombinaisonsParticipation = CréerParticipation();
       }

       private Combinaison[] CréerParticipation()
       {
           Combinaison[] tab = new Combinaison[NB_COMBINAISAONS];
           for(int i = 0; i < NB_COMBINAISAONS; ++ i)
           {
               tab[i] = new LottoMax();
           }
           return tab;
       }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}