namespace CompetencePlus.PackageSeances
{
    partial class formupdateseance
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
            System.Windows.Forms.Label date_seanceLabel;
            System.Windows.Forms.Label heure_debutLabel;
            System.Windows.Forms.Label heure_finLabel;
            System.Windows.Forms.Label objectifLabel;
            System.Windows.Forms.Label titreLabel;
            System.Windows.Forms.Label codeLabel;
            this.date_seanceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.heure_debutTextBox = new System.Windows.Forms.TextBox();
            this.heure_finTextBox = new System.Windows.Forms.TextBox();
            this.objectifTextBox = new System.Windows.Forms.TextBox();
            this.titreTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.seanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeTextBox = new System.Windows.Forms.TextBox();
            date_seanceLabel = new System.Windows.Forms.Label();
            heure_debutLabel = new System.Windows.Forms.Label();
            heure_finLabel = new System.Windows.Forms.Label();
            objectifLabel = new System.Windows.Forms.Label();
            titreLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // date_seanceLabel
            // 
            date_seanceLabel.AutoSize = true;
            date_seanceLabel.Location = new System.Drawing.Point(11, 72);
            date_seanceLabel.Name = "date_seanceLabel";
            date_seanceLabel.Size = new System.Drawing.Size(71, 13);
            date_seanceLabel.TabIndex = 1;
            date_seanceLabel.Text = "Date seance:";
            // 
            // heure_debutLabel
            // 
            heure_debutLabel.AutoSize = true;
            heure_debutLabel.Location = new System.Drawing.Point(11, 97);
            heure_debutLabel.Name = "heure_debutLabel";
            heure_debutLabel.Size = new System.Drawing.Size(69, 13);
            heure_debutLabel.TabIndex = 3;
            heure_debutLabel.Text = "Heure debut:";
            // 
            // heure_finLabel
            // 
            heure_finLabel.AutoSize = true;
            heure_finLabel.Location = new System.Drawing.Point(11, 123);
            heure_finLabel.Name = "heure_finLabel";
            heure_finLabel.Size = new System.Drawing.Size(53, 13);
            heure_finLabel.TabIndex = 5;
            heure_finLabel.Text = "Heure fin:";
            // 
            // objectifLabel
            // 
            objectifLabel.AutoSize = true;
            objectifLabel.Location = new System.Drawing.Point(11, 149);
            objectifLabel.Name = "objectifLabel";
            objectifLabel.Size = new System.Drawing.Size(46, 13);
            objectifLabel.TabIndex = 9;
            objectifLabel.Text = "Objectif:";
            // 
            // titreLabel
            // 
            titreLabel.AutoSize = true;
            titreLabel.Location = new System.Drawing.Point(11, 22);
            titreLabel.Name = "titreLabel";
            titreLabel.Size = new System.Drawing.Size(31, 13);
            titreLabel.TabIndex = 11;
            titreLabel.Text = "Titre:";
            // 
            // date_seanceDateTimePicker
            // 
            this.date_seanceDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.seanceBindingSource, "Date_seance", true));
            this.date_seanceDateTimePicker.Location = new System.Drawing.Point(88, 68);
            this.date_seanceDateTimePicker.Name = "date_seanceDateTimePicker";
            this.date_seanceDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_seanceDateTimePicker.TabIndex = 2;
            // 
            // heure_debutTextBox
            // 
            this.heure_debutTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seanceBindingSource, "Heure_debut", true));
            this.heure_debutTextBox.Location = new System.Drawing.Point(88, 94);
            this.heure_debutTextBox.Name = "heure_debutTextBox";
            this.heure_debutTextBox.Size = new System.Drawing.Size(200, 20);
            this.heure_debutTextBox.TabIndex = 4;
            // 
            // heure_finTextBox
            // 
            this.heure_finTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seanceBindingSource, "Heure_fin", true));
            this.heure_finTextBox.Location = new System.Drawing.Point(88, 120);
            this.heure_finTextBox.Name = "heure_finTextBox";
            this.heure_finTextBox.Size = new System.Drawing.Size(200, 20);
            this.heure_finTextBox.TabIndex = 6;
            // 
            // objectifTextBox
            // 
            this.objectifTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seanceBindingSource, "Objectif", true));
            this.objectifTextBox.Location = new System.Drawing.Point(88, 146);
            this.objectifTextBox.Multiline = true;
            this.objectifTextBox.Name = "objectifTextBox";
            this.objectifTextBox.Size = new System.Drawing.Size(200, 73);
            this.objectifTextBox.TabIndex = 10;
            // 
            // titreTextBox
            // 
            this.titreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seanceBindingSource, "Titre", true));
            this.titreTextBox.Location = new System.Drawing.Point(88, 19);
            this.titreTextBox.Name = "titreTextBox";
            this.titreTextBox.Size = new System.Drawing.Size(200, 20);
            this.titreTextBox.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(codeLabel);
            this.groupBox1.Controls.Add(this.codeTextBox);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.titreTextBox);
            this.groupBox1.Controls.Add(objectifLabel);
            this.groupBox1.Controls.Add(heure_debutLabel);
            this.groupBox1.Controls.Add(this.objectifTextBox);
            this.groupBox1.Controls.Add(date_seanceLabel);
            this.groupBox1.Controls.Add(this.heure_debutTextBox);
            this.groupBox1.Controls.Add(titreLabel);
            this.groupBox1.Controls.Add(heure_finLabel);
            this.groupBox1.Controls.Add(this.date_seanceDateTimePicker);
            this.groupBox1.Controls.Add(this.heure_finTextBox);
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 270);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seance";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "anuller";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // seanceBindingSource
            // 
            this.seanceBindingSource.DataSource = typeof(CompetencePlus.PackageSeances.Seance);
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(11, 48);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(35, 13);
            codeLabel.TabIndex = 14;
            codeLabel.Text = "Code:";
            // 
            // codeTextBox
            // 
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seanceBindingSource, "Code", true));
            this.codeTextBox.Location = new System.Drawing.Point(88, 45);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(200, 20);
            this.codeTextBox.TabIndex = 15;
            // 
            // formupdateseance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 287);
            this.Controls.Add(this.groupBox1);
            this.Name = "formupdateseance";
            this.Text = "formupdateseance";
            this.Load += new System.EventHandler(this.formupdateseance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seanceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource seanceBindingSource;
        private System.Windows.Forms.DateTimePicker date_seanceDateTimePicker;
        private System.Windows.Forms.TextBox heure_debutTextBox;
        private System.Windows.Forms.TextBox heure_finTextBox;
        private System.Windows.Forms.TextBox objectifTextBox;
        private System.Windows.Forms.TextBox titreTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox codeTextBox;
    }
}