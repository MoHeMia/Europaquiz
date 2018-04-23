using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Projekt_Europaquiz
{
    public partial class Optionen : Form
    {
        public Optionen()
        {
            InitializeComponent();
        }
        public static int Zeit = 30;        // Standartwert für die Zeit
        public static int Anzahl = 10;      // Standart für die Anzahl der Länder


        private void Knopf_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(ZeitBox.Text) > 9) //Zeit muss mindestens 10 betragen
                {
                    Zeit = Convert.ToInt32(ZeitBox.Text);       //Setze neue Zeit
                    MessageBox.Show("Zeit geändert");
                }
                else
                {
                    MessageBox.Show("Die Zeit muss mindestens 10 sein");
                }
                if (Convert.ToInt32(AnzahlBox.Text) > 0 && Convert.ToInt32(AnzahlBox.Text) < 49) // Anzahl der Länder muss zwischen 1 und 48 liegen
                {
                    Anzahl = Convert.ToInt32(AnzahlBox.Text);           // Setze neue Anzahl
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

    

        private void regelknopf_Click(object sender, EventArgs e)           //Zeigt die Regeln bei Konpfdruck
        {
            MessageBox.Show("1.Land und Hauptstadt sind zu erraten." + Environment.NewLine + "2.Sie können entweder gesprochen oder eingetragen werden." + Environment.NewLine + "3.Die Eingabe muss mit [Bestätigen]im Zeitrahmen eingeloggt werden." + Environment.NewLine + "4.Es gibt Punkte für richtige Antworten." + Environment.NewLine + "5.Die Haupstadt kann nur erraten werden falls das Land Korrekt war.");
        }

        private void Urkundeknopf_Click(object sender, EventArgs e)    //Schreibt Punkte und eingebenen Namen des Teilnehmers in PDF(im Moment nicht funktionstüchtig)
        {
            string formFile = Application.StartupPath + @"/Urkunde Konzept.pdf";
            string newFile = Application.StartupPath + @"/Urkunde.pdf";
            PdfReader reader = new PdfReader(formFile);
            PdfStamper stamper = new PdfStamper(reader, new FileStream(
                newFile, FileMode.Create));
            AcroFields fields = stamper.AcroFields;

            // set form fields
            fields.SetField("Name", Namebox.Text);
            fields.SetField("Punkte", $"{Form1.Punkte}");
            
            

            // flatten form fields and close document
            stamper.FormFlattening = false;
            stamper.Close();

            MessageBox.Show("Urkunde in Debug Ordner erstellt erstellt");
        }
    }
    
}
