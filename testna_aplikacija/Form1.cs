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
                LabelPrijava.Text = "Pozdravljeni " + ime + " " + priimek + "!";
            }
            else
            {
                MessageBox.Show("Nobeno polje ne sme biti prazno!!!");
            }
        }
    }
}
