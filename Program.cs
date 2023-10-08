using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    class Program
    {
        public class program
        {
            public static void Main()
            {
                Acteur lActeur = Acteur.getInstance(1, "Ford", "Harrison", 13 / 06 / 1942);



                Console.WriteLine(lActeur.ToString());

                Acteur Lacteur2 = Acteur.getInstance(1, "Hanks", "Tom", 09 / 07 / 1956);



                Console.WriteLine(Lacteur2.ToString());


                Film unFilm = Film.getInstance(1982, "science-fiction", 1, "l'action du film se situe à los angeles en 2019 et met en scène Rick Deckard (interprété par L'action du film se situe à Los Angeles en 2019 et met en scène Rick Deckard (interprété par Harrison Ford), un ancien policier qui reprend du service pour traquer un groupe de réplicants, des androïdes créés à l'image de l'Homme, menés par l'énigmatique Roy Batty (interprété par Rutger Hauer).", "blade runner");


                Console.WriteLine(unFilm.ToString());

                Film LeFilm2 = Film.getInstance(1992, "animation", 2, "Le film met en scène un groupe de jouets. Woody, une poupée représentant un cow-boy, et Buzz l'Éclair, une figurine d'astronaute, en sont les personnages principaux.", "Toy Story");



            }
        }
    }
}
