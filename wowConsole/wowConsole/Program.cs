using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Arme epee = new Arme(10, 20);
            Arme masse = new Arme(12, 24);
            Arme arc = new Arme(16, 22);

            Orc Orgrimmar = new Orc(2, "Orgrimmar", 9, 80, masse);
            Humain Arthas = new Humain("lumiere", "Arthas", 6, 112, epee);
            Humain Legolas = new Humain("rapidite", "Arthas", 7, 76, arc);

            Orgrimmar.combattre(Arthas);
            Orgrimmar.combattre(Legolas);
            Console.Read();
        }
    }
}
