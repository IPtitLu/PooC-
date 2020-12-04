using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowConsole
{
    class Perso
    {
        protected string nom;
        protected int force;
        protected int vie;
        protected Arme arme;
        
        public Perso (string unNom, int uneForce, int uneVie, Arme uneArme)
        {
            this.nom = unNom;
            this.force = uneForce;
            this.vie = uneVie;
            this.arme = uneArme;   
        }

        public void setVie(int vie)
        {
            this.vie = vie;
        }
        public void combattre(Perso defenseur)
        {

            while (this.vie >0 && defenseur.vie > 0)
            {

                Console.WriteLine(" " + this.nom + " vie : " + defenseur.vie + " ");
                Console.WriteLine(" " + defenseur.nom + " vie : " + this.vie + " ");
                this.attaquer(defenseur);
                
                if (defenseur.vie > 0)
                {
                    
                    defenseur.attaquer(this);
                    if (this.vie > 0)
                    {
                        this.attaquer(defenseur);
                        
                    } 
                } 
                if(defenseur.vie <= 0)
                {
                    Console.WriteLine("" + this.nom + " Win");
                }
                if(this.vie <= 0)
                {
                    Console.WriteLine("" + this.nom + " Lose");
                }
                
            }
            
        }
            
        public void attaquer(Perso defenseur)
        {
            Random rnd = new Random();
            int degatMin = this.arme.getDegatMin();
            int degatMax = this.arme.getDegatMax();
            int coup = rnd.Next(degatMin, degatMax);
            defenseur.setVie(defenseur.vie - coup);
        }
    }
}
