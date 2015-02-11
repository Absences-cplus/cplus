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
           string requete="insert into Seance(titre,objectif,date_seance,heuredebut,heurefin,code)values('"+o.Titre+"','"+o.Objectif+"','"+o.Date_seance.Date+"','"+o.Heure_debut+"','"+o.Heure_fin+"','"+o.Code+"')";
            MyConnection.ExecuteNonQuery(requete);
        }

        public void Update(Seance o)
        {
            string requete = "update Seance set titre='"+o.Titre+"',objectif='"+o.Objectif+"',date_seance='"+o.Date_seance.Date+"',heuredebut='"+o.Heure_debut+"',heurefin='"+o.Heure_fin+"',code='"+o.Code+"'where id="+o.Id+"";
            MyConnection.ExecuteNonQuery(requete);
        }

        public void Delete(int id)
        {
            MyConnection.ExecuteNonQuery("delete from seance where id="+id+"");
        }

        public List<Seance> Select()
        {

            string requete = "select * from Seance";
               List<Seance>listeseance=new List<Seance>();
            OleDbDataReader read=MyConnection.ExecuteReader(requete);
            while(read.Read())
            {
                listeseance.Add(new Seance(read.GetInt32(0), read.GetString(1), read.GetString(2), read.GetDateTime(3), read.GetString(4), read.GetString(5),read.GetString(6)));
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
                s.Code = read.GetString(6);
            }
            return s;
        }

        public List<Seance> findbyseance(Seance s)
        {
            string requete = "select * from seance";
            if (s.Titre != "" || s.Heure_debut != "")
                requete += " where";
            bool and = false;
            if (s.Titre != "")
            {   requete += " titre='" + s.Titre + "'";
            and = true;
            }
            if (s.Heure_debut != "")
            {
                if(and)requete+=" and";
                requete += " heuredebut='" + s.Heure_debut + "'";
                and = true;
            }
           List<Seance>listeseance=new List<Seance>();
            OleDbDataReader read=MyConnection.ExecuteReader(requete);
            while(read.Read())
            {
                listeseance.Add(new Seance(read.GetInt32(0), read.GetString(1), read.GetString(2), read.GetDateTime(3), read.GetString(4), read.GetString(5),read.GetString(6)));
            }
             MyConnection.Close();   
            return listeseance;
        }
    }
}
