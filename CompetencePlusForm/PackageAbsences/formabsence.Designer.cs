﻿namespace CompetencePlus.PackageAbsences
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
            this.absenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.titreComboBox = new System.Windows.Forms.ComboBox();
            this.codeComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.absenceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Absencee = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.absenceinfor = new System.Windows.Forms.DataGridViewImageColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.filiereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            dateLabel = new System.Windows.Forms.Label();
            titreLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.absenceBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.absenceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filiereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seanceBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // absenceBindingSource
            // 
            this.absenceBindingSource.DataSource = typeof(CompetencePlus.PackageAbsences.Absence);
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
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.absenceBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(58, 46);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 1;
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
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(6, 22);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(34, 13);
            codeLabel.TabIndex = 4;
            codeLabel.Text = "Filiere";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Afficher";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.absenceDataGridView);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(276, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 367);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste";
            // 
            // absenceDataGridView
            // 
            this.absenceDataGridView.AutoGenerateColumns = false;
            this.absenceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.absenceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Absencee,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.absenceinfor});
            this.absenceDataGridView.DataSource = this.absenceBindingSource;
            this.absenceDataGridView.Location = new System.Drawing.Point(6, 20);
            this.absenceDataGridView.Name = "absenceDataGridView";
            this.absenceDataGridView.Size = new System.Drawing.Size(393, 312);
            this.absenceDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Stagiaire";
            this.dataGridViewTextBoxColumn1.HeaderText = "Stagiaire";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // Absencee
            // 
            this.Absencee.DataPropertyName = "Stagiaire";
            this.Absencee.HeaderText = "Absencee";
            this.Absencee.Name = "Absencee";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Seance";
            this.dataGridViewTextBoxColumn4.HeaderText = "Seance";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Autorisation";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Autorisation";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cause";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cause";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // absenceinfor
            // 
            this.absenceinfor.HeaderText = "";
            this.absenceinfor.Name = "absenceinfor";
            this.absenceinfor.Width = 50;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(327, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Enregistrer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // filiereBindingSource
            // 
            this.filiereBindingSource.DataSource = typeof(CompetencePlus.PackageFilieres.Filiere);
            // 
            // seanceBindingSource
            // 
            this.seanceBindingSource.DataSource = typeof(CompetencePlus.PackageSeances.Seance);
            // 
            // formabsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 372);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "formabsence";
            this.Text = "formabsence";
            this.Load += new System.EventHandler(this.formabsence_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.absenceBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.absenceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filiereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seanceBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView absenceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Absencee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn absenceinfor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource filiereBindingSource;
        private System.Windows.Forms.BindingSource seanceBindingSource;
    }
}