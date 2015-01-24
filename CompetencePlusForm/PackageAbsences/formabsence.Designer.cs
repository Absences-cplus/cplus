namespace CompetencePlus.PackageAbsences
{
    partial class formabsence
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label titreLabel;
            System.Windows.Forms.Label codeLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.codeComboBox = new System.Windows.Forms.ComboBox();
            this.absenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filiereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titreComboBox = new System.Windows.Forms.ComboBox();
            this.seanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stagiaireDataGridView = new System.Windows.Forms.DataGridView();
            this.stagiaireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Absence = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Autorisation = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cause = new System.Windows.Forms.DataGridViewButtonColumn();
            dateLabel = new System.Windows.Forms.Label();
            titreLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.absenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filiereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seanceBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stagiaireDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stagiaireBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(6, 46);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 0;
            dateLabel.Text = "Date:";
            // 
            // titreLabel
            // 
            titreLabel.AutoSize = true;
            titreLabel.Location = new System.Drawing.Point(6, 73);
            titreLabel.Name = "titreLabel";
            titreLabel.Size = new System.Drawing.Size(44, 13);
            titreLabel.TabIndex = 2;
            titreLabel.Text = "Seance";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(6, 22);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(34, 13);
            codeLabel.TabIndex = 4;
            codeLabel.Text = "Filiere";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(codeLabel);
            this.groupBox1.Controls.Add(this.codeComboBox);
            this.groupBox1.Controls.Add(titreLabel);
            this.groupBox1.Controls.Add(this.titreComboBox);
            this.groupBox1.Controls.Add(dateLabel);
            this.groupBox1.Controls.Add(this.dateDateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Absence";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Afficher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // codeComboBox
            // 
            this.codeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.absenceBindingSource, "Stagiaire.Groupe.Filiere.Code", true));
            this.codeComboBox.DataSource = this.filiereBindingSource;
            this.codeComboBox.DisplayMember = "Code";
            this.codeComboBox.FormattingEnabled = true;
            this.codeComboBox.Location = new System.Drawing.Point(58, 19);
            this.codeComboBox.Name = "codeComboBox";
            this.codeComboBox.Size = new System.Drawing.Size(200, 21);
            this.codeComboBox.TabIndex = 5;
            this.codeComboBox.ValueMember = "Id";
            // 
            // absenceBindingSource
            // 
            this.absenceBindingSource.DataSource = typeof(CompetencePlus.PackageAbsences.Absence);
            // 
            // filiereBindingSource
            // 
            this.filiereBindingSource.DataSource = typeof(CompetencePlus.PackageFilieres.Filiere);
            // 
            // titreComboBox
            // 
            this.titreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.absenceBindingSource, "Seance.Titre", true));
            this.titreComboBox.DataSource = this.seanceBindingSource;
            this.titreComboBox.DisplayMember = "Titre";
            this.titreComboBox.FormattingEnabled = true;
            this.titreComboBox.Location = new System.Drawing.Point(58, 70);
            this.titreComboBox.Name = "titreComboBox";
            this.titreComboBox.Size = new System.Drawing.Size(200, 21);
            this.titreComboBox.TabIndex = 3;
            this.titreComboBox.ValueMember = "Id";
            // 
            // seanceBindingSource
            // 
            this.seanceBindingSource.DataSource = typeof(CompetencePlus.PackageSeances.Seance);
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.absenceBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(58, 46);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.stagiaireDataGridView);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(276, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 324);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste";
            // 
            // stagiaireDataGridView
            // 
            this.stagiaireDataGridView.AutoGenerateColumns = false;
            this.stagiaireDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stagiaireDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Email,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Absence,
            this.Autorisation,
            this.cause});
            this.stagiaireDataGridView.DataSource = this.stagiaireBindingSource;
            this.stagiaireDataGridView.Location = new System.Drawing.Point(6, 19);
            this.stagiaireDataGridView.Name = "stagiaireDataGridView";
            this.stagiaireDataGridView.Size = new System.Drawing.Size(444, 266);
            this.stagiaireDataGridView.TabIndex = 2;
            this.stagiaireDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stagiaireDataGridView_CellClick);
            this.stagiaireDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stagiaireDataGridView_CellContentClick);
            // 
            // stagiaireBindingSource
            // 
            this.stagiaireBindingSource.DataSource = typeof(CompetencePlus.PackageStagiaires.Stagiaire);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Enregistrer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prenom";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Absence
            // 
            this.Absence.HeaderText = "Absence";
            this.Absence.Name = "Absence";
            // 
            // Autorisation
            // 
            this.Autorisation.HeaderText = "Autorisation";
            this.Autorisation.Name = "Autorisation";
            // 
            // cause
            // 
            this.cause.HeaderText = "cause";
            this.cause.Name = "cause";
            this.cause.Visible = false;
            this.cause.Width = 50;
            // 
            // formabsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 331);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "formabsence";
            this.Text = "formabsence";
            this.Load += new System.EventHandler(this.formabsence_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.absenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filiereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seanceBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stagiaireDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stagiaireBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox codeComboBox;
        private System.Windows.Forms.BindingSource absenceBindingSource;
        private System.Windows.Forms.ComboBox titreComboBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource filiereBindingSource;
        private System.Windows.Forms.BindingSource seanceBindingSource;
        private System.Windows.Forms.BindingSource stagiaireBindingSource;
        private System.Windows.Forms.DataGridView stagiaireDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Absence;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Autorisation;
        private System.Windows.Forms.DataGridViewButtonColumn cause;
    }
}