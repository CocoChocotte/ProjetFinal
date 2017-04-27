using System;
using System.Collections.Generic;

namespace projet_final
{
    class MainClass
    {

        static List<catcheur> creationCatcheur()
        {

            List<catcheur> recapitulatifCatcheur = new List<catcheur>();
            recapitulatifCatcheur.Add(new catcheur("L'ordannateur des pompes funèbres", "brute", "operationel"));
            recapitulatifCatcheur.Add(new catcheur("Judy Sunny", "brute", "operationel"));
            recapitulatifCatcheur.Add(new catcheur("Triple hache", "agile", "operationel"));
            recapitulatifCatcheur.Add(new catcheur("Dead poule", "agile", "operationel"));
            recapitulatifCatcheur.Add(new catcheur("Jarvan Cinquième du nom","brute","enConvalescence"));
            recapitulatifCatcheur.Add(new catcheur("Madusa", "agile", "operationel"));
            recapitulatifCatcheur.Add(new catcheur("John Cinéma", "agile", "enConvalescence"));
            recapitulatifCatcheur.Add(new catcheur("Jeff Radis", "Brute", "enConvalescence"));
            recapitulatifCatcheur.Add(new catcheur("Raie Mystérieuse", "brute", "operationel"));
            recapitulatifCatcheur.Add(new catcheur("Chris Hart", "brute", "operationel"));
            recapitulatifCatcheur.Add(new catcheur("Bret Benoit", "agile", "operationel"));

            recapitulatifCatcheur.Sort((catcheur1, catcheur2) => string.Compare(catcheur1.Nom, catcheur2.Nom));

            return (recapitulatifCatcheur);

        }

        static void afficherCatcheur(List<catcheur> liste)
        {
            Console.WriteLine("Nom  -  Type  -  Etat  - PV");
            for (int i = 0; i < liste.Count; i++)
            {
                liste[i].afficher();
            }

        }

        static catcheur choisirCatcheur(List<catcheur> liste)
        {
            Console.WriteLine("** Quel catcheur avez vous choisis ? **");
            string reponseString = "";
            reponseString = Console.ReadLine();
            int reponse = int.Parse(reponseString);

            while (liste[reponse - 1].EtatCatcheur != "operationel")
            {
                Console.WriteLine("** Catcheur non operationel pour un combat **");
                reponseString = Console.ReadLine();
                reponse = int.Parse(reponseString);
            }

            catcheur choix = List[reponse - 1];
            return choix;

        }


        static match matchEnCours (catcheur un, catcheur deux){
            match match = new match();

            // deroulement du match


            return match;
        }

        static void historiqueMatch(List<match> liste)
		{
			for (int i = 0; i < liste.Count; i++)
			{
				liste[i].afficher();
			}

		}

		public static void Main()
		{

            List<catcheur> listeCatcheur = creationCatcheur();
            saisonEncours jeu = new saisonEncours();
            List<match> recapitulatifMatch = new List<match>();


           // tableauDesCatcheurs[0].afficher() ;
			
            Console.WriteLine("*****************************************");
            Console.WriteLine("** Bonjour que voulez vous faire ? **");
            Console.WriteLine("** 0 : Creer match et lancer le combat **");
            Console.WriteLine("** 1 : Consulter historique des matchs**");
            Console.WriteLine("** 2 : Consulter contact **");
            Console.WriteLine("** 3 : Quitter le jeu **");
            Console.WriteLine("*****************************************");


			string reponseString = "";
			do
			{
				reponseString = Console.ReadLine();
			} while (reponseString != "0" || reponseString != "1" || reponseString != "2" || reponseString != "3");

			int reponse = int.Parse(reponseString);

			switch (reponse)
			{
				case 0:
                    afficherCatcheur(listeCatcheur);
					Console.WriteLine("** Choix premier catcheur :  **");
                    catcheur premierCatcheurChoisit = choisirCatcheur(listeCatcheur);
                    Console.WriteLine("** Choix second catcheur :  **");
                    catcheur secondCatcheurChoisit = choisirCatcheur(listeCatcheur);

                    Console.WriteLine("** Lancement du match:  **");
                    // coder fonction matchEnCours

					break;
				case 1:
                    historiqueMatch(recapitulatifMatch);
					// affichage particulier a coder: filtrage : Vainqueur par K.O  et Vainqueur par délai 
					break;
				case 2:
                    Console.WriteLine("Cherchez vous un catcheur en particulier oui/non?");
                    reponseString = Console.ReadLine();
                    if (reponseString == "oui")
                    {
                       Console.WriteLine("Cherchez vous un catcheur en particulier oui/non?");
                    }
                    else 
                    {
						afficherCatcheur(listeCatcheur);
                    }
                        break;
				case 3:
					
					break;
				default:
					break;
			}



		}
	}
}
