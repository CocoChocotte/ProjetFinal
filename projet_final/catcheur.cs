using System;
namespace projet_final
{
	class catcheur
	{
		public string Nom { get; set; }
		public string Type { get; set; }
		public string Etat { get; set; }
		public int PV { get; set; }
		public int Attaque { get; set; }
		public int Defense { get; set; }




		public catcheur(string nom, string type, string etat)
		{
			Nom = nom;
			Type = type;
			Etat = etat;

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
		}




	}
}
