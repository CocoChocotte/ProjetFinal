using System;
namespace projet_final
{
	class catcheur
	{
		public string Nom { get; set; }
		public string Type { get; set; }
       // public enum etat{operationel, enConvalescence, mort }
       // public etat EtatCatcheur { get; set; }
        public String EtatCatcheur { get; set; }
        public int PV { get; set; }
		public int Attaque { get; set; }
		public int Defense { get; set; }
        public int NombreSamediAttente { get; set; }




        public catcheur(string nom, string type, string etat)
		{
			Nom = nom;
			Type = type;
            EtatCatcheur = etat;

			if (Type == "agile")
			{
				PV = 125;
				Attaque = 3;
				Defense = 3;
			}
			else 
			{ 
				PV = 100;
				Attaque = 5;
				Defense = 1;
			}
            NombreSamediAttente = 0;
		}

        public void afficher ()
        {
            Console.WriteLine(Nom + " - " + Type + " - " + EtatCatcheur + " - " +PV);
        }

        public void RestaurePV()
        {
			if (Type == "agile")
			{
				PV = 125;
			}
			else
			{
				PV = 100;
			}
        }

        public void afficherPV ()
        {
            Console.WriteLine("Il reste " + PV + " a " + Nom );
        }




	}
}
