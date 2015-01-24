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
    public partial class formaffichageabsence : Form
    {
        public formaffichageabsence()
        {
            InitializeComponent();
        }
        public void remplir(Absence s)
        {
            nomLabel1.Text = s.Stagiaire.Nom; prenomLabel1.Text = s.Stagiaire.Prenom; dateLabel1.Text = s.Date.ToString();
            causeTextBox.Text = s.Cause; titreLabel1.Text = s.Seance.Titre;
            autorisationCheckBox.Checked = s.Autorisation;
        }

        private void formaffichageabsence_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
