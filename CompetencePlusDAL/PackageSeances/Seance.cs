using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompetencePlus.PackageFormations;
namespace CompetencePlus.PackageSeances
{
  public  class Seance
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string titre;

        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }
        string objectif;

        public string Objectif
        {
            get { return objectif; }
            set { objectif = value; }
        }
        DateTime date_seance;

        public DateTime Date_seance
        {
            get { return date_seance; }
            set { date_seance = value; }
        }
      DateTime heure_fin;

      public DateTime Heure_fin
      {
          get { return heure_fin; }
          set { heure_fin = value; }
      }
      DateTime heure_debut;

      public DateTime Heure_debut1
      {
          get { return heure_debut; }
          set { heure_debut = value; }
      }

      public DateTime Heure_debut
      {
          get { return heure_debut; }
          set { heure_debut = value; }
      }
      public Seance()
      {

      }

    }
}
