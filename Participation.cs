using System;
using System.Text;

namespace lab04
{
    abstract class Participation
    {
        class IndiceEstInvalideException : Exception
        {
            public IndiceEstInvalideException(string msg)
            :base(msg){}
        }
        public float Coût { get; protected set; }
        public Combinaison[] CombinaisonsParticipation {get; protected set;}
        public Combinaison this[int i]
        {
            get
            {
                ValiderIndice(i);
                return CombinaisonsParticipation[i];
            }

            set
            {
                ValiderIndice(i);
                CombinaisonsParticipation[i] = value;
            }
        }

        private void ValiderIndice(int i)
        {
            if(!EstIndiceValide(i))
            throw new IndiceEstInvalideException("L'indice est invalide");
        }

        private bool EstIndiceValide(int indice)
        {
            return indice >= 0 && indice < CombinaisonsParticipation.Length;
        }


       public Participation(float coût)
       {
           Coût = coût;
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
