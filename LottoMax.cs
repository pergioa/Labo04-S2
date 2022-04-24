using System;

namespace lab04
{
    class LottoMax : Combinaison
    {
        const int NB_NOMBRES = 7;
        const int MIN = 1;
        const int MAX = 50;

        public LottoMax()
        :base(NB_NOMBRES, MIN, MAX){}

    }
}
