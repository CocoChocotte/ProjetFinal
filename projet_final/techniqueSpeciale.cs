using System;
namespace projet_final
{
	public class techniqueSpeciale
	{
       
        /*
         * public int ParerAttaque { get; set; }
        public int GagnerCinqPV { get; set; }
        public int ParerUnDegat { get; set; }
        public int InfligerDeuxDegatsPerdreUnPV { get; set; }
        public int PrendreTroisPV { get; set; }
        public int */

		public techniqueSpeciale()
		{

		} 
		public static void attaqueSpeciale(catcheur un, catcheur deux, string actionPrecedenteUn, string actionPrecedenteDeux)
		{
			int chance = new Random().Next(101);

			switch (un.Numero)
			{
				case "un":
					if (chance < 30)
					{
						if (actionPrecedenteDeux == "attaque")
						{
							Console.WriteLine(un.Nom + " annule l'attaque de " + deux.Nom);
							un.PV += deux.Attaque;
						}
					}
					else
					{
						Console.WriteLine("Attaque spéciale ratée");
					}
					break;

				case "deux":
					if (chance < 40)
					{
						if (un.PV <= 95)
						{
							Console.WriteLine(un.Nom + " regagne 5 PV");
							un.PV += 5;
						}
						chance = new Random().Next(101);
						if (chance > 60)
						{
							if (actionPrecedenteDeux == "attaque")
							{
								Console.WriteLine(un.Nom + " pare 1 degat de plus " + deux.Nom);
								un.PV += 1;

							}
						}
					}
					else
					{
						Console.WriteLine("Attaque spéciale ratée");
					}
					break;

				case "trois":
					if (chance < 20)
					{
						Console.WriteLine(un.Nom + " inflige 2 degat mais perd 1PV");
						un.PV -= 1;
						deux.PV -= 2;
					}
					else
					{
						Console.WriteLine("Attaque spéciale ratée");
					}
					break;

				case "quatre":
					if (chance < 10)
					{
						Console.WriteLine(un.Nom + "Subtilise 3 PV de" + deux.Nom);
						un.PV += 3;
						deux.PV -= 3;
					}
					else
					{
						Console.WriteLine("Attaque spéciale ratée");
					}
					chance = new Random().Next(101);

					if (chance < 30)
					{
						Console.WriteLine(un.Nom + "Se soigne de 2 PV");
						un.PV += 2;
					}
					else
					{
						Console.WriteLine("Attaque spéciale ratée");
					}

					chance = new Random().Next(101);
					if (chance < 10)
					{

						if (actionPrecedenteDeux == "attaque")
						{
							Console.WriteLine(un.Nom + "Pare 1 point de dégats");
							un.PV += 1;
						}

					}
					else
					{
						Console.WriteLine("Attaque spéciale ratée");
					}
					break;
				case "cinq":
					if (chance < 30)
					{
						if (actionPrecedenteDeux == "attaque")
						{
							Console.WriteLine(un.Nom + "Annule l'attaque de " + deux.Nom);
							un.PV += deux.Attaque;
						}
					}
					else
					{
						Console.WriteLine("Attaque spéciale ratée");
					}
					break;

				case "six":
					if (chance < 40)
					{
						Console.WriteLine(un.Nom + "se protège contre 4 points de dégats et inflige 1 point de dégats à " + deux.Nom);
						un.PV += 4;
						deux.PV -= 1;
					}
					else
					{
						Console.WriteLine("Attaque spéciale ratée");
					}
					break;

				case "sept":
					if (chance < 20)
					{
						Console.WriteLine(un.Nom + "Inflige 2 point de dégats supplémentaire mais se blesse et perds 1 PV");
						deux.PV -= 2;
						un.PV -= 1;
					}
					else
					{
						Console.WriteLine("Attaque spéciale ratée");
					}
					break;

				case "huit":
					if (chance < 30)
					{

						if (actionPrecedenteDeux == "attaque")
						{
							Console.WriteLine(un.Nom + "Annule l'attaque de " + deux.Nom);
							un.PV += deux.Attaque;
						}
					}
					else
					{
						Console.WriteLine("Attaque spéciale ratée");
					}
					break;

				case "neuf":
					if (chance < 40)
					{
						Console.WriteLine(un.Nom + "s'inflige 3 points de dégats");
						un.PV = -3;
					}
					else
					{
						Console.WriteLine(un.Nom + "inflige 1 point de dégat supplémentaire");
						deux.PV -= 1;
						if (actionPrecedenteDeux == "attaque")
						{
                            Console.WriteLine(un.Nom + " se protège de 2 points de dégats");

							un.PV += 2;
						}
					}
					break;

				case "dix":
					if (chance < 30)
					{

						if (actionPrecedenteDeux == "attaque")
						{
							Console.WriteLine(un.Nom + "Annule l'attaque de " + deux.Nom);
							un.PV += deux.Attaque;
						}
					}
					else
					{
						Console.WriteLine("Attaque spéciale ratée");
					}
					break;

				case "onze":
                    if (chance < 8 )
                    {
						Console.WriteLine(un.Nom + " met " + deux.Nom + "KO sur une mega patate de forain");
						deux.PV = 0;
					}
                    else
                    {
						Console.WriteLine("Attaque spéciale ratée");
					}
					break;

				default:
					Console.WriteLine("Attaque spéciale ratée");
					break;
			}
		}

	}

}
	
	
