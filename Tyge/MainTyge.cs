using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyge
{
    class Farver
    {
        static void Main(string[] args)
        {
            Tyggegum Blå = new Tyggegum("Blå", 25);
            Blå.smag = "Blåbær";
            Blå.antal = 25;

            Tyggegum Rød = new Tyggegum("Rød", 14);
            Rød.smag = "Jordbær";
            Rød.antal = 14;

            Tyggegum Grøn = new Tyggegum("Grøn", 10);
            Grøn.smag = "Æble";
            Grøn.antal = 10;

            Tyggegum Lilla = new Tyggegum("Lilla", 12);
            Lilla.smag = "Brombær";
            Lilla.antal = 12;

            Tyggegum Gul = new Tyggegum("Gul", 20);
            Gul.smag = "Tuttiefruttie";
            Gul.antal = 20;

            Tyggegum Orange = new Tyggegum("Orange", 19);
            Orange.smag = "Appelsin";
            Orange.antal = 19;

            //opretter en liste og tilføjer objekter
            List<Tyggegum> program = new List<Tyggegum> { Blå, Rød, Grøn, Lilla, Gul, Orange };

            //Udskriv nu din liste, ved at bruge foreach løkken.

            foreach (Tyggegum item in program)
            {
                Console.WriteLine(item.antal); //udskriver kun antal
            }
        
            foreach (Tyggegum item in program) // går igennem hele listen. $ fordi så kan jeg have mere end en property at vise 

            {
                Console.WriteLine($"{item.smag}, {item.antal}");
            }

            // nu udskriv 55 tilfældige tyggegummier i tilfældig rækkefølge.
            Console.WriteLine("55 tilfældige tyggegummier i tilfældig rækkefølge");


            Random random = new Random();
            List<Tyggegum> heleliste = new List<Tyggegum>(); //laver ny liste

            for (int i = 0; i < 55; i++)
            {
                int tilfeldig = random.Next(program.Count);
                Console.WriteLine(program[tilfeldig].smag);
                heleliste.Add(program[tilfeldig]);//adder til min liste
            }
            Console.WriteLine("now remove a chewing gum, and print how many chewing gums is left");
            Console.WriteLine(heleliste.Count - 1); //printer hvor mange der er i min liste.
            Console.ReadKey();

            //remove a random chewing gum from the list, and print how many chewing gums is left.
            heleliste.RemoveAt(random.Next(heleliste.Count));
            Console.WriteLine(heleliste.Count()); //printer hvor mange der er i min liste.
            Console.ReadKey();
        }

        
        }


    }





