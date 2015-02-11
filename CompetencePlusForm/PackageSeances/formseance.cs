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
    public partial class formseance : Form
    {
        public formseance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new SeanceDAO().Add(new Seance(1, titreTextBox.Text, objectifTextBox.Text, date_seanceDateTimePicker.Value.Date, heure_debutTextBox.Text, heure_finTextBox.Text,codeTextBox.Text)); this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void titreTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(titreTextBox.Text))
            {
                this.errorProvider1.Icon = new Icon(SystemIcons.Error, 64, 32);
                errorProvider1.SetError(titreTextBox, "Vous devez saisie le code de la filière");
            }
            else
            {
                errorProvider1.Icon = Properties.Resources.Clear;
                errorProvider1.SetError(titreTextBox, "ok");
            }
        }

        private void codeTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codeTextBox.Text))
            {
                this.errorProvider1.Icon = new Icon(SystemIcons.Error, 64, 32);
                errorProvider1.SetError(codeTextBox, "Vous devez saisie le code de la filière");
            }
            else
            {
                errorProvider1.Icon = Properties.Resources.Clear;
                errorProvider1.SetError(codeTextBox, "ok");
            }
        }

        private void formseance_Load(object sender, EventArgs e)
        {

        }

        private void heure_debutTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(heure_debutTextBox.Text))
            {
                this.errorProvider1.Icon = new Icon(SystemIcons.Error, 64, 32);
                errorProvider1.SetError(heure_debutTextBox, "Vous devez saisie le code de la filière");
            }
            else
            {
                errorProvider1.Icon = Properties.Resources.Clear;
                errorProvider1.SetError(heure_debutTextBox, "ok");
            }
        }

        private void heure_finTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(heure_finTextBox.Text))
            {
                this.errorProvider1.Icon = new Icon(SystemIcons.Error, 64, 32);
                errorProvider1.SetError(heure_finTextBox, "Vous devez saisie le code de la filière");
            }
            else
            {
                errorProvider1.Icon = Properties.Resources.Clear;
                errorProvider1.SetError(heure_finTextBox, "ok");
            }
        }

        private void objectifTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(objectifTextBox.Text))
            {
                this.errorProvider1.Icon = new Icon(SystemIcons.Error, 64, 32);
                errorProvider1.SetError(objectifTextBox, "Vous devez saisie le code de la filière");
            }
            else
            {
                errorProvider1.Icon = Properties.Resources.Clear;
                errorProvider1.SetError(objectifTextBox, "ok");
            }
        }
    }
}
