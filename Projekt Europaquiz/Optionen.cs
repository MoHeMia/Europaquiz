﻿using System;
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
        public static int Zeit = 30;
        public static int Anzahl = 10;


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

    

        private void regelknopf_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.Land und Hauptstadt sind zu erraten." + Environment.NewLine + "2.Sie können entweder gesprochen oder eingetragen werden." + Environment.NewLine + "3.Die Eingabe muss mit [Bestätigen]im Zeitrahmen eingeloggt werden." + Environment.NewLine + "Es gibt Punkte für richtige Antworten." + Environment.NewLine + "Die Haupstadt kann nur erraten werden falls das Land Korrekt war.");
        }

        private void Urkundeknopf_Click(object sender, EventArgs e)
        {
            string formFile = Application.StartupPath + @"/Urkunde Konzept.pdf";
            string newFile = @"D:\\Urkunde.pdf";
            PdfReader reader = new PdfReader(formFile);
            PdfStamper stamper = new PdfStamper(reader, new FileStream(
                newFile, FileMode.Create));
            AcroFields fields = stamper.AcroFields;

            // set form fields
            fields.SetField("Name", Namebox.Text);
            fields.SetField("Punkte", $"{Form1.Punkte}");
            
            

            // flatten form fields and close document
            stamper.FormFlattening = true;
            stamper.Close();
            
        }
    }
    
}
