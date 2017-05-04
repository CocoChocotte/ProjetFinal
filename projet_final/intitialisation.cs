using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace projet_final
{
    public class intitialisation
    {

        //initialise la liste des catcheurs
		public static List<catcheur> creationCatcheur()
		{
			List<catcheur> recapitulatifCatcheur = new List<catcheur>();
			recapitulatifCatcheur.Add(new catcheur("L'ordannateur des pompes funèbres", "un", "brute", "operationel"));
			recapitulatifCatcheur.Add(new catcheur("Judy Sunny", "deux", "brute", "operationel"));
			recapitulatifCatcheur.Add(new catcheur("Triple hache", "trois", "agile", "operationel"));
			recapitulatifCatcheur.Add(new catcheur("Dead poule", "quatre", "agile", "operationel"));
			recapitulatifCatcheur.Add(new catcheur("Jarvan Cinquième du nom", "cinq", "brute", "enConvalescence"));
			recapitulatifCatcheur.Add(new catcheur("Madusa", "six", "agile", "operationel"));
			recapitulatifCatcheur.Add(new catcheur("John Cinéma", "sept", "agile", "enConvalescence"));
			recapitulatifCatcheur.Add(new catcheur("Jeff Radis", "huit", "Brute", "enConvalescence"));
			recapitulatifCatcheur.Add(new catcheur("Raie Mystérieuse", "neuf", "brute", "operationel"));
			recapitulatifCatcheur.Add(new catcheur("Chris Hart", "dix", "brute", "operationel"));
			recapitulatifCatcheur.Add(new catcheur("Bret Benoit", "onze", "agile", "operationel"));

			//trie par ordre alphabetique
			recapitulatifCatcheur.Sort((catcheur1, catcheur2) => string.Compare(catcheur1.Nom, catcheur2.Nom));

			return (recapitulatifCatcheur);

		}
    }
}
