using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    class Film
    {
        
        private int lannee;
        private string legenre;
        private int idFilm;
        private string leResume;
        private string letitre;
        private Acteur lacteurPrincipal;
        public Film( int annee, string genre, int idFilm, string resume, string titre, Acteur acteurPrincipal)
        {
            this.lacteurPrincipal = acteurPrincipal;
            this.lannee = annee;
            this.legenre = genre;
            this.idFilm = idFilm;
            this.leResume = resume;
            this.letitre = titre;
           

        }
        public static Film getInstance(int annee, string genre, int idFilm, string resume, string titre, Acteur acteurPrincipal)
        {
            return new Film(annee, genre, idFilm, resume, titre, acteurPrincipal);
        }

        public Acteur GetActeurPrincipal()
        {
            return lacteurPrincipal;
        }

        public override string ToString()
        {
                 return $"titree : {letitre}\annee : {lannee}\ngenre : {legenre}\nresume: {leResume}";
            }
    }
    
}


