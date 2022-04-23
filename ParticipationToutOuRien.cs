using System;

namespace lab04
{

    class ParticipationToutOuRien : Participation
    {
       const float COUT_PARTICIPATION = 2;
       const int NB_COMBINAISAONS = 1;

       public ParticipationToutOuRien()
       :base( COUT_PARTICIPATION)
       {
           CombinaisonsParticipation = CréerParticipation(); 
       }

        private Combinaison[] CréerParticipation()
       {
           
           Combinaison[] tab = new Combinaison[NB_COMBINAISAONS];
           for(int i = 0; i < NB_COMBINAISAONS; ++ i)
           {
               tab[i] = new ToutOuRien();
           }
           return tab;
       }
    }
}