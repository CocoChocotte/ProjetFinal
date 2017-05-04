using System;
namespace projet_final
{
    public class match
    {
        public string Gagnant { get; set; }
        public string Perdant { get; set; }
        public int NbreIteration { get; set; }
        public string TypeVictoire { get; set; }
        public double ArgentRecolte { get; set; }

        public match()
        {

        }

        public void afficher()
        {
            Console.WriteLine("Gagnant:  " + Gagnant + " - Perdant : " + Perdant + " - Nbre Iteration " + NbreIteration + " - Type Victoire : " + TypeVictoire + " - Argent Récolté:" + ArgentRecolte);

        }


		public static void action(catcheur un, catcheur deux, string actionPrecedenteUn, string actionPrecedenteDeux)
		{
			int unAttaque = new Random().Next(3);

            switch (unAttaque)
            {
                case 0:
                    Console.WriteLine(un.Nom + " attaque son adversaire");
                    if (actionPrecedenteDeux == "defense")
                    {
                        Console.WriteLine(deux.Nom + " avait preparer sa defence !");
                        deux.PV = deux.PV - un.Attaque + deux.Defense;
                    }
                    else
                    {
                        deux.PV = deux.PV - un.Attaque;
                    }
                    actionPrecedenteUn = "attaque";
                    break;

                case 1:
                    Console.WriteLine(deux.Nom + " prepare sa defense");
                    actionPrecedenteUn = "defense";
                    break;

                case 2:
                    techniqueSpeciale.attaqueSpeciale(un, deux, actionPrecedenteUn, actionPrecedenteDeux);
                    break;
                default:
                    break;

            }                    
		}

		public static void FinDuMatchNbreIterationAtteind(catcheur vainqueur, catcheur perdant, match match)
		{
			match.Gagnant = vainqueur.Nom;
			match.Perdant = perdant.Nom;
			vainqueur.RestaurePV();
			perdant.NombreSamediAttente = new Random().Next(2, 5);
			perdant.EtatCatcheur = "enConvalescence";
		}

        //
		public static void FinDuMatchMort(catcheur catcheurMort, catcheur catcheurVivant, match match)
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

        //déroulement du match
		public static match matchDuSamedi(catcheur un, catcheur deux)
		{
            match match = new match()
            {
                NbreIteration = 0
            };
            int randomInitUn = new Random().Next(101);
			int randomInitDeux = new Random().Next(101);
			string actionPrecedenteUn = "";
			string actionPrecedenteDeux = "";


			while ((match.NbreIteration != 20) && (un.PV > 0) && (deux.PV > 20))
			{
				Console.ReadLine();
				match.NbreIteration++;
				Console.WriteLine("Tour numero: " + match.NbreIteration);
				if (randomInitUn >= randomInitDeux)//cas ou j1 attaque en premier
				{
					Console.WriteLine(un.Nom + "commence ce tour ! ");
					action(un, deux, actionPrecedenteUn, actionPrecedenteDeux);
					action(deux, un, actionPrecedenteDeux, actionPrecedenteUn);
				}

				else   //cas ou j2 attaque en premier
				{
					Console.WriteLine(deux.Nom + "commence ce tour ! ");
					action(deux, un, actionPrecedenteDeux, actionPrecedenteUn);
					action(un, deux, actionPrecedenteUn, actionPrecedenteDeux);
				}

				un.afficherPV();
				deux.afficherPV();
				match.ArgentRecolte += 5000.0;
				randomInitUn = new Random().Next(101);
				randomInitDeux = new Random().Next(101);

			}

            //le match fini en 20 tours
			if (match.NbreIteration == 20)
			{
				Console.WriteLine("Match fini, fin des 20 tours:");
				match.TypeVictoire = "Fin du delai imparti";
				match.ArgentRecolte += 1000.0;
				if (un.PV > deux.PV)
				{
					FinDuMatchNbreIterationAtteind(un, deux, match);
				}
				else
				{
					FinDuMatchNbreIterationAtteind(deux, un, match);
				}
			}
            //cas ou il y a un mort
			if (un.PV < 1) // j1 mort
			{
				Console.WriteLine("Fin du match: " + un.Nom + "est mort");
				FinDuMatchMort(un, deux, match);
			}
			if (deux.PV < 1) //j2 mort
			{
				Console.WriteLine("Fin du match: " + deux.Nom + "est mort");
				FinDuMatchMort(deux, un, match);
			}

			Console.WriteLine("Recapitulatif Match: ");
			match.afficher();
			return match;
		}
    }
}
