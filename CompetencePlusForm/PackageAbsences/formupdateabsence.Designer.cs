﻿namespace CompetencePlus.PackageAbsences
{
    partial class formupdateabsence
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
            System.Windows.Forms.Label autorisationLabel;
            System.Windows.Forms.Label causeLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label titreLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prenomLabel;
            this.absenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autorisationCheckBox = new System.Windows.Forms.CheckBox();
            this.causeTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel1 = new System.Windows.Forms.Label();
            this.titreLabel1 = new System.Windows.Forms.Label();
            this.nomLabel1 = new System.Windows.Forms.Label();
            this.prenomLabel1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            autorisationLabel = new System.Windows.Forms.Label();
            causeLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            titreLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.absenceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // autorisationLabel
            // 
            autorisationLabel.AutoSize = true;
            autorisationLabel.Location = new System.Drawing.Point(12, 113);
            autorisationLabel.Name = "autorisationLabel";
            autorisationLabel.Size = new System.Drawing.Size(65, 13);
            autorisationLabel.TabIndex = 1;
            autorisationLabel.Text = "Autorisation:";
            // 
            // absenceBindingSource
            // 
            this.absenceBindingSource.DataSource = typeof(CompetencePlus.PackageAbsences.Absence);
            // 
            // autorisationCheckBox
            // 
            this.autorisationCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.absenceBindingSource, "Autorisation", true));
            this.autorisationCheckBox.Location = new System.Drawing.Point(90, 107);
            this.autorisationCheckBox.Name = "autorisationCheckBox";
            this.autorisationCheckBox.Size = new System.Drawing.Size(104, 24);
            this.autorisationCheckBox.TabIndex = 2;
            this.autorisationCheckBox.UseVisualStyleBackColor = true;
            // 
            // causeLabel
            // 
            causeLabel.AutoSize = true;
            causeLabel.Location = new System.Drawing.Point(12, 140);
            causeLabel.Name = "causeLabel";
            causeLabel.Size = new System.Drawing.Size(40, 13);
            causeLabel.TabIndex = 3;
            causeLabel.Text = "Cause:";
            // 
            // causeTextBox
            // 
            this.causeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.absenceBindingSource, "Cause", true));
            this.causeTextBox.Location = new System.Drawing.Point(90, 137);
            this.causeTextBox.Multiline = true;
            this.causeTextBox.Name = "causeTextBox";
            this.causeTextBox.Size = new System.Drawing.Size(172, 70);
            this.causeTextBox.TabIndex = 4;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(12, 81);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 4;
            dateLabel.Text = "Date:";
            // 
            // dateLabel1
            // 
            this.dateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.absenceBindingSource, "Date", true));
            this.dateLabel1.Location = new System.Drawing.Point(87, 81);
            this.dateLabel1.Name = "dateLabel1";
            this.dateLabel1.Size = new System.Drawing.Size(100, 23);
            this.dateLabel1.TabIndex = 5;
            this.dateLabel1.Text = "label1";
            // 
            // titreLabel
            // 
            titreLabel.AutoSize = true;
            titreLabel.Location = new System.Drawing.Point(12, 56);
            titreLabel.Name = "titreLabel";
            titreLabel.Size = new System.Drawing.Size(50, 13);
            titreLabel.TabIndex = 6;
            titreLabel.Text = "Seance :";
            // 
            // titreLabel1
            // 
            this.titreLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.absenceBindingSource, "Seance.Titre", true));
            this.titreLabel1.Location = new System.Drawing.Point(87, 55);
            this.titreLabel1.Name = "titreLabel1";
            this.titreLabel1.Size = new System.Drawing.Size(100, 23);
            this.titreLabel1.TabIndex = 7;
            this.titreLabel1.Text = "label1";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(11, 9);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 8;
            nomLabel.Text = "Nom:";
            // 
            // nomLabel1
            // 
            this.nomLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.absenceBindingSource, "Stagiaire.Nom", true));
            this.nomLabel1.Location = new System.Drawing.Point(87, 9);
            this.nomLabel1.Name = "nomLabel1";
            this.nomLabel1.Size = new System.Drawing.Size(100, 23);
            this.nomLabel1.TabIndex = 9;
            this.nomLabel1.Text = "label1";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(12, 33);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(46, 13);
            prenomLabel.TabIndex = 10;
            prenomLabel.Text = "Prenom:";
            // 
            // prenomLabel1
            // 
            this.prenomLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.absenceBindingSource, "Stagiaire.Prenom", true));
            this.prenomLabel1.Location = new System.Drawing.Point(87, 32);
            this.prenomLabel1.Name = "prenomLabel1";
            this.prenomLabel1.Size = new System.Drawing.Size(100, 23);
            this.prenomLabel1.TabIndex = 11;
            this.prenomLabel1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "anuler";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // formupdateabsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 241);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.prenomLabel1);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomLabel1);
            this.Controls.Add(titreLabel);
            this.Controls.Add(this.titreLabel1);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateLabel1);
            this.Controls.Add(causeLabel);
            this.Controls.Add(this.causeTextBox);
            this.Controls.Add(autorisationLabel);
            this.Controls.Add(this.autorisationCheckBox);
            this.Name = "formupdateabsence";
            this.Text = "formupdateabsence";
            ((System.ComponentModel.ISupportInitialize)(this.absenceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource absenceBindingSource;
        private System.Windows.Forms.CheckBox autorisationCheckBox;
        private System.Windows.Forms.TextBox causeTextBox;
        private System.Windows.Forms.Label dateLabel1;
        private System.Windows.Forms.Label titreLabel1;
        private System.Windows.Forms.Label nomLabel1;
        private System.Windows.Forms.Label prenomLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}