using System;

namespace lab04
{

    class ParticipationToutOuRien : Participation
    {
       const float COUT_PARTICIPATION = 2;
       const int NB_COMBINAISAONS = 1;

       public ParticipationToutOuRien()
       :base( COUT_PARTICIPATION, NB_COMBINAISAONS)
       {
           CréerParticipation(); 
       }

        private void CréerParticipation()
       {
           for(int i = 0; i < NB_COMBINAISAONS; ++ i)
           {
               CombinaisonsParticipation[i] = new ToutOuRien();
           }
       }
    }
}