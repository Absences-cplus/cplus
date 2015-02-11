using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompetencePlus.PackageSeances
{
    public partial class formgestionseance : Form
    {
        public formgestionseance()
        {
            InitializeComponent();
        }
        public void Refresh()
        {
           // seanceBindingSource.DataSource = null;
            seanceBindingSource.DataSource = new SeanceDAO().Select();
            try
            {
                Seance s = (Seance)seanceBindingSource.Current;
                titreLabel1.Text = s.Titre;
                date_seanceLabel1.Text = s.Date_seance.ToString();
                heure_debutLabel1.Text = s.Heure_debut;
                codeLabel1.Text = s.Code;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void formgestionseance_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seanceBindingSource.Position =0;
            try
            {
                Seance s = (Seance)seanceBindingSource.Current;
                titreLabel1.Text = s.Titre;
                date_seanceLabel1.Text = s.Date_seance.ToString();
                heure_debutLabel1.Text = s.Heure_debut;
                codeLabel1.Text = s.Code;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            seanceBindingSource.Position -= 1;
            try
            {
                Seance s = (Seance)seanceBindingSource.Current;
                titreLabel1.Text = s.Titre;
                date_seanceLabel1.Text = s.Date_seance.ToString();
                heure_debutLabel1.Text = s.Heure_debut;
                codeLabel1.Text = s.Code;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            seanceBindingSource.Position += 1;
            try
            {
                Seance s = (Seance)seanceBindingSource.Current;
                titreLabel1.Text = s.Titre;
                date_seanceLabel1.Text = s.Date_seance.ToString();
                heure_debutLabel1.Text = s.Heure_debut;
                codeLabel1.Text = s.Code;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            seanceBindingSource.Position = seanceBindingSource.Count; ;
            try
            {
                Seance s = (Seance)seanceBindingSource.Current;
                titreLabel1.Text = s.Titre;
                date_seanceLabel1.Text = s.Date_seance.ToString();
                heure_debutLabel1.Text = s.Heure_debut;
                codeLabel1.Text = s.Code;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new formseance().ShowDialog(); Refresh();
        }

        private void seanceDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Seance s=(Seance)seanceBindingSource.Current;
            if(e.ColumnIndex==7)
            {
                new SeanceDAO().Delete(s.Id);
            }
            if(e.ColumnIndex==6)
            {
                formupdateseance f=new formupdateseance();
                f.Update(s);
                f.ShowDialog();
            }
            Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Seance s = new Seance();
            s.Titre = titreTextBox.Text;
            s.Heure_debut = heure_debutTextBox.Text;
            seanceBindingSource.DataSource = new SeanceDAO().findbyseance(s);
        }
    }
}
