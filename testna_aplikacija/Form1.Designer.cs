
namespace testna_aplikacija
{
    partial class Form1
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
            this.buttonPrijava = new System.Windows.Forms.Button();
            this.buttonRegistracija = new System.Windows.Forms.Button();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPriimek = new System.Windows.Forms.TextBox();
            this.textBoxENaslov = new System.Windows.Forms.TextBox();
            this.textBoxGeslo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPriimek = new System.Windows.Forms.Label();
            this.labelENaslov = new System.Windows.Forms.Label();
            this.labelGeslo = new System.Windows.Forms.Label();
            this.LabelPrijava = new System.Windows.Forms.Label();
            this.groupBoxVnosnaPolja = new System.Windows.Forms.GroupBox();
            this.buttonOdjava = new System.Windows.Forms.Button();
            this.labelPonoviGeslo = new System.Windows.Forms.Label();
            this.textBoxPonoviGeslo = new System.Windows.Forms.TextBox();
            this.buttonRegistrirajSe = new System.Windows.Forms.Button();
            this.buttonNazaj = new System.Windows.Forms.Button();
            this.groupBoxVnosnaPolja.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPrijava
            // 
            this.buttonPrijava.Location = new System.Drawing.Point(173, 256);
            this.buttonPrijava.Name = "buttonPrijava";
            this.buttonPrijava.Size = new System.Drawing.Size(139, 35);
            this.buttonPrijava.TabIndex = 0;
            this.buttonPrijava.Text = "Prijava";
            this.buttonPrijava.UseVisualStyleBackColor = true;
            this.buttonPrijava.Click += new System.EventHandler(this.buttonPrijava_Click);
            // 
            // buttonRegistracija
            // 
            this.buttonRegistracija.Location = new System.Drawing.Point(173, 297);
            this.buttonRegistracija.Name = "buttonRegistracija";
            this.buttonRegistracija.Size = new System.Drawing.Size(139, 36);
            this.buttonRegistracija.TabIndex = 1;
            this.buttonRegistracija.Text = "Registracija";
            this.buttonRegistracija.UseVisualStyleBackColor = true;
            this.buttonRegistracija.Click += new System.EventHandler(this.buttonRegistracija_Click);
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(173, 27);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(216, 26);
            this.textBoxIme.TabIndex = 3;
            // 
            // textBoxPriimek
            // 
            this.textBoxPriimek.Location = new System.Drawing.Point(173, 71);
            this.textBoxPriimek.Name = "textBoxPriimek";
            this.textBoxPriimek.Size = new System.Drawing.Size(216, 26);
            this.textBoxPriimek.TabIndex = 4;
            // 
            // textBoxENaslov
            // 
            this.textBoxENaslov.Location = new System.Drawing.Point(173, 120);
            this.textBoxENaslov.Name = "textBoxENaslov";
            this.textBoxENaslov.Size = new System.Drawing.Size(216, 26);
            this.textBoxENaslov.TabIndex = 5;
            // 
            // textBoxGeslo
            // 
            this.textBoxGeslo.Location = new System.Drawing.Point(173, 170);
            this.textBoxGeslo.Name = "textBoxGeslo";
            this.textBoxGeslo.PasswordChar = '*';
            this.textBoxGeslo.Size = new System.Drawing.Size(216, 26);
            this.textBoxGeslo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime";
            // 
            // labelPriimek
            // 
            this.labelPriimek.AutoSize = true;
            this.labelPriimek.Location = new System.Drawing.Point(10, 77);
            this.labelPriimek.Name = "labelPriimek";
            this.labelPriimek.Size = new System.Drawing.Size(60, 20);
            this.labelPriimek.TabIndex = 8;
            this.labelPriimek.Text = "Priimek";
            // 
            // labelENaslov
            // 
            this.labelENaslov.AutoSize = true;
            this.labelENaslov.Location = new System.Drawing.Point(11, 125);
            this.labelENaslov.Name = "labelENaslov";
            this.labelENaslov.Size = new System.Drawing.Size(70, 20);
            this.labelENaslov.TabIndex = 9;
            this.labelENaslov.Text = "E-naslov";
            // 
            // labelGeslo
            // 
            this.labelGeslo.AutoSize = true;
            this.labelGeslo.Location = new System.Drawing.Point(11, 175);
            this.labelGeslo.Name = "labelGeslo";
            this.labelGeslo.Size = new System.Drawing.Size(51, 20);
            this.labelGeslo.TabIndex = 10;
            this.labelGeslo.Text = "Geslo";
            // 
            // LabelPrijava
            // 
            this.LabelPrijava.AutoSize = true;
            this.LabelPrijava.Location = new System.Drawing.Point(508, 108);
            this.LabelPrijava.Name = "LabelPrijava";
            this.LabelPrijava.Size = new System.Drawing.Size(94, 20);
            this.LabelPrijava.TabIndex = 11;
            this.LabelPrijava.Text = "LabelPrijava";
            this.LabelPrijava.Visible = false;
            // 
            // groupBoxVnosnaPolja
            // 
            this.groupBoxVnosnaPolja.Controls.Add(this.buttonNazaj);
            this.groupBoxVnosnaPolja.Controls.Add(this.buttonRegistrirajSe);
            this.groupBoxVnosnaPolja.Controls.Add(this.labelPonoviGeslo);
            this.groupBoxVnosnaPolja.Controls.Add(this.textBoxPonoviGeslo);
            this.groupBoxVnosnaPolja.Controls.Add(this.textBoxPriimek);
            this.groupBoxVnosnaPolja.Controls.Add(this.buttonPrijava);
            this.groupBoxVnosnaPolja.Controls.Add(this.labelGeslo);
            this.groupBoxVnosnaPolja.Controls.Add(this.buttonRegistracija);
            this.groupBoxVnosnaPolja.Controls.Add(this.labelENaslov);
            this.groupBoxVnosnaPolja.Controls.Add(this.labelPriimek);
            this.groupBoxVnosnaPolja.Controls.Add(this.textBoxIme);
            this.groupBoxVnosnaPolja.Controls.Add(this.label1);
            this.groupBoxVnosnaPolja.Controls.Add(this.textBoxENaslov);
            this.groupBoxVnosnaPolja.Controls.Add(this.textBoxGeslo);
            this.groupBoxVnosnaPolja.Location = new System.Drawing.Point(12, 3);
            this.groupBoxVnosnaPolja.Name = "groupBoxVnosnaPolja";
            this.groupBoxVnosnaPolja.Size = new System.Drawing.Size(467, 404);
            this.groupBoxVnosnaPolja.TabIndex = 12;
            this.groupBoxVnosnaPolja.TabStop = false;
            // 
            // buttonOdjava
            // 
            this.buttonOdjava.Location = new System.Drawing.Point(531, 206);
            this.buttonOdjava.Name = "buttonOdjava";
            this.buttonOdjava.Size = new System.Drawing.Size(162, 65);
            this.buttonOdjava.TabIndex = 13;
            this.buttonOdjava.Text = "Odjava";
            this.buttonOdjava.UseVisualStyleBackColor = true;
            this.buttonOdjava.Visible = false;
            this.buttonOdjava.Click += new System.EventHandler(this.buttonOdjava_Click);
            // 
            // labelPonoviGeslo
            // 
            this.labelPonoviGeslo.AutoSize = true;
            this.labelPonoviGeslo.Location = new System.Drawing.Point(11, 216);
            this.labelPonoviGeslo.Name = "labelPonoviGeslo";
            this.labelPonoviGeslo.Size = new System.Drawing.Size(98, 20);
            this.labelPonoviGeslo.TabIndex = 12;
            this.labelPonoviGeslo.Text = "PonoviGeslo";
            // 
            // textBoxPonoviGeslo
            // 
            this.textBoxPonoviGeslo.Location = new System.Drawing.Point(173, 211);
            this.textBoxPonoviGeslo.Name = "textBoxPonoviGeslo";
            this.textBoxPonoviGeslo.PasswordChar = '*';
            this.textBoxPonoviGeslo.Size = new System.Drawing.Size(216, 26);
            this.textBoxPonoviGeslo.TabIndex = 11;
            // 
            // buttonRegistrirajSe
            // 
            this.buttonRegistrirajSe.Location = new System.Drawing.Point(173, 297);
            this.buttonRegistrirajSe.Name = "buttonRegistrirajSe";
            this.buttonRegistrirajSe.Size = new System.Drawing.Size(139, 36);
            this.buttonRegistrirajSe.TabIndex = 13;
            this.buttonRegistrirajSe.Text = "Registriraj se";
            this.buttonRegistrirajSe.UseVisualStyleBackColor = true;
            this.buttonRegistrirajSe.Click += new System.EventHandler(this.buttonRegistrirajSe_Click);
            // 
            // buttonNazaj
            // 
            this.buttonNazaj.Location = new System.Drawing.Point(15, 336);
            this.buttonNazaj.Name = "buttonNazaj";
            this.buttonNazaj.Size = new System.Drawing.Size(108, 36);
            this.buttonNazaj.TabIndex = 14;
            this.buttonNazaj.Text = "Nazaj";
            this.buttonNazaj.UseVisualStyleBackColor = true;
            this.buttonNazaj.Click += new System.EventHandler(this.buttonNazaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOdjava);
            this.Controls.Add(this.groupBoxVnosnaPolja);
            this.Controls.Add(this.LabelPrijava);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxVnosnaPolja.ResumeLayout(false);
            this.groupBoxVnosnaPolja.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrijava;
        private System.Windows.Forms.Button buttonRegistracija;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPriimek;
        private System.Windows.Forms.TextBox textBoxENaslov;
        private System.Windows.Forms.TextBox textBoxGeslo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPriimek;
        private System.Windows.Forms.Label labelENaslov;
        private System.Windows.Forms.Label labelGeslo;
        private System.Windows.Forms.Label LabelPrijava;
        private System.Windows.Forms.GroupBox groupBoxVnosnaPolja;
        private System.Windows.Forms.Button buttonOdjava;
        private System.Windows.Forms.Label labelPonoviGeslo;
        private System.Windows.Forms.TextBox textBoxPonoviGeslo;
        private System.Windows.Forms.Button buttonRegistrirajSe;
        private System.Windows.Forms.Button buttonNazaj;
    }
}

