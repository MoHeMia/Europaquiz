using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Svg;
using System.IO;
using System.Speech.Recognition;

namespace Projekt_Europaquiz
{

    public partial class Form1 : Form
    {
        /// <summary>
        /// The file path of the SVG image selected.
        /// </summary>
        private string selectedPath;

        /// <summary>
        /// Instance reference for the svgDocument used and updated throughout the manipulation of the image.
        /// </summary>
        private Svg.SvgDocument svgDocument;

        private Land[] Länder = new Land[48];
        private Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            SvgImage.Width = 1200;
            SvgImage.Height = 850;

            SVGParser.MaximumSize = new Size(SvgImage.Width, SvgImage.Height);
            selectedPath =  Application.StartupPath+@"/Europa.svg";
            svgDocument = SVGParser.GetSvgDocument(selectedPath);
            SvgImage.Image = SVGParser.GetBitmapFromSVG(selectedPath);



            int i = 0;
            string pfad = Application.StartupPath + @"/LänderPunkte.txt";
            // Textdatei öffnen, Umlaute richtig lesen
            StreamReader DateiLesen = new StreamReader(pfad, Encoding.Default);
            // Solange Dateiende nicht erreicht
            while (!DateiLesen.EndOfStream)
            {
                
                //eine Zeile aus der Textdatei lesen
                string zeile = DateiLesen.ReadLine();
                string[] daten = zeile.Split(';');

                Länder[i] = new Land();
                Länder[i].setNummer(Convert.ToInt32(daten[0]));
                Länder[i].setName(daten[1]);
                Länder[i].setpunkteLand(Convert.ToInt32(daten[2]));
                Länder[i].setHaupstadt(daten[3]);
                Länder[i].setpunkteHaupstadt(Convert.ToInt32(daten[4]));
                Länder[i].setpunkteBeides(Convert.ToInt32(daten[5]));
                i++;
            
            }
            // Datei schließen
            DateiLesen.Close();



            //Sprachsteuerung
            SpeechRecognitionEngine Recogn = new SpeechRecognitionEngine();
            Recogn.SetInputToDefaultAudioDevice();
            Recogn.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognizer_Speechrecognized);
            Recogn.SpeechRecognitionRejected += new EventHandler<SpeechRecognitionRejectedEventArgs>(recognizer_Speechnotrecognized);

            try
            {
                Grammar Grammatik = new Grammar("grammar.xml", "LänderuStädte");
                Recogn.UnloadAllGrammars();
                Recogn.LoadGrammar(Grammatik);

                Recogn.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch
            {
                MessageBox.Show("Feeeeeeehleeeeeer!");
            }
        }

        private void recognizer_Speechnotrecognized(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            MessageBox.Show("fEhLEr!");
        }

        private void recognizer_Speechrecognized(object sender, SpeechRecognizedEventArgs e)
        {
            MessageBox.Show(e.Result.Text);
        }
    




       




        private void Einfärben(int farbeAlt,int farbeNeu,int LandID)
        {
            String dateiPfad = Application.StartupPath + "/Europa(gefärbt).svg";

            StreamReader dateiLeser = File.OpenText(dateiPfad); // die Datei öffnen
            string[] Datei = new string[150]; // eine Array für die Zeilen erstellen
            int a = 0;
            while (!dateiLeser.EndOfStream) // bis zum Ende der Datei ...
            { 
                string zeile = dateiLeser.ReadLine(); // ... die nächste Zeile lesen und in einen String schreiben und ...
                Datei[a] = zeile;
                a++;
            }
            

            dateiLeser.Close();
            

            for (int i = 0; i < 85; i++)
            {
                bool enthält = Datei[i].Contains($"--{LandID}--");
                if (enthält == true)
                {
                   Datei[i]= Datei[i].Replace($"fil{farbeAlt}", $"fil{farbeNeu}");
                }
            }

            

            StreamWriter outputStreamWriter = File.CreateText(Application.StartupPath + @"/Europa(gefärbt).svg");
            for (int i = 0; i < 150; i++)
            {
                outputStreamWriter.WriteLine(Datei[i]);
            }
            outputStreamWriter.Close();


            SVGParser.MaximumSize = new Size(SvgImage.Width, SvgImage.Height);
            selectedPath = Application.StartupPath + @"/Europa(gefärbt).svg";
            svgDocument = SVGParser.GetSvgDocument(selectedPath);
            SvgImage.Image = SVGParser.GetBitmapFromSVG(selectedPath);

        }

        private void Optionen_Button_Click(object sender, EventArgs e)
        {
            Optionen option = new Optionen();
            option.Show();
            option.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetFarbe();


        }


        public void resetFarbe()
        {
            String dateiPfad = Application.StartupPath + "/Europa.svg";

            StreamReader dateiLeser = File.OpenText(dateiPfad); // die Datei öffnen
            string[] Datei = new string[150]; // eine Array für die Zeilen erstellen
            int a = 0;
            while (!dateiLeser.EndOfStream) // bis zum Ende der Datei ...
            {
                string zeile = dateiLeser.ReadLine(); // ... die nächste Zeile lesen und in einen String schreiben und ...
                Datei[a] = zeile;
                a++;
            }


            dateiLeser.Close();

            StreamWriter outputStreamWriter = File.CreateText(Application.StartupPath + @"/Europa(gefärbt).svg");
            for (int i = 0; i < 150; i++)
            {
                outputStreamWriter.WriteLine(Datei[i]);
            }
            outputStreamWriter.Close();


            SVGParser.MaximumSize = new Size(SvgImage.Width, SvgImage.Height);
            selectedPath = Application.StartupPath + @"/Europa(gefärbt).svg";
            svgDocument = SVGParser.GetSvgDocument(selectedPath);
            SvgImage.Image = SVGParser.GetBitmapFromSVG(selectedPath);
        }

        private void StartKnopf_Click(object sender, EventArgs e)
        {
            resetFarbe();
            for (int i = 0; i < 48; i++)
            {
                int aktuellesLand = rnd.Next(0, 47);
                while (Länder[aktuellesLand].getbenutzt() == true)
                {
                    aktuellesLand = rnd.Next(0, 47);
                }
                Einfärben(1, 11, Länder[aktuellesLand].getNummer());
            }
        }
    }
}


