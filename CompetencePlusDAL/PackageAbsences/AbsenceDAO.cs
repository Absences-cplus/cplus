using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompetencePlus.Outils;
using CompetencePlus.Tools;
using System.Data.OleDb;
using CompetencePlus.PackageStagiaires;
namespace CompetencePlus.PackageAbsences
{
  public  class AbsenceDAO:IGestion<Absence>
    {
        public void Add(Absence o)
        {
            string Requete = "insert into Absence(stagiaire,seance,date_absence,autorisation,cause_absence)values(" + o.Stagiaire.Id + "," + o.Seance + ",'" + o.Date + "','" + o.Autorisation + "','" + o.Cause + "')";
              MyConnection.ExecuteNonQuery(Requete);
        }

        public void Update(Absence o)
        {
            string Requete = "update Absence set autorisation='" + o.Autorisation + "',stagiaire=" + o.Stagiaire.Id + ",seance='" + o.Seance + "',cause_absence='" + o.Cause + "'where id=" + o.Id + "";
            MyConnection.ExecuteNonQuery(Requete);
        }

        public void Delete(int id)
        {
            string Requete = "delete from Absence where id=" + id + "";
            MyConnection.ExecuteNonQuery(Requete);
        }

        public List<Absence> Select()
        {
            string Requete="select * from Absence";
            List<Absence> l = new List<Absence>();
            OleDbDataReader lr = MyConnection.ExecuteReader(Requete);
            while (lr.Read())
            {
             //   l.Add(new Absence(lr.GetInt32(0),
            }
            MyConnection.Close();
                return l;
        }
      
        public Absence FindById(int id)
        {
            string Requete = "select * from Absence where id=" + id + "";
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            read.Read();
            Absence a = new Absence();

            return a;
        }


    }
}
