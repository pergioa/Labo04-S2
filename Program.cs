// Il s'agit d'un programme client permettant d'instancier des
// participations à deux loteries : la LottoMax et le Tout ou rien
//
// par Pierre Prud'homme et Patrice Roy adapté par Maxime Barakatt, 2022

using System;

namespace lab04
{
    class Program
    {
        static string[] choixLotto = { "LottoMax", "ToutOuRien" };

        static void Main(string[] args)
        {

            // Si vous voulez déboguer votre code vous pouvez décommenter la ligne suivante et la modifier
            // en fonction des tests que vous souhaitez faire
            // args = new string[] { "LottoMax", "3" };
            // Console.WriteLine(Générateur.Next(10,50));
            // for(int i = 0; i < 10; ++i )
            // {
            //     Console.WriteLine(Générateur.Next(10,50));
            // }
            // Console.WriteLine();

            if (args.Length != 2)
            {
                Console.WriteLine("Mauvais nombre d'arguments");
                AfficherUtilisation(true);
            }

            float coûtAchat = 0;
            string lottoChoisie = LireLotto(args[0]);
            int nbParticipations = int.Parse(args[1]);

            if (nbParticipations <= 0)
            {
                Console.WriteLine("Le nombre de participation doit être un entier strictement positif");
                AfficherUtilisation(true);
            }

            Participation[] participations = new Participation[nbParticipations];

            for (int i = 0; i < nbParticipations; ++i)
            {
                if (lottoChoisie == choixLotto[0])
                {
                    participations[i] = new ParticipationLottoMax();
                }
                else if(lottoChoisie == choixLotto[1])
                {
                    participations[i] = new ParticipationToutOuRien();
                }
                coûtAchat += participations[i].Coût;
            }
            Afficher(lottoChoisie, participations, coûtAchat);
        }

        static void AfficherUtilisation(bool quitterAprès)
        {
            Console.WriteLine("Utilisation: ");
            Console.WriteLine(" dotnet run TypeLotto NbParticipation");
            Console.WriteLine($"  - TypeLotto doit être dans [{string.Join(',',choixLotto)}]");
            Console.WriteLine($"  - NbParticipation doit être un entier strictement positif");

            if (quitterAprès)
                Environment.Exit(1); // Cette ligne met fin au programme immédiatement avec un code d'erreur de 1. 
        }

        static string LireLotto(string lotto)
        {
            if (Array.IndexOf(choixLotto, lotto) == -1)
            {
                Console.WriteLine($"{lotto} n'est pas dans la liste de lotto permise.");
                AfficherUtilisation(true);
            }
            return lotto;
        }

        static void Afficher(string loterie, Participation[] participations , float coût)
        {
            Console.WriteLine();
            Console.WriteLine($"Billet de {loterie} avec {participations.Length} participations");
            Console.WriteLine();
            for (int i = 0; i < participations.Length; i++)
            {
                Console.WriteLine(participations[i]);
                Console.WriteLine();
            }
            Console.WriteLine($"Ce billet coûte {coût:c2}");
            Console.WriteLine();
        }
    }
}
