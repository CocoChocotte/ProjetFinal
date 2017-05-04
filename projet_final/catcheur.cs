using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace projet_final
{
	public class catcheur
	{
		public string Nom { get; set; }
        public string Numero { get; set; }
		public string Type { get; set; }
        public String EtatCatcheur { get; set; }
        public int PV { get; set; }
		public int Attaque { get; set; }
		public int Defense { get; set; }
        public int NombreSamediAttente { get; set; }





        public catcheur(string nom,string num, string type, string etat)
		{
			Nom = nom;
            Numero = num;
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



		public static catcheur choisirCatcheur(List<catcheur> liste)
		{
			Console.WriteLine("** Quel catcheur avez vous choisis ? **");
			string reponseString = "";
			reponseString = Console.ReadLine();
			int reponse = int.Parse(reponseString);

			while (liste[reponse].EtatCatcheur != "operationel")
			{
				Console.WriteLine("** Catcheur non operationel pour un combat **");
				Console.WriteLine("** Choisissez un autre combattant: **");
				reponseString = Console.ReadLine();
				reponse = int.Parse(reponseString);
			}

			catcheur choix = liste[reponse];
			Console.WriteLine("Vous avez choisit: ");
			liste[reponse].afficher();
			return choix;

		}


	}
}
