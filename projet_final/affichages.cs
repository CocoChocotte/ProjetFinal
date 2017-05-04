using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace projet_final
{
    public class affichages
    {
        public affichages()
        {
        }

		//affiche toute la liste des catcheurs
		public static void afficherCatcheurs(List<catcheur> liste)
		{
			Console.WriteLine("Numero - Nom  -  Type  -  Etat  - PV");
			for (int i = 0; i < liste.Count; i++)
			{
				Console.Write(i + ": ");
				liste[i].afficher();
			}

		}

        //recherche d'un catcheur par son nom et l'affiche
		public static void afficherCatcheurParticulier(List<catcheur> liste)
		{
			Console.WriteLine("Qui cherchez vous ? ");
			string reponseString = Console.ReadLine();
			List<catcheur> catcheurRecherche = liste.Where(c => c.Nom == reponseString).ToList();
			if (catcheurRecherche[0].Nom == reponseString)
			{
				catcheurRecherche[0].afficher();
			}
			else
			{
				Console.WriteLine("Catcheur introuvable");
			}
		}

        //affichage de l'historique de tout les matchs
        public static void AfficheHistoriqueMatch(List<match> liste)
        {
            for (int i = 0; i < liste.Count; i++)
            {
                liste[i].afficher();
            }

        }

        //affichage des matchs par KO ou par Delai
		public static void AffichageMatchParticulier(List<match> liste)
		{
			Console.WriteLine("Affichage par KO (1) ou affichage par Delai (2)?");
			string reponseString = Console.ReadLine();
			int reponse = int.Parse(reponseString);
			if (reponse == 2)
			{
				List<match> matchsDelai = liste.Where(m => m.NbreIteration == 20).ToList();
                AfficheHistoriqueMatch(matchsDelai);
			}
			else
			{
				List<match> matchsKO = liste.Where(m => m.NbreIteration < 20).ToList();
                AfficheHistoriqueMatch(matchsKO);
			}
		}


         //affiche score partie en cours
        public static void afficheScoreJeuEnCours (saisonEncours jeu)
        {
            Console.WriteLine("Vous etes à la " + jeu.NombreSaison + "eme saison");
            Console.WriteLine("Il s'est derouler " + jeu.NombreCombat + " match");
            Console.WriteLine("Vous avez actuellement : " + jeu.ArgentActuel + "€ en poche");
            
        }

	}
}
