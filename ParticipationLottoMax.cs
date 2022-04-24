using System;
using System.Text;

namespace lab04
{
    class ParticipationLottoMax : Participation 
    {
       const float COUT_PARTICIPATION = 5;
       const int NB_COMBINAISAONS = 3;

       public ParticipationLottoMax()
       :base( COUT_PARTICIPATION,NB_COMBINAISAONS)
       {
           CréerParticipation();
       }
       
       private void CréerParticipation()
       {
           for(int i = 0; i < NB_COMBINAISAONS; ++ i)
           {
               CombinaisonsParticipation[i] = new LottoMax();
           }
       }
    }
}