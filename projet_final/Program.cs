using System;

namespace projet_final
{
	class MainClass
	{

        static catcheur[] creationCatcheur(){

            catcheur[] tab = new catcheur[11];
            catcheur catcheurUn = new catcheur("L'ordannateur des pompes funèbres", "brute", "operationel");
			catcheur catcheurDeux = new catcheur("Judy Sunny", "brute", "operationel");
			catcheur catcheurTrois = new catcheur("Triple hache", "agile", "operationel");
			catcheur catcheurQuatre = new catcheur("Dead poule", "agile", "operationel");
			catcheur catcheurCinq = new catcheur("Jarvan cinquième du nom", "brute", "en convalescence");
			catcheur catcheurSix = new catcheur("Madusa", "agile", "operationel");
			catcheur catcheurSept = new catcheur("John Cinéma", "agile", "en convalescence");
			catcheur catcheurHuit = new catcheur("Jeff Radis", "Brute", "en convalescence");
			catcheur catcheurNeuf = new catcheur("Raie Mystérieuse", "brute", "operationel");
			catcheur catcheurDix = new catcheur("Chris Hart", "brute", "operationel");
			catcheur catcheurOnze = new catcheur("Bret Benoit", "agile", "operationel");
            tab[0] = catcheurUn;
            tab[1] = catcheurDeux;
            tab[2] = catcheurTrois;
            tab[3] = catcheurQuatre;
            tab[4] = catcheurCinq;
            tab[5] = catcheurSix;
            tab[6] = catcheurSept;
            tab[7] = catcheurHuit;
            tab[8] = catcheurNeuf;
            tab[9] = catcheurDix;
            tab[10] = catcheurOnze;


			return tab;

        }

        static void afficherCatcheur (catcheur[] tab)
        {
            Console.WriteLine("Nom  -  Type  -  Etat  - PV");
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i].afficher();   
            }

        }

        static catcheur choisirCatcheur ( catcheur[] tab)
        {
            Console.WriteLine("** Quel catcheur avez vous choisis ? **");
            string reponseString = "";
            reponseString = Console.ReadLine();
            int reponse = int.Parse(reponseString);

            while (tab[reponse - 1].Etat != "operationel")
            {
                Console.WriteLine("** Catcheur non operationel pour un combat **");
				reponseString = Console.ReadLine();
				int reponse = int.Parse(reponseString);
            }

            catcheur choix = tab[reponse - 1];
            return choix;

        }


		public static void Main()
		{

            catcheur[] tableauDesCatcheurs = creationCatcheur();
            saisonEncours jeu = new saisonEncours();


           // tableauDesCatcheurs[0].afficher() ;
			
            Console.WriteLine("*****************************************");
            Console.WriteLine("** Bonjour que voulez vous faire ? **");
            Console.WriteLine("** 0 : Creer match et lancer le combat **");
            Console.WriteLine("** 1 : Consulter historique **");
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
                    afficherCatcheur(tableauDesCatcheurs);
					Console.WriteLine("** Choix premier catcheur :  **");
                    catcheur premierCatcheurChoisit = choisirCatcheur(tableauDesCatcheurs);
                    Console.WriteLine("** Choix second catcheur :  **");
                    catcheur secondCatcheurChoisit = choisirCatcheur(tableauDesCatcheurs);

                    Console.WriteLine("** Lancement du match:  **");

					break;
				case 1:
					
					break;
				case 2:
					
					break;
				case 3:
					
					break;
				default:
					break;
			}



		}
	}
}
