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

		public static void Main()
		{
           /*
            catcheur catcheurUn = new catcheur("L'ordannateur des pompes funèbres", "brute", "operationel");
            catcheur catcheurDeux = new catcheur("Judy Sunny", "brute", "operationel");
            catcheur catcheurTrois = new catcheur("Triple hache", "agile", "operationel");
            catcheur catcheurQuatre = new catcheur("Dead poule", "agile", "operationel");
            catcheur catcheurCinq = new catcheur("Jarvan cinquième du nom" , "brute" ,"en convalescence" );
            catcheur catcheurSix = new catcheur("Madusa", "agile", "operationel");
            catcheur catcheurSept = new catcheur("John Cinéma", "agile", "en convalescence");
            catcheur catcheurHuit = new catcheur("Jeff Radis", "Brute", "en convalescence");
            catcheur catcheurNeuf = new catcheur("Raie Mystérieuse", "brute", "operationel");
            catcheur catcheurDix = new catcheur("Chris Hart", "brute", "operationel");
            catcheur catcheurOnze = new catcheur("Bret Benoit", "agile", "operationel");
            */

            catcheur[] tableauDesCatcheurs = creationCatcheur();

		}
	}
}
