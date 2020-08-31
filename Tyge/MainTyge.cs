﻿using System;
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
                Random random = new Random();

            for (int i = 0; i < 50
                
                ; i++)
            {
            int tilfeldig = random.Next(program.Count);
                Console.WriteLine(program[tilfeldig].smag);
                Console.ReadKey();  
            }
            }
        
        }
    }




