namespace CompetencePlus.PackageSeances
{
    partial class formseance
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
            System.Windows.Forms.Label objectifLabel;
            System.Windows.Forms.Label titreLabel;
            System.Windows.Forms.Label heure_finLabel;
            System.Windows.Forms.Label codeLabel;
            this.date_seanceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.heure_debutTextBox = new System.Windows.Forms.TextBox();
            this.objectifTextBox = new System.Windows.Forms.TextBox();
            this.titreTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.heure_finTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.seanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            date_seanceLabel = new System.Windows.Forms.Label();
            heure_debutLabel = new System.Windows.Forms.Label();
            objectifLabel = new System.Windows.Forms.Label();
            titreLabel = new System.Windows.Forms.Label();
            heure_finLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // date_seanceLabel
            // 
            date_seanceLabel.AutoSize = true;
            date_seanceLabel.Location = new System.Drawing.Point(12, 78);
            date_seanceLabel.Name = "date_seanceLabel";
            date_seanceLabel.Size = new System.Drawing.Size(71, 13);
            date_seanceLabel.TabIndex = 1;
            date_seanceLabel.Text = "Date seance:";
            // 
            // heure_debutLabel
            // 
            heure_debutLabel.AutoSize = true;
            heure_debutLabel.Location = new System.Drawing.Point(12, 103);
            heure_debutLabel.Name = "heure_debutLabel";
            heure_debutLabel.Size = new System.Drawing.Size(69, 13);
            heure_debutLabel.TabIndex = 3;
            heure_debutLabel.Text = "Heure debut:";
            // 
            // objectifLabel
            // 
            objectifLabel.AutoSize = true;
            objectifLabel.Location = new System.Drawing.Point(12, 155);
            objectifLabel.Name = "objectifLabel";
            objectifLabel.Size = new System.Drawing.Size(46, 13);
            objectifLabel.TabIndex = 9;
            objectifLabel.Text = "Objectif:";
            // 
            // titreLabel
            // 
            titreLabel.AutoSize = true;
            titreLabel.Location = new System.Drawing.Point(12, 22);
            titreLabel.Name = "titreLabel";
            titreLabel.Size = new System.Drawing.Size(31, 13);
            titreLabel.TabIndex = 11;
            titreLabel.Text = "Titre:";
            // 
            // heure_finLabel
            // 
            heure_finLabel.AutoSize = true;
            heure_finLabel.Location = new System.Drawing.Point(12, 129);
            heure_finLabel.Name = "heure_finLabel";
            heure_finLabel.Size = new System.Drawing.Size(53, 13);
            heure_finLabel.TabIndex = 12;
            heure_finLabel.Text = "Heure fin:";
            // 
            // date_seanceDateTimePicker
            // 
            this.date_seanceDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.seanceBindingSource, "Date_seance", true));
            this.date_seanceDateTimePicker.Location = new System.Drawing.Point(89, 74);
            this.date_seanceDateTimePicker.Name = "date_seanceDateTimePicker";
            this.date_seanceDateTimePicker.Size = new System.Drawing.Size(244, 20);
            this.date_seanceDateTimePicker.TabIndex = 2;
            // 
            // heure_debutTextBox
            // 
            this.heure_debutTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seanceBindingSource, "Heure_debut", true));
            this.heure_debutTextBox.Location = new System.Drawing.Point(89, 100);
            this.heure_debutTextBox.Name = "heure_debutTextBox";
            this.heure_debutTextBox.Size = new System.Drawing.Size(244, 20);
            this.heure_debutTextBox.TabIndex = 4;
            this.heure_debutTextBox.Leave += new System.EventHandler(this.heure_debutTextBox_Leave);
            // 
            // objectifTextBox
            // 
            this.objectifTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seanceBindingSource, "Objectif", true));
            this.objectifTextBox.Location = new System.Drawing.Point(89, 152);
            this.objectifTextBox.Multiline = true;
            this.objectifTextBox.Name = "objectifTextBox";
            this.objectifTextBox.Size = new System.Drawing.Size(244, 177);
            this.objectifTextBox.TabIndex = 10;
            this.objectifTextBox.Leave += new System.EventHandler(this.objectifTextBox_Leave);
            // 
            // titreTextBox
            // 
            this.titreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seanceBindingSource, "Titre", true));
            this.titreTextBox.Location = new System.Drawing.Point(89, 19);
            this.titreTextBox.Name = "titreTextBox";
            this.titreTextBox.Size = new System.Drawing.Size(244, 20);
            this.titreTextBox.TabIndex = 12;
            this.titreTextBox.Leave += new System.EventHandler(this.titreTextBox_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(codeLabel);
            this.groupBox1.Controls.Add(this.codeTextBox);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(heure_finLabel);
            this.groupBox1.Controls.Add(this.heure_finTextBox);
            this.groupBox1.Controls.Add(this.titreTextBox);
            this.groupBox1.Controls.Add(heure_debutLabel);
            this.groupBox1.Controls.Add(date_seanceLabel);
            this.groupBox1.Controls.Add(objectifLabel);
            this.groupBox1.Controls.Add(this.heure_debutTextBox);
            this.groupBox1.Controls.Add(this.objectifTextBox);
            this.groupBox1.Controls.Add(titreLabel);
            this.groupBox1.Controls.Add(this.date_seanceDateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 366);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seance :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "anuller";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // heure_finTextBox
            // 
            this.heure_finTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seanceBindingSource, "Heure_fin", true));
            this.heure_finTextBox.Location = new System.Drawing.Point(89, 126);
            this.heure_finTextBox.Name = "heure_finTextBox";
            this.heure_finTextBox.Size = new System.Drawing.Size(244, 20);
            this.heure_finTextBox.TabIndex = 13;
            this.heure_finTextBox.Leave += new System.EventHandler(this.heure_finTextBox_Leave);
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(12, 50);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(35, 13);
            codeLabel.TabIndex = 15;
            codeLabel.Text = "Code:";
            // 
            // codeTextBox
            // 
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seanceBindingSource, "Code", true));
            this.codeTextBox.Location = new System.Drawing.Point(89, 45);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(244, 20);
            this.codeTextBox.TabIndex = 16;
            this.codeTextBox.Leave += new System.EventHandler(this.codeTextBox_Leave);
            // 
            // seanceBindingSource
            // 
            this.seanceBindingSource.DataSource = typeof(CompetencePlus.PackageSeances.Seance);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // formseance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 382);
            this.Controls.Add(this.groupBox1);
            this.Name = "formseance";
            this.Text = "formseance";
            this.Load += new System.EventHandler(this.formseance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource seanceBindingSource;
        private System.Windows.Forms.DateTimePicker date_seanceDateTimePicker;
        private System.Windows.Forms.TextBox heure_debutTextBox;
        private System.Windows.Forms.TextBox objectifTextBox;
        private System.Windows.Forms.TextBox titreTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox heure_finTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}