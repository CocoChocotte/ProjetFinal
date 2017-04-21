using System;
namespace projet_final
{
    public class match
    {

        /* Gagnant, Perdant, Nombre d’itérations, Vainqueur par K.O ou par délai, Argent récolté)
- 
Vous pouvez filtrer sur « Vainqueur par K.O » et « Vainqueur par délai »*/

        public string Gagnant{get;set;}
		public string Perdant { get; set; }
        public int NbreIteration { get; set; }
        public string TypeVictoire { get; set; }
        public int ArgentRecolte { get; set; }

        public match()
        {
        }
    }
}
