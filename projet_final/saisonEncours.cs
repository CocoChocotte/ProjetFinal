using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace projet_final
{
    public class saisonEncours
    {
        public int NumeroSamediSaison { get; set; }
        public double PourcentageSaison { get; set; }
        public int NombreSaison { get; set; }
        public double ArgentActuel { get; set; }
        public int NombreCombat { get; set; }

        public saisonEncours()
        {
            NumeroSamediSaison = 0;
            PourcentageSaison = 0.0;
            NombreSaison = 0;
            ArgentActuel = 0.0;
            NombreCombat = 0;
        }


        //affiche le score final
        public void Fin ()
        {
            Console.WriteLine("Vous avez reussit a survivre " + NombreSaison);
            Console.WriteLine("Il s'est derouler " + NombreCombat + " combats");
            if (ArgentActuel > 0.0)
            {
                Console.WriteLine("Vous avez gagne : " + ArgentActuel + "€");
            }
            else
            {
                Console.WriteLine("Vous avez fini ruine !!!! ");
            }
        }

        // test s'il reste au moins 2 catcheur valide
		public static bool TestJeuFini(List<catcheur> liste)
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
				return (false);
			}
			else
			{
				return (true);
			}
		}

       
    }
}
