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
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new formabsence().ShowDialog(); Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            absenceBindingSource.MoveFirst();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            absenceBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            absenceBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            absenceBindingSource.MoveLast();
        }
    }
}
