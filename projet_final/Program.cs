using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace projet_final
{
    class MainClass
    {

        // creation de la liste des catcheurs
        static List<catcheur> creationCatcheur()
        {
            List<catcheur> recapitulatifCatcheur = new List<catcheur>();
            recapitulatifCatcheur.Add(new catcheur("L'ordannateur des pompes funèbres", "brute", "operationel"));
            recapitulatifCatcheur.Add(new catcheur("Judy Sunny", "brute", "operationel"));
            recapitulatifCatcheur.Add(new catcheur("Triple hache", "agile", "operationel"));
            recapitulatifCatcheur.Add(new catcheur("Dead poule", "agile", "operationel"));
            recapitulatifCatcheur.Add(new catcheur("Jarvan Cinquième du nom", "brute", "enConvalescence"));
            recapitulatifCatcheur.Add(new catcheur("Madusa", "agile", "operationel"));
            recapitulatifCatcheur.Add(new catcheur("John Cinéma", "agile", "enConvalescence"));
            recapitulatifCatcheur.Add(new catcheur("Jeff Radis", "Brute", "enConvalescence"));
            recapitulatifCatcheur.Add(new catcheur("Raie Mystérieuse", "brute", "operationel"));
            recapitulatifCatcheur.Add(new catcheur("Chris Hart", "brute", "operationel"));
            recapitulatifCatcheur.Add(new catcheur("Bret Benoit", "agile", "operationel"));

            //trie par ordre alphabetique
            recapitulatifCatcheur.Sort((catcheur1, catcheur2) => string.Compare(catcheur1.Nom, catcheur2.Nom));

            return (recapitulatifCatcheur);

        }

        //affiche toute la liste des catcheurs
        static void afficherCatcheurs(List<catcheur> liste)
        {
            Console.WriteLine("Numero - Nom  -  Type  -  Etat  - PV");
            for (int i = 0; i < liste.Count; i++)
            {
                Console.Write(i + ": ");
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
                Console.WriteLine("** Choisissez un autre combattant: **");
                reponseString = Console.ReadLine();
                reponse = int.Parse(reponseString);
            }

            catcheur choix = liste[reponse - 1];
            return choix;

        }

        static void action(catcheur un, catcheur deux, string actionPrecedenteUn, string actionPrecedenteDeux)
        {
            int unAttaque = new Random().Next(2);

            if (unAttaque == 1)
            {
                Console.WriteLine(un.Nom + "Attaque son adversaire");
                if (actionPrecedenteDeux == "defense")
                {
                    deux.PV = deux.PV - un.Attaque + deux.Defense;
                }
                else
                {
                    deux.PV = deux.PV - un.Attaque;
                }
                actionPrecedenteUn = "attaque";
            }
            else
            {
                Console.WriteLine(deux.Nom + "prepare sa defense");
                actionPrecedenteUn = "defense";
            }
        }

        static void FinDuMatchNbreIterationAtteind (catcheur vainqueur, catcheur perdant, match match)
        {
            match.Gagnant = vainqueur.Nom;
            match.Perdant = perdant.Nom;
            vainqueur.RestaurePV();
            perdant.NombreSamediAttente = new Random().Next(7);
            perdant.EtatCatcheur = "enConvalescence";
        }

        static void FinDuMatchMort (catcheur catcheurMort, catcheur catcheurVivant, match match)
        {
            match.Gagnant = catcheurMort.Nom;
            match.Perdant = catcheurVivant.Nom;
            catcheurMort.EtatCatcheur = "aLaMorgue";
            if (catcheurVivant.PV < 60)
            {
                catcheurVivant.NombreSamediAttente = new Random().Next(7);
                catcheurVivant.EtatCatcheur = "enConvalescence";
                catcheurVivant.RestaurePV();
            }

        }

        static match matchEnCours(catcheur un, catcheur deux)
        {
            match match = new match();
            match.NbreIteration = 0;
            int randomInitUn = new Random().Next(101);
            int randomInitDeux = new Random().Next(101);
            string actionPrecedenteUn = "";
            string actionPrecedenteDeux = "";


            while ((match.NbreIteration != 20) && (un.PV > 0) && (deux.PV > 20))
            {
                match.NbreIteration++;
                Console.WriteLine("Tour numero: " + match.NbreIteration);
                if (randomInitUn >= randomInitDeux)
                {
                    Console.WriteLine(un.Nom + "commence ce tour ! ");
                    action(un, deux, actionPrecedenteUn, actionPrecedenteDeux);
                }

                else
                {
                    Console.WriteLine(deux.Nom + "commence ce tour ! ");
                    action(deux, un, actionPrecedenteDeux, actionPrecedenteUn);
                }
                match.ArgentRecolte += 5000.0;
				randomInitUn = new Random().Next(101);
				randomInitDeux = new Random().Next(101);
            }

            if (match.NbreIteration == 20)
            {
                Console.WriteLine("Match fini, fin des 20 tours:");
				match.TypeVictoire = "Fin du delai imparti";
				match.ArgentRecolte += 1000.0;
                if (un.PV > deux.PV)
                {
                    FinDuMatchNbreIterationAtteind(un,deux,match);
                }
                else
                {
                    FinDuMatchNbreIterationAtteind(deux,un,match);
                }
            }
            if (un.PV < 1)
            {
                Console.WriteLine("Fin du match: " + un.Nom + "est mort");
                FinDuMatchMort(un,deux,match);
            }
			if (deux.PV < 1)
			{
				Console.WriteLine("Fin du match: " + deux.Nom + "est mort");
				FinDuMatchMort(deux, un, match);
			}

            Console.WriteLine("Recapitulatif Match: ");
            match.afficher();
            return match;
        }

        static void historiqueMatch(List<match> liste)
        {
            for (int i = 0; i < liste.Count; i++)
            {
                liste[i].afficher();
            }

        }

        static bool TestJeuFini(List<catcheur> liste)
        {
            int compteNombreValable = 0;
            for (int i = 0; i < liste.Count; i++)
            {
                if (liste[i].PV > 0)
                {
                    compteNombreValable++;
                }
            }
            if (compteNombreValable > 2)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }


        static void AffichageParticulier(List<match> liste)
        {
            Console.WriteLine("Affichage par KO (1) ou affichage par Delai (2)?");
            string reponseString = Console.ReadLine();
            int reponse = int.Parse(reponseString);
            if (reponse == 2)
            {
                List<match> matchsDelai = liste.Where(m => m.NbreIteration == 20).ToList();
                historiqueMatch(matchsDelai);
            }
            else
            {
                List<match> matchsKO = liste.Where(m => m.NbreIteration < 20).ToList();
                historiqueMatch(matchsKO);
            }
        }

        static void afficherCatcheurParticulier(List<catcheur> liste)
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

        public static void Main()
        {

            List<catcheur> listeCatcheur = creationCatcheur();
            saisonEncours jeu = new saisonEncours();
            List<match> recapitulatifMatch = new List<match>();
            bool jeuFini = false;
            bool combatSemaineFait;

            while (!jeuFini)
            {
                combatSemaineFait = false;

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
                    Console.WriteLine("*****************************************");


                    string reponseString = "";
                    int reponse;
                    do
                    {
                        reponseString = Console.ReadLine();
                        reponse = int.Parse(reponseString);
                    } while (reponse != 0 && reponse != 1 && reponse != 2 && reponse != 3);


                    switch (reponse)
                    {
                        case 0:
                            afficherCatcheurs(listeCatcheur);
                            Console.WriteLine("** Choix premier catcheur :  **");
                            catcheur premierCatcheurChoisit = choisirCatcheur(listeCatcheur);
                            Console.WriteLine("** Choix second catcheur :  **");
                            catcheur secondCatcheurChoisit = choisirCatcheur(listeCatcheur);

                            Console.WriteLine("** Lancement du match:  **");
                            // coder fonction matchEnCours

                            combatSemaineFait = true;
                            break;
                        case 1:
                            Console.WriteLine("Voulez vous un filtrage particulier oui/non?");
                            reponseString = Console.ReadLine();
                            if (reponseString == "oui")
                            {
                                AffichageParticulier(recapitulatifMatch);
                            }
                            else
                            {
                                historiqueMatch(recapitulatifMatch);
                            }
                            break;
                        case 2:
                            Console.WriteLine("Cherchez vous un catcheur en particulier oui/non?");
                            reponseString = Console.ReadLine();
                            if (reponseString == "oui")
                            {
                                afficherCatcheurParticulier(listeCatcheur);
                            }
                            else
                            {
                                afficherCatcheurs(listeCatcheur);
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
                        default:
                            break;
                    }

                }
                jeuFini = TestJeuFini(listeCatcheur);

            }

            //fin du jeu
            jeu.Fin();

        }
    }
}
