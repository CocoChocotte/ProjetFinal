using System;
namespace projet_final
{
    public class saisonEncours
    {
        public int NumeroSamediSaison { get; set; }
        public double PourcentageSaison { get; set; }
        public int NombreSaison { get; set; }
        public double ArgentActuel { get; set; }
        public int NombreCombat { get; set; }

        public saisonEncours()
        {
            NumeroSamediSaison = 0;
            PourcentageSaison = 0.0;
            NombreSaison = 0;
            ArgentActuel = 0.0;
            NombreCombat = 0;
        }


        //affiche le score final
        public void Fin ()
        {
            Console.WriteLine("Vous avez reussit a survivre " + NombreSaison);
            Console.WriteLine("Il s'est derouler " + NombreCombat + " combats");
            if (ArgentActuel != 0.0)
            {
                Console.WriteLine("Vous avez gagne : " + ArgentActuel + "€");
            }
            else
            {
                Console.WriteLine("Vous avez fini ruine !!!! ");
            }


        }
    }
}
