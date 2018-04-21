using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Europaquiz
{
    public partial class Optionen : Form
    {
        public Optionen()
        {
            InitializeComponent();
        }
        private int Zeit = 30;
        private int Anzahl = 10;


        public int getZeit()
        {
            return Zeit;
        }
        public void setZeit(int Zeit)
        {
            this.Zeit = Zeit;
        }
        public int getAnzahl()
        {
            return Anzahl;
        }
        public void setAnzahl(int Anzahl)
        {
            this.Anzahl = Anzahl;
        }

        private void Knopf_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(ZeitBox.Text) > 9)
                {
                    Zeit = Convert.ToInt32(ZeitBox.Text);
                    MessageBox.Show("Zeit geändert");
                }
                else
                {
                    MessageBox.Show("Die Zeit muss mindestens 10 sein");
                }
                if (Convert.ToInt32(AnzahlBox.Text) > 0 && Convert.ToInt32(AnzahlBox.Text) < 49)
                {
                    Anzahl = Convert.ToInt32(AnzahlBox.Text);
                    MessageBox.Show("Anzahl der Länder geändert");
                }
                else
                {
                    MessageBox.Show("Die Anzahl der Länder muss zwichen 1 und 48 liegen");
                }
            }
            catch
            {
                MessageBox.Show("Bitte gültige Werte eintagen");
            }
            
        }

        private void Regeln_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bitte gültige Werte eintagen");
        }
    }
}
