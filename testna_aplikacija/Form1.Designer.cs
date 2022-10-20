
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
            this.buttonPozabljenoGeslo = new System.Windows.Forms.Button();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPriimek = new System.Windows.Forms.TextBox();
            this.textBoxENaslov = new System.Windows.Forms.TextBox();
            this.textBoxGeslo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonPrijava
            // 
            this.buttonPrijava.Location = new System.Drawing.Point(175, 260);
            this.buttonPrijava.Name = "buttonPrijava";
            this.buttonPrijava.Size = new System.Drawing.Size(139, 35);
            this.buttonPrijava.TabIndex = 0;
            this.buttonPrijava.Text = "Prijava";
            this.buttonPrijava.UseVisualStyleBackColor = true;
            // 
            // buttonRegistracija
            // 
            this.buttonRegistracija.Location = new System.Drawing.Point(175, 301);
            this.buttonRegistracija.Name = "buttonRegistracija";
            this.buttonRegistracija.Size = new System.Drawing.Size(139, 36);
            this.buttonRegistracija.TabIndex = 1;
            this.buttonRegistracija.Text = "Registracija";
            this.buttonRegistracija.UseVisualStyleBackColor = true;
            // 
            // buttonPozabljenoGeslo
            // 
            this.buttonPozabljenoGeslo.Location = new System.Drawing.Point(175, 343);
            this.buttonPozabljenoGeslo.Name = "buttonPozabljenoGeslo";
            this.buttonPozabljenoGeslo.Size = new System.Drawing.Size(139, 33);
            this.buttonPozabljenoGeslo.TabIndex = 2;
            this.buttonPozabljenoGeslo.Text = "Pozabljneo geslo";
            this.buttonPozabljenoGeslo.UseVisualStyleBackColor = true;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(175, 31);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(163, 26);
            this.textBoxIme.TabIndex = 3;
            // 
            // textBoxPriimek
            // 
            this.textBoxPriimek.Location = new System.Drawing.Point(175, 75);
            this.textBoxPriimek.Name = "textBoxPriimek";
            this.textBoxPriimek.Size = new System.Drawing.Size(163, 26);
            this.textBoxPriimek.TabIndex = 4;
            // 
            // textBoxENaslov
            // 
            this.textBoxENaslov.Location = new System.Drawing.Point(175, 124);
            this.textBoxENaslov.Name = "textBoxENaslov";
            this.textBoxENaslov.Size = new System.Drawing.Size(163, 26);
            this.textBoxENaslov.TabIndex = 5;
            // 
            // textBoxGeslo
            // 
            this.textBoxGeslo.Location = new System.Drawing.Point(175, 174);
            this.textBoxGeslo.Name = "textBoxGeslo";
            this.textBoxGeslo.Size = new System.Drawing.Size(163, 26);
            this.textBoxGeslo.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxGeslo);
            this.Controls.Add(this.textBoxENaslov);
            this.Controls.Add(this.textBoxPriimek);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.buttonPozabljenoGeslo);
            this.Controls.Add(this.buttonRegistracija);
            this.Controls.Add(this.buttonPrijava);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrijava;
        private System.Windows.Forms.Button buttonRegistracija;
        private System.Windows.Forms.Button buttonPozabljenoGeslo;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPriimek;
        private System.Windows.Forms.TextBox textBoxENaslov;
        private System.Windows.Forms.TextBox textBoxGeslo;
    }
}

