using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    class Cinema
    {
        private List<Acteur> desActeurs;
        private List<Film> desFilms;

        public Cinema()
        {
            this.desActeurs = new List<Acteur>();
            this.desFilms = new List<Film>();
        }

        public static Cinema GetInstance()
        {
            return new Cinema();
        }

        
        public void AjouterUnActeur(Acteur acteur)
        {
            desActeurs.Add(acteur);
        }

        public void AjouterUnFilm(Film film)
        {
            desFilms.Add(film);
        }

        
        public Acteur GetActeur(int id)
        {
            foreach (Acteur acteur in desActeurs)
            {
                if (acteur.Id == id)
                {
                    return acteur;
                }
            }
            return null;
        }

       
        public Film GetFilm(int id)
        {
            foreach (Film film in desFilms)
            {
                if (film.Id == id)
                {
                    return film;
                }
            }
            return null;
        }

       
        public int NbActeur()
             {
                 return desActeurs.Count;
                }

        
        public int NbFilm()
            {
                 return desFilms.Count;
        }
    }
}
