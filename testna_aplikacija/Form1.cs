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
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
            textBoxIme.Visible = false;
            textBoxPriimek.Visible = false;
            labelPriimek.Visible = false;
            labelPonoviGeslo.Visible = false;
            textBoxPonoviGeslo.Visible = false;

        }

        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            if (textBoxIme.Text != "" && textBoxPriimek.Text != "" && textBoxENaslov.Text != "" && textBoxGeslo.Text.Length >= 8)
            {
                ime = textBoxIme.Text;
                priimek = textBoxPriimek.Text;
                eNaslov = textBoxENaslov.Text;
                geslo = textBoxGeslo.Text;
                LabelPrijava.Visible = true;
                buttonOdjava.Visible = true;
                LabelPrijava.Text = "Pozdravljeni " + ime + " " + priimek + "!";
                groupBoxVnosnaPolja.Visible = false;
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
            textBoxIme.Text = "";
            textBoxPriimek.Text = "";
            textBoxENaslov.Text = "";
            textBoxGeslo.Text = "";
        }

        private void buttonRegistracija_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            labelPriimek.Visible = true;
            labelPonoviGeslo.Visible = true;
            textBoxIme.Visible = true;
            textBoxPriimek.Visible = true;
            textBoxPonoviGeslo.Visible = true;
        }

        private void buttonRegistrirajSe_Click(object sender, EventArgs e)
        {

        }

        private void buttonNazaj_Click(object sender, EventArgs e)
        {

        }
    }
}
