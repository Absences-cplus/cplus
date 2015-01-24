namespace CompetencePlus.PackageAbsences
{
    partial class formcauseabsence
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
            System.Windows.Forms.Label causeLabel;
            this.absenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.causeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            causeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.absenceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // absenceBindingSource
            // 
            this.absenceBindingSource.DataSource = typeof(CompetencePlus.PackageAbsences.Absence);
            // 
            // causeLabel
            // 
            causeLabel.AutoSize = true;
            causeLabel.Location = new System.Drawing.Point(3, 15);
            causeLabel.Name = "causeLabel";
            causeLabel.Size = new System.Drawing.Size(40, 13);
            causeLabel.TabIndex = 1;
            causeLabel.Text = "Cause:";
            // 
            // causeTextBox
            // 
            this.causeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.absenceBindingSource, "Cause", true));
            this.causeTextBox.Location = new System.Drawing.Point(49, 12);
            this.causeTextBox.Multiline = true;
            this.causeTextBox.Name = "causeTextBox";
            this.causeTextBox.Size = new System.Drawing.Size(223, 142);
            this.causeTextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formcauseabsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 193);
            this.Controls.Add(this.button1);
            this.Controls.Add(causeLabel);
            this.Controls.Add(this.causeTextBox);
            this.Name = "formcauseabsence";
            this.Text = "formcauseabsence";
            ((System.ComponentModel.ISupportInitialize)(this.absenceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource absenceBindingSource;
        private System.Windows.Forms.TextBox causeTextBox;
        private System.Windows.Forms.Button button1;

    }
}