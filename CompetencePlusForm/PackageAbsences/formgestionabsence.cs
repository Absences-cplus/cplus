using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CompetencePlus.PackageStagiaires;
using CompetencePlus.Tools;
using System.Data.OleDb;
namespace CompetencePlus.PackageAbsences
{
    public partial class formgestionabsence : Form
    {
        public formgestionabsence()
        {
            InitializeComponent();
        }
        public void Refresh()
        {
            absenceBindingSource.DataSource = null;
            absenceBindingSource.DataSource = new AbsenceDAO().Select();
        }

        private void formgestionabsence_Load(object sender, EventArgs e)
        {
           /* try
            {
                Absence absence = (Absence)absenceBindingSource.Current;
                nomLabel1.Text = absence.Stagiaire.Nom;
                prenomLabel1.Text = absence.Stagiaire.Prenom;
                string i = image(absence.Stagiaire.Id);
                pictureBox1.Image = Image.FromFile(i);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }*/
            Refresh();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new formabsence().ShowDialog(); Refresh();
        }
         public string image(int id)
        {
            string im="";
            List<Stagiaire>ls=new List<Stagiaire>();
            OleDbDataReader l=MyConnection.ExecuteReader("select * from Stagiaires where id="+id+"");
            while(l.Read())
            {
                Stagiaire s=new Stagiaire();
                s.ProfilImage=l.GetString(10);
                im=s.ProfilImage;
                ls.Add(s);
            }
            return im;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            absenceBindingSource.Position = 0;
            try
            {
                Absence absence = (Absence)absenceBindingSource.Current;
                nomLabel1.Text = absence.Stagiaire.Nom;
                prenomLabel1.Text = absence.Stagiaire.Prenom;
                string i=image(absence.Stagiaire.Id);
                pictureBox1.Image = Image.FromFile(i);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            absenceBindingSource.Position -=1;
            try
            {
                Absence absence = (Absence)absenceBindingSource.Current;
                nomLabel1.Text = absence.Stagiaire.Nom;
                prenomLabel1.Text = absence.Stagiaire.Prenom;
                string i = image(absence.Stagiaire.Id);
                pictureBox1.Image = Image.FromFile(i);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            absenceBindingSource.Position += 1;
            try
            {
                Absence absence = (Absence)absenceBindingSource.Current;
                nomLabel1.Text = absence.Stagiaire.Nom;
                prenomLabel1.Text = absence.Stagiaire.Prenom;
                string i = image(absence.Stagiaire.Id); 
                pictureBox1.Image = Image.FromFile(i);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            absenceBindingSource.Position = absenceBindingSource.Count; ;
            try
            {
                Absence absence = (Absence)absenceBindingSource.Current;
                nomLabel1.Text = absence.Stagiaire.Nom;
                prenomLabel1.Text = absence.Stagiaire.Prenom;
                string i = image(absence.Stagiaire.Id);
                pictureBox1.Image = Image.FromFile(i);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void absenceDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Absence s = (Absence)absenceBindingSource.Current;
            if (e.ColumnIndex == 6)
            {
                new AbsenceDAO().Delete(s.Id);
            }
            if (e.ColumnIndex == 5)
            {
                formupdateabsence f = new formupdateabsence();
                f.Update(s);
                f.ShowDialog();
            }
            Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            formaffichageabsence f = new formaffichageabsence();
            Absence a=(Absence)absenceBindingSource.Current;
            f.remplir(a);
            f.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            formcauseabsence f = new formcauseabsence();
            Absence a=(Absence)absenceBindingSource.Current;
            f.Update(a);
            f.ShowDialog();
            Refresh();
        }
    }
}
