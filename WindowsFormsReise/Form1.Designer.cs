namespace WindowsFormsReise
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxTeilnehmer = new System.Windows.Forms.ListBox();
            this.buttonErstellen = new System.Windows.Forms.Button();
            this.buttonLöschen = new System.Windows.Forms.Button();
            this.comboBoxReisen = new System.Windows.Forms.ComboBox();
            this.textBoxVorname = new System.Windows.Forms.TextBox();
            this.textBoxNachname = new System.Windows.Forms.TextBox();
            this.textBoxEMail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxTeilnehmer
            // 
            this.listBoxTeilnehmer.FormattingEnabled = true;
            this.listBoxTeilnehmer.Location = new System.Drawing.Point(33, 85);
            this.listBoxTeilnehmer.Name = "listBoxTeilnehmer";
            this.listBoxTeilnehmer.Size = new System.Drawing.Size(569, 186);
            this.listBoxTeilnehmer.TabIndex = 0;
            // 
            // buttonErstellen
            // 
            this.buttonErstellen.Location = new System.Drawing.Point(440, 302);
            this.buttonErstellen.Name = "buttonErstellen";
            this.buttonErstellen.Size = new System.Drawing.Size(162, 128);
            this.buttonErstellen.TabIndex = 1;
            this.buttonErstellen.Text = "Teilnehmer erstellen";
            this.buttonErstellen.UseVisualStyleBackColor = true;
            this.buttonErstellen.Click += new System.EventHandler(this.buttonErstellen_Click);
            // 
            // buttonLöschen
            // 
            this.buttonLöschen.Location = new System.Drawing.Point(47, 459);
            this.buttonLöschen.Name = "buttonLöschen";
            this.buttonLöschen.Size = new System.Drawing.Size(555, 28);
            this.buttonLöschen.TabIndex = 2;
            this.buttonLöschen.Text = "Teilnehmer löschen";
            this.buttonLöschen.UseVisualStyleBackColor = true;
            this.buttonLöschen.Click += new System.EventHandler(this.buttonLöschen_Click);
            // 
            // comboBoxReisen
            // 
            this.comboBoxReisen.FormattingEnabled = true;
            this.comboBoxReisen.Location = new System.Drawing.Point(37, 30);
            this.comboBoxReisen.Name = "comboBoxReisen";
            this.comboBoxReisen.Size = new System.Drawing.Size(565, 21);
            this.comboBoxReisen.TabIndex = 3;
            // 
            // textBoxVorname
            // 
            this.textBoxVorname.Location = new System.Drawing.Point(60, 310);
            this.textBoxVorname.Name = "textBoxVorname";
            this.textBoxVorname.Size = new System.Drawing.Size(271, 20);
            this.textBoxVorname.TabIndex = 4;
            this.textBoxVorname.Text = "Vorname";
            // 
            // textBoxNachname
            // 
            this.textBoxNachname.Location = new System.Drawing.Point(60, 358);
            this.textBoxNachname.Name = "textBoxNachname";
            this.textBoxNachname.Size = new System.Drawing.Size(270, 20);
            this.textBoxNachname.TabIndex = 5;
            this.textBoxNachname.Text = "Nachname";
            // 
            // textBoxEMail
            // 
            this.textBoxEMail.Location = new System.Drawing.Point(60, 416);
            this.textBoxEMail.Name = "textBoxEMail";
            this.textBoxEMail.Size = new System.Drawing.Size(270, 20);
            this.textBoxEMail.TabIndex = 6;
            this.textBoxEMail.Text = "E-Mail";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 527);
            this.Controls.Add(this.textBoxEMail);
            this.Controls.Add(this.textBoxNachname);
            this.Controls.Add(this.textBoxVorname);
            this.Controls.Add(this.comboBoxReisen);
            this.Controls.Add(this.buttonLöschen);
            this.Controls.Add(this.buttonErstellen);
            this.Controls.Add(this.listBoxTeilnehmer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTeilnehmer;
        private System.Windows.Forms.Button buttonErstellen;
        private System.Windows.Forms.Button buttonLöschen;
        private System.Windows.Forms.ComboBox comboBoxReisen;
        private System.Windows.Forms.TextBox textBoxVorname;
        private System.Windows.Forms.TextBox textBoxNachname;
        private System.Windows.Forms.TextBox textBoxEMail;
    }
}

