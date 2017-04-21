using System;
namespace projet_final
{
    public class saisonEncours
    {
        public int NumeroSamediSaison { get; set; }
        public double PourcentageSaison { get; set; }
        public int NombreSaison { get; set; }

        public saisonEncours(int samedi, double saison, int nombre)
        {
            NumeroSamediSaison = samedi;
            PourcentageSaison = saison;
            NombreSaison = nombre;
        }
    }
}
