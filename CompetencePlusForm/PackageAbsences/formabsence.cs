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

        }
    }
}
