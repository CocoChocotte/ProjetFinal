using System;
namespace projet_final
{
    public class saisonEncours
    {
        public int NumeroSamediSaison { get; set; }
        public double PourcentageSaison { get; set; }
        public int NombreSaison { get; set; }
        public int ArgentActuel { get; set; }

        public saisonEncours()
        {
            NumeroSamediSaison = 0;
            PourcentageSaison = 0.0;
            NombreSaison = 0;
            ArgentActuel = 0;
        }
    }
}
