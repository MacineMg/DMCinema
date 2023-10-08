﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    class Acteur
    {
        private int id;
        private string nom;
        private string prenom;
        private int anneedenaissance;

        public Acteur(int id, string nom, string prenom, int anneeNaissance)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.anneedenaissance = anneeNaissance;

        }


        public static Acteur getInstance(int id, string nom, string prenom, int anneeNaissance)
        {
            return new Acteur(id, nom, prenom, anneeNaissance);
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public int AnneeNaissance
        {
            get { return anneedenaissance; }
            set { anneedenaissance = value; }
        }


        public override string ToString()
        {
            return $"nom : {nom} prénom : {prenom} lannee de naissance : {anneedenaissance}";
        }
    }
}
