namespace CompetencePlus.PackageSeances
{
    partial class formgestionseance
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
            System.Windows.Forms.Label titreLabel;
            System.Windows.Forms.Label heure_debutLabel2;
            System.Windows.Forms.Label titreLabel2;
            System.Windows.Forms.Label codeLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.seanceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.seanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.titreLabel1 = new System.Windows.Forms.Label();
            this.heure_debutLabel1 = new System.Windows.Forms.Label();
            this.date_seanceLabel1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.titreTextBox = new System.Windows.Forms.TextBox();
            this.heure_debutTextBox = new System.Windows.Forms.TextBox();
            this.codeLabel1 = new System.Windows.Forms.Label();
            date_seanceLabel = new System.Windows.Forms.Label();
            heure_debutLabel = new System.Windows.Forms.Label();
            titreLabel = new System.Windows.Forms.Label();
            heure_debutLabel2 = new System.Windows.Forms.Label();
            titreLabel2 = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seanceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seanceBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // date_seanceLabel
            // 
            date_seanceLabel.AutoSize = true;
            date_seanceLabel.Location = new System.Drawing.Point(9, 80);
            date_seanceLabel.Name = "date_seanceLabel";
            date_seanceLabel.Size = new System.Drawing.Size(71, 13);
            date_seanceLabel.TabIndex = 0;
            date_seanceLabel.Text = "Date seance:";
            // 
            // heure_debutLabel
            // 
            heure_debutLabel.AutoSize = true;
            heure_debutLabel.Location = new System.Drawing.Point(9, 108);
            heure_debutLabel.Name = "heure_debutLabel";
            heure_debutLabel.Size = new System.Drawing.Size(69, 13);
            heure_debutLabel.TabIndex = 2;
            heure_debutLabel.Text = "Heure debut:";
            // 
            // titreLabel
            // 
            titreLabel.AutoSize = true;
            titreLabel.Location = new System.Drawing.Point(9, 21);
            titreLabel.Name = "titreLabel";
            titreLabel.Size = new System.Drawing.Size(31, 13);
            titreLabel.TabIndex = 4;
            titreLabel.Text = "Titre:";
            // 
            // heure_debutLabel2
            // 
            heure_debutLabel2.AutoSize = true;
            heure_debutLabel2.Location = new System.Drawing.Point(12, 48);
            heure_debutLabel2.Name = "heure_debutLabel2";
            heure_debutLabel2.Size = new System.Drawing.Size(69, 13);
            heure_debutLabel2.TabIndex = 2;
            heure_debutLabel2.Text = "Heure debut:";
            // 
            // titreLabel2
            // 
            titreLabel2.AutoSize = true;
            titreLabel2.Location = new System.Drawing.Point(11, 21);
            titreLabel2.Name = "titreLabel2";
            titreLabel2.Size = new System.Drawing.Size(31, 13);
            titreLabel2.TabIndex = 4;
            titreLabel2.Text = "Titre:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.seanceDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(335, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 325);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des Seances :";
            // 
            // seanceDataGridView
            // 
            this.seanceDataGridView.AutoGenerateColumns = false;
            this.seanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seanceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.update,
            this.delete});
            this.seanceDataGridView.DataSource = this.seanceBindingSource;
            this.seanceDataGridView.Location = new System.Drawing.Point(6, 22);
            this.seanceDataGridView.Name = "seanceDataGridView";
            this.seanceDataGridView.Size = new System.Drawing.Size(644, 294);
            this.seanceDataGridView.TabIndex = 0;
            this.seanceDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seanceDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Titre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Titre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Objectif";
            this.dataGridViewTextBoxColumn3.HeaderText = "Objectif";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date_seance";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date_seance";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Heure_debut";
            this.dataGridViewTextBoxColumn6.HeaderText = "Heure_debut";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Heure_fin";
            this.dataGridViewTextBoxColumn5.HeaderText = "Heure_fin";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // update
            // 
            this.update.HeaderText = "";
            this.update.Image = global::CompetencePlus.Properties.Resources.Update;
            this.update.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.update.Name = "update";
            this.update.Width = 50;
            // 
            // delete
            // 
            this.delete.HeaderText = "";
            this.delete.Image = global::CompetencePlus.Properties.Resources.Delete;
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.delete.Name = "delete";
            this.delete.Width = 50;
            // 
            // seanceBindingSource
            // 
            this.seanceBindingSource.DataSource = typeof(CompetencePlus.PackageSeances.Seance);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(codeLabel);
            this.groupBox2.Controls.Add(this.codeLabel1);
            this.groupBox2.Controls.Add(titreLabel);
            this.groupBox2.Controls.Add(this.titreLabel1);
            this.groupBox2.Controls.Add(this.heure_debutLabel1);
            this.groupBox2.Controls.Add(this.date_seanceLabel1);
            this.groupBox2.Controls.Add(date_seanceLabel);
            this.groupBox2.Controls.Add(heure_debutLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 139);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seance";
            // 
            // titreLabel1
            // 
            this.titreLabel1.Location = new System.Drawing.Point(86, 21);
            this.titreLabel1.Name = "titreLabel1";
            this.titreLabel1.Size = new System.Drawing.Size(100, 23);
            this.titreLabel1.TabIndex = 5;
            this.titreLabel1.Text = "label1";
            // 
            // heure_debutLabel1
            // 
            this.heure_debutLabel1.Location = new System.Drawing.Point(86, 108);
            this.heure_debutLabel1.Name = "heure_debutLabel1";
            this.heure_debutLabel1.Size = new System.Drawing.Size(100, 23);
            this.heure_debutLabel1.TabIndex = 3;
            this.heure_debutLabel1.Text = "label1";
            // 
            // date_seanceLabel1
            // 
            this.date_seanceLabel1.Location = new System.Drawing.Point(86, 80);
            this.date_seanceLabel1.Name = "date_seanceLabel1";
            this.date_seanceLabel1.Size = new System.Drawing.Size(100, 23);
            this.date_seanceLabel1.TabIndex = 1;
            this.date_seanceLabel1.Text = "label1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(500, 359);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 44);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(170, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = ">";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(251, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = ">>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(910, -1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "ajouter";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(titreLabel2);
            this.groupBox4.Controls.Add(this.titreTextBox);
            this.groupBox4.Controls.Add(heure_debutLabel2);
            this.groupBox4.Controls.Add(this.heure_debutTextBox);
            this.groupBox4.Location = new System.Drawing.Point(12, 213);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(317, 140);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chercher";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(236, 97);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Chercher";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // titreTextBox
            // 
            this.titreTextBox.Location = new System.Drawing.Point(88, 19);
            this.titreTextBox.Name = "titreTextBox";
            this.titreTextBox.Size = new System.Drawing.Size(222, 20);
            this.titreTextBox.TabIndex = 5;
            // 
            // heure_debutTextBox
            // 
            this.heure_debutTextBox.Location = new System.Drawing.Point(89, 45);
            this.heure_debutTextBox.Name = "heure_debutTextBox";
            this.heure_debutTextBox.Size = new System.Drawing.Size(222, 20);
            this.heure_debutTextBox.TabIndex = 3;
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(12, 49);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(35, 13);
            codeLabel.TabIndex = 6;
            codeLabel.Text = "Code:";
            // 
            // codeLabel1
            // 
            this.codeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seanceBindingSource, "Code", true));
            this.codeLabel1.Location = new System.Drawing.Point(85, 49);
            this.codeLabel1.Name = "codeLabel1";
            this.codeLabel1.Size = new System.Drawing.Size(100, 23);
            this.codeLabel1.TabIndex = 7;
            this.codeLabel1.Text = "label1";
            // 
            // formgestionseance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 415);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "formgestionseance";
            this.Text = "formgestionseance";
            this.Load += new System.EventHandler(this.formgestionseance_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seanceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seanceBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource seanceBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView seanceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn update;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label titreLabel1;
        private System.Windows.Forms.Label heure_debutLabel1;
        private System.Windows.Forms.Label date_seanceLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox titreTextBox;
        private System.Windows.Forms.TextBox heure_debutTextBox;
        private System.Windows.Forms.Label codeLabel1;
    }
}