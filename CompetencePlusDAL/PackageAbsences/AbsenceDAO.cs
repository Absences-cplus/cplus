using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompetencePlus.Outils;
using CompetencePlus.Tools;
using System.Data.OleDb;
using CompetencePlus.PackageStagiaires;
using CompetencePlus.PackageSeances;
namespace CompetencePlus.PackageAbsences
{
  public  class AbsenceDAO:IGestion<Absence>
    {
        public void Add(Absence o)
        {
            int au = 0;
            if (o.Autorisation == true)
                au = 1;

            string Requete = "insert into Absence(stagiaire_id,seance_id,date_absence,Autorisation,Cause_absence)values(" + o.Stagiaire.Id + "," + o.Seance.Id + ",'" + o.Date + "','" + au + "','" + o.Cause + "')";
            MyConnection.ExecuteNonQuery(Requete);
        }

        public void Update(Absence o)
        {
            int au = 0;
            if (o.Autorisation == true)
                au = 1;
            string Requete = "update Absence set Autorisation=" + au + ",stagiaire_id=" + o.Stagiaire.Id + ",seance_id=" + o.Seance.Id + ",Cause_absence='" + o.Cause + "'where id=" + o.Id + "";
            MyConnection.ExecuteNonQuery(Requete);
        }

        public void Delete(int id)
        {
            string Requete = "delete from Absence where id=" + id + "";
            MyConnection.ExecuteNonQuery(Requete);
        }
        public List<Stagiaire> liste_stagiaires(string r)
        {
            List<Stagiaire> l = new List<Stagiaire>();
            OleDbDataReader read = MyConnection.ExecuteReader(r);
            while (read.Read())
            {
                Stagiaire s = new Stagiaire();
                s.Nom = read.GetString(2);
                s.Prenom = read.GetString(3);
                s.Id = read.GetInt32(0);
                s.ProfilImage = read.GetString(10);
                l.Add(s);
            }
            return l;
        }

        public List<Seance> listeseances(string requete)
        {
            List<Seance> l = new List<Seance>();
            OleDbDataReader read = MyConnection.ExecuteReader(requete);
            while (read.Read())
            {
                Seance s = new Seance();
                s.Id = read.GetInt32(0);
                s.Titre = read.GetString(1);
                s.Date_seance = read.GetDateTime(3).Date;
                s.Heure_debut = read.GetDateTime(4);
                l.Add(s);
            }
            return l;
        }
      
        public List<Absence> Select()
        {
            string Requete = "select * from Absence";
            List<Absence> l = new List<Absence>();
            OleDbDataReader lr = MyConnection.ExecuteReader(Requete);
            while (lr.Read())
            {
                bool au = false;
                if (lr.GetInt32(4) == 1)
                    au = true;
                l.Add(new Absence(lr.GetInt32(0), new StagiaireDAO().FindById(lr.GetInt32(1)), lr.GetDateTime(3), new PackageSeances.SeanceDAO().FindById(lr.GetInt32(2)), au, lr.GetString(5)));
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
