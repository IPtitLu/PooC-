using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowConsole
{
    class Humain:Perso
    {
        protected string technologie;

        public Humain(string uneTechnologie, string nom, int force, int vie, Arme arme) : base(nom, force, vie, arme)
        {
            this.technologie = uneTechnologie;
            this.nom = nom;
            this.force = force;
            this.vie = vie;
            this.arme = arme;
        }
    }
}
