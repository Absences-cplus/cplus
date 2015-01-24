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
    public partial class formcauseabsence : Form
    {
        static Absence ab;
        public formcauseabsence()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (causeTextBox.Text != "")
            {
                new AbsenceDAO().Update(new Absence(ab.Id, new PackageStagiaires.StagiaireDAO().FindById(ab.Stagiaire.Id), ab.Date, new PackageSeances.SeanceDAO().FindById(ab.Seance.Id), ab.Autorisation, causeTextBox.Text)); this.Dispose();
            }
        }

        public void Update(Absence a)
        {
            ab = a;
        }
    }
}
