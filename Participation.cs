using System;
using System.Text;

namespace lab04
{
    abstract class Participation
    {
        class IndiceInvalideException : Exception
        {
            public IndiceInvalideException(string msg)
            :base(msg){}
        }
        public float Coût { get; protected set; }
        protected Combinaison[] CombinaisonsParticipation {get; private set;}
        protected Combinaison this[int i]
        {
            get
            {
                ValiderIndice(i);
                return CombinaisonsParticipation[i];
            }
            private set
            {
                ValiderIndice(i);
                CombinaisonsParticipation[i] = value;
            }
        }

        private void ValiderIndice(int i)
        {
            if(!EstIndiceValide(i))
            throw new IndiceInvalideException("L'indice est invalide");
        }

        private bool EstIndiceValide(int indice)
        {
            return indice >= 0 && indice < CombinaisonsParticipation.Length;
        }


       public Participation(float coût, int nbParticipations)
       {
           Coût = coût;
           CombinaisonsParticipation = new Combinaison[nbParticipations];
       }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < CombinaisonsParticipation.Length; ++i)
            {
                sb.Append(CombinaisonsParticipation[i].ToString());
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
