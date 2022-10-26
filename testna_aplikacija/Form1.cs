using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testna_aplikacija
{
    public partial class Form1 : Form
    {
        string ime = "";
        string priimek = "";
        string eNaslov = "";
        string geslo = "";
        string ponoviGeslo = "";
        List<PrijavniPodatki> podatki = new List<PrijavniPodatki>();
        
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
            textBoxIme.Visible = false;
            textBoxPriimek.Visible = false;
            labelPriimek.Visible = false;
            labelPonoviGeslo.Visible = false;
            textBoxPonoviGeslo.Visible = false;
            buttonNazaj.Visible = false;
            buttonRegistrirajSe.Visible = false;
            podatki.Add(new PrijavniPodatki("Admin", "hahahaha", "test", "testtest"));
        }

        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            if (textBoxENaslov.Text != "" && textBoxGeslo.Text.Length >= 8)
            {
                for (int i = 0; i < podatki.Count(); i++)
                {
                    if (podatki[i].eNaslov == textBoxENaslov.Text && podatki[i].geslo == textBoxGeslo.Text)
                    {
                        LabelPrijava.Visible = true;
                        buttonOdjava.Visible = true;
                        LabelPrijava.Text = "Pozdravljeni " + podatki[i].ime + " " + podatki[i].priimek + "!";
                        groupBoxVnosnaPolja.Visible = false;
                    }
                }
                if (!LabelPrijava.Visible)
                {
                    MessageBox.Show("Nepravilno geslo ali email");
                    textBoxENaslov.Clear();
                    textBoxGeslo.Clear();
                }

            }
            else
            {
                MessageBox.Show("Nobeno polje ne sme biti prazno!!!");
            }
        }

        private void buttonOdjava_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Odjavili ste se!");
            groupBoxVnosnaPolja.Visible = true;
            textBoxIme.Clear();
            textBoxPriimek.Clear();
            textBoxENaslov.Clear();
            textBoxGeslo.Clear();
            buttonOdjava.Visible = false;
            LabelPrijava.Visible = false;
            buttonRegistracija.Visible = true;
        }

        private void buttonRegistracija_Click(object sender, EventArgs e)
        { 
            label1.Visible = true;
            labelPriimek.Visible = true;
            labelPonoviGeslo.Visible = true;
            textBoxIme.Visible = true;
            textBoxPriimek.Visible = true;
            textBoxPonoviGeslo.Visible = true;
            buttonRegistrirajSe.Visible = true;
            buttonRegistracija.Visible = false;
            buttonPrijava.Visible = false;
            buttonNazaj.Visible = true;
        }

        private void buttonRegistrirajSe_Click(object sender, EventArgs e)
        {
            ime = textBoxIme.Text;
            priimek = textBoxPriimek.Text;
            eNaslov = textBoxENaslov.Text;
            geslo = textBoxGeslo.Text;
            ponoviGeslo = textBoxPonoviGeslo.Text;

            if (ime != "" && priimek != "" && eNaslov != "" && geslo.Length >= 8)
            {
                if (geslo == ponoviGeslo)
                {
                    podatki.Add(new PrijavniPodatki(ime, priimek, eNaslov, geslo));
                    LabelPrijava.Visible = true;
                    buttonOdjava.Visible = true;
                    LabelPrijava.Text = "Pozdravljeni " + ime + " " + priimek + "!";
                    groupBoxVnosnaPolja.Visible = false;
                    
                    label1.Visible = false;
                    textBoxIme.Visible = false;
                    textBoxPriimek.Visible = false;
                    labelPriimek.Visible = false;
                    labelPonoviGeslo.Visible = false;
                    textBoxPonoviGeslo.Visible = false;
                    buttonNazaj.Visible = false;
                    buttonRegistrirajSe.Visible = false;
                    buttonPrijava.Visible = true;
                    textBoxIme.Clear();
                    textBoxPriimek.Clear();
                    textBoxENaslov.Clear();
                    textBoxGeslo.Clear();
                    textBoxPonoviGeslo.Clear();
                }
                else
                {
                    MessageBox.Show("Geslo se ne ujemata!!!");
                    textBoxIme.Clear();
                    textBoxPriimek.Clear();
                    textBoxENaslov.Clear();
                    textBoxGeslo.Clear();
                    textBoxPonoviGeslo.Clear();
                }
            }
            else {
                MessageBox.Show("Nobeno polje ne sme biti prazno!");
                textBoxIme.Clear();
                textBoxPriimek.Clear();
                textBoxENaslov.Clear();
                textBoxGeslo.Clear();
                textBoxPonoviGeslo.Clear();
            }
        }

        private void buttonNazaj_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBoxIme.Visible = false;
            textBoxPriimek.Visible = false;
            labelPriimek.Visible = false;
            labelPonoviGeslo.Visible = false;
            textBoxPonoviGeslo.Visible = false;
            buttonNazaj.Visible = false;
            buttonPrijava.Visible = true;
            buttonRegistrirajSe.Visible = false;
            buttonRegistracija.Visible = true;
        }
    }
}
