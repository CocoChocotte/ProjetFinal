using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace projet_final
{
    class MainClass
    {
        public static void Main()
        {
            //initialisation des variables a utiliser
            List<catcheur> listeCatcheur = intitialisation.creationCatcheur();
            saisonEncours jeu = new saisonEncours();
            List<match> recapitulatifMatch = new List<match>();
            bool jeuFini = false;
            bool combatSemaineFait = false;
            match samedi = new match();


            while (!jeuFini) 
            {
                Console.WriteLine("Debut de la semaine ! ");
                for (int i = 0; i < listeCatcheur.Count; i++)
                {
                    if (listeCatcheur[i].NombreSamediAttente != 0)
                    {
                        listeCatcheur[i].NombreSamediAttente--;
                        if (listeCatcheur[i].NombreSamediAttente == 0)
                        {
                            listeCatcheur[i].EtatCatcheur = "operationel";
                        }
                    }
                }

                while (!combatSemaineFait)
                {
                    Console.WriteLine("*****************************************");
                    Console.WriteLine("** Bonjour que voulez vous faire ? **");
                    Console.WriteLine("** 0 : Creer match et lancer le combat **");
                    Console.WriteLine("** 1 : Consulter historique des matchs**");
                    Console.WriteLine("** 2 : Consulter contact **");
                    Console.WriteLine("** 3 : Quitter le jeu **");
                    Console.WriteLine("** 4 : affichage score en cours **");
                    Console.WriteLine("*****************************************");


                    string reponseString = "";
                    int reponse;
                    do
                    {
                        reponseString = Console.ReadLine();
                        reponse = int.Parse(reponseString);
                    } while (reponse != 0 && reponse != 1 && reponse != 2 && reponse != 3 && reponse != 4);


                    switch (reponse)
                    {
                        case 0:
                            affichages.afficherCatcheurs(listeCatcheur);
                            Console.WriteLine("** Choix premier catcheur :  **");
                            catcheur premierCatcheurChoisit = catcheur.choisirCatcheur(listeCatcheur);
                            Console.WriteLine("** Choix second catcheur :  **");
                            catcheur secondCatcheurChoisit = catcheur.choisirCatcheur(listeCatcheur);

                            Console.WriteLine("** Lancement du match:  **");
                            samedi = match.matchDuSamedi(premierCatcheurChoisit,secondCatcheurChoisit);
                            recapitulatifMatch.Add(samedi);

                            combatSemaineFait = true;
                            break;
                        case 1:
                            Console.WriteLine("Voulez vous un filtrage particulier oui/non?");
                            reponseString = Console.ReadLine();
                            if (reponseString == "oui")
                            {
                                affichages.AffichageMatchParticulier(recapitulatifMatch);
                            }
                            else
                            {
                                affichages.AfficheHistoriqueMatch(recapitulatifMatch);
                            }
                            break;
                        case 2:
                            Console.WriteLine("Cherchez vous un catcheur en particulier oui/non?");
                            reponseString = Console.ReadLine();
                            if (reponseString == "oui")
                            {
                                affichages.afficherCatcheurParticulier(listeCatcheur);
                            }
                            else
                            {
                                affichages.afficherCatcheurs(listeCatcheur);
                            }
                            break;
                        case 3:
                            Console.WriteLine("Etes vous sur de vouloir quitter le jeu (oui/non) ?");
                            reponseString = Console.ReadLine();
                            if (reponseString == "non")
                            {
                                Console.WriteLine("ouf !");
                            }
                            else
                            {
                                Console.WriteLine("au revoir...");
                                combatSemaineFait = true;
                                jeuFini = true;
                            }
                            break;
                        case 4:
                            affichages.afficheScoreJeuEnCours(jeu);
                            break;
                        default:
                            break;
                    }

                }

				jeu.ArgentActuel += recapitulatifMatch.Last().ArgentRecolte;
				jeu.NumeroSamediSaison++;
                jeu.NombreCombat++;
                if (jeu.NumeroSamediSaison == 8)
                {
                    jeu.NumeroSamediSaison = 1;
                    jeu.NombreSaison++;
                    if (jeu.PourcentageSaison < 1.3)
                    {
                        jeu.PourcentageSaison = 1.3;
                    }
                    else
                    {
                        jeu.ArgentActuel = jeu.ArgentActuel * 1.3;
                    }
                }

                combatSemaineFait = false;
                jeuFini = saisonEncours.TestJeuFini(listeCatcheur);



            }

            //fin du jeu
            jeu.Fin();

        }
    }
}
