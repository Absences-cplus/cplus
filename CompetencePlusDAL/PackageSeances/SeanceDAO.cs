using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompetencePlus.Tools;
using CompetencePlus.Outils;
using System.Data.OleDb;
namespace CompetencePlus.PackageSeances
{
   public class SeanceDAO:IGestion<Seance>
    {

        public void Add(Seance o)
        {
            throw new NotImplementedException();
        }

        public void Update(Seance o)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Seance> Select()
        {
            string requete = "select * from Seance";
               List<Seance>listeseance=new List<Seance>();
            OleDbDataReader read=MyConnection.ExecuteReader(requete);
            while(read.Read())
            {
                listeseance.Add(new Seance(read.GetInt32(0),read.GetString(1),read.GetString(2),read.GetDateTime(3),read.GetDateTime(4),read.GetDateTime(5)));
            }
            MyConnection.Close();
            return listeseance;
        }

        public Seance FindById(int id)
        {
            Seance s = new Seance();
            string requete = "select * from Seance where id=" + id + "";
            OleDbDataReader read = MyConnection.ExecuteReader(requete);
            while (read.Read())
            {
                s.Id = id;
                s.Titre = read.GetString(1);
            }
            return s;
        }
    }
}
