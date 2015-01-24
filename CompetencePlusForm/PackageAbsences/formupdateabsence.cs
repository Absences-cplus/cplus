using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompetencePlus.PackageAbsences
{
    public partial class formupdateabsence : Form
    {
        static Absence a;
        public formupdateabsence()
        {
            InitializeComponent();
        }

        public void Update(Absence s)
        {
            a = s;
            nomLabel1.Text = s.Stagiaire.Nom; prenomLabel1.Text = s.Stagiaire.Prenom;
            titreLabel1.Text = s.Seance.Titre; dateLabel1.Text = s.Date.ToString();
            causeTextBox.Text = s.Cause; autorisationCheckBox.Checked = s.Autorisation;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AbsenceDAO().Update(new Absence(a.Id, new PackageStagiaires.StagiaireDAO().FindById(a.Stagiaire.Id), Convert.ToDateTime(dateLabel1.Text), new PackageSeances.SeanceDAO().FindById(a.Seance.Id), autorisationCheckBox.Checked, causeTextBox.Text));
            this.Hide();
        }
    }
}
