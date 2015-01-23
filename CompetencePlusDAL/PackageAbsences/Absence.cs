using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompetencePlus.PackageStagiaires;
using CompetencePlus.PackageSeances;
namespace CompetencePlus.PackageAbsences
{
  public  class Absence
    {
        Stagiaire stagiaire;

        public Stagiaire Stagiaire
        {
            get { return stagiaire; }
            set { stagiaire = value; }
        }
      DateTime date;

      public DateTime Date
      {
          get { return date; }
          set { date = value; }
      }
      int id;

      public int Id
      {
          get { return id; }
          set { id = value; }
      }
      Seance seance;

      public Seance Seance
      {
          get { return seance; }
          set { seance = value; }
      }
      bool autorisation;

      public bool Autorisation
      {
          get { return autorisation; }
          set { autorisation = value; }
      }
      string cause;

      public string Cause
      {
          get { return cause; }
          set { cause = value; }
      }
      public Absence()
      {

      }
    }
}
