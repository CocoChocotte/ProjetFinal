using System;
namespace projet_final
{
    public class match
    {



        public string Gagnant { get; set; }
        public string Perdant { get; set; }
        public int NbreIteration { get; set; }
        public string TypeVictoire { get; set; }
        public int ArgentRecolte { get; set; }

        public match()
        {

        }

        public void afficher()
        {
            Console.WriteLine("Gagnant:  " + Gagnant + " - Perdant : " + Perdant + " - Nbre Iteration " + NbreIteration + " - Type Victoire : " + TypeVictoire + " - Argent Récolté:" + ArgentRecolte);

        }



    }
}
