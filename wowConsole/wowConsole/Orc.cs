using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowConsole
{
    class Orc: Perso
    {
        protected int emplacement;

        public Orc(int unEmplacement, string nom, int force, int vie, Arme arme) : base( nom,  force,  vie, arme)
        {
            this.emplacement = unEmplacement;
            this.nom = nom;
            this.force = force;
            this.vie = vie;
            this.arme = arme;
        }
    }


}
