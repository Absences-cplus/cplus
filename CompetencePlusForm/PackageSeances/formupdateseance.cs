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
    public partial class formupdateseance : Form
    {
        static int id;
        public formupdateseance()
        {
            InitializeComponent();
        }

        public void Update(Seance s)
        {
            titreTextBox.Text = s.Titre;
            date_seanceDateTimePicker.Value = s.Date_seance;
            heure_debutTextBox.Text = s.Heure_debut;
            heure_finTextBox.Text = s.Heure_fin;
            objectifTextBox.Text = s.Objectif;
            id = s.Id;
        }

        private void formupdateseance_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new SeanceDAO().Update(new Seance(id, titreTextBox.Text, objectifTextBox.Text, date_seanceDateTimePicker.Value, heure_debutTextBox.Text, heure_finTextBox.Text,codeTextBox.Text)); this.Hide();
        }
    }
}
