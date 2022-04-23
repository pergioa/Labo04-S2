using System;

namespace lab04
{
    // Note : l'héritage doit être rétabli dans la version à remettre de votre 
    // laboratoire. La mise en commentaire est là pour que le projet compile au
    // moment de vous le remettre entre les mains. 
    class ToutOuRien : Combinaison
    {
        const int NB_NOMBRES = 12;
        const int MIN = 1;
        const int MAX = 24;

        public ToutOuRien()
        :base(NB_NOMBRES, MIN, MAX){}
    }
}
