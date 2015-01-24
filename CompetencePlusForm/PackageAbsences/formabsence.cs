using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CompetencePlus.PackageFilieres;
using CompetencePlus.PackageSeances;
using CompetencePlus.PackageStagiaires;
using CompetencePlus.Tools;
using System.Data.OleDb;
namespace CompetencePlus.PackageAbsences
{
    public partial class formabsence : Form
    {
        public formabsence()
        {
            InitializeComponent();
        }

        private void formabsence_Load(object sender, EventArgs e)
        {
            codeComboBox.DataSource = new FiliereDAO().Select();
            titreComboBox.DataSource = new SeanceDAO().Select();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
          Filiere f=(Filiere)codeComboBox.SelectedItem;
            string requete = "select * from Stagiaires where Filiere_id="+f.Id+"";
            stagiaireBindingSource.DataSource = new AbsenceDAO().liste_stagiaires(requete);
         /*   string requete1="select * from Seance where date_seance ='"+dateDateTimePicker.Value.Day+"'";
            MessageBox.Show(dateDateTimePicker.Value.Date.Date.ToString());
            titreComboBox.DataSource = new AbsenceDAO().listeseances(requete1);*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in stagiaireDataGridView.Rows)
            {
                if (Convert.ToBoolean(r.Cells["Absence"].Value) == true)
                {
                    Absence a = new Absence();
                    a.Id = 1;
                    a.Seance = (Seance)titreComboBox.SelectedItem;
                    a.Stagiaire = new StagiaireDAO().FindById(int.Parse(r.Cells["dataGridViewTextBoxColumn1"].Value.ToString()));
                    a.Date = dateDateTimePicker.Value.Date;
                    if (Convert.ToBoolean(r.Cells["Autorisation"].Value) == true)
                        a.Autorisation = true;
                    else
                        a.Autorisation = false;
                    new AbsenceDAO().Add(a);
                }
            }
        }

        private void stagiaireDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void stagiaireDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                new formcauseabsence().ShowDialog();
            }
        }
    }
}
