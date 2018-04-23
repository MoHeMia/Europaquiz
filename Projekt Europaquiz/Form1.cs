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
        private Svg.SvgDocument svgDocument;        //erstelle Svg-Document

        private Land[] Länder = new Land[48];       //Array für 48 Länder
        private Random rnd = new Random();          //Erstelle Zufallsgenerator
        private int aktuellesLand;                  //Nummer des Aktuellen Lands

        private bool Landerraten = false;           //Ob Land erraten ist

        private int Zeit;                           //Zeit für den Timer

        public static int Punkte = 0;               //Punktewert

        private int AnzahlLänder;                   //Anzahl der zu erratenen Länder

        private SpeechRecognitionEngine Recogn = new SpeechRecognitionEngine();  //Erstellen der Spracherkennung
                
        private bool gestartet = false;             //Ist das Spiel gestartet

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.FormBorderStyle = FormBorderStyle.None;        //Vollbildmodus
            this.WindowState = FormWindowState.Maximized;       //Vollbildmodus

            SvgImage.Width = 1200;                              // Größe des Svg-Bilds
            SvgImage.Height = 850;

            //Füge die Svg-Datei in die Picturebox(SvgImage) ein
            SVGParser.MaximumSize = new Size(SvgImage.Width, SvgImage.Height);
            selectedPath = Application.StartupPath + @"/Europa.svg";
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
                //Fülle das Array Länder
                Länder[i] = new Land();
                Länder[i].setNummer(Convert.ToInt32(daten[0]));
                Länder[i].setName(daten[1]);
                Länder[i].setpunkteLand(Convert.ToInt32(daten[2]));
                Länder[i].setHaupstadt(daten[3]);
                Länder[i].setpunkteHauptstadt(Convert.ToInt32(daten[4]));
                Länder[i].setpunkteBeides(Convert.ToInt32(daten[5]));
                i++;

            }
            // Datei schließen
            DateiLesen.Close();



            //Sprachsteuerung 
            
            Recogn.SetInputToDefaultAudioDevice();
            Recogn.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognizer_Speechrecognized);
            Recogn.SpeechRecognitionRejected += new EventHandler<SpeechRecognitionRejectedEventArgs>(recognizer_Speechnotrecognized);

            try
            {
                Grammar Grammatik = new Grammar(Application.StartupPath + @"/grammar.xml", "LänderuStädte");
                Recogn.UnloadAllGrammars();
                Recogn.LoadGrammar(Grammatik);

                Recogn.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch
            {
                MessageBox.Show("Feeeeeeehleeeeeer!");
            }

            
        }

        private void recognizer_Speechnotrecognized(object sender, SpeechRecognitionRejectedEventArgs e)        //Wort nicht erkkannt
        {   if (gestartet == true)      //nur wenn gestartet
            {
                MessageBox.Show("Nicht erkannt!");
            }
        }

        private void recognizer_Speechrecognized(object sender, SpeechRecognizedEventArgs e)            //Wort erkannt
        {   if (gestartet == true)    //nur wenn gestartet
            {
                Lösungsbox.Text = e.Result.Text;        //füge Gesprochenes in die Lösungsbox ein
            }
        }



        private void Einfärben(int farbeAlt, int farbeNeu, int LandID)              //Methode zum einfärben
        {
            String dateiPfad = Application.StartupPath + "/Europa(gefärbt).svg";        //Pfad der Svg einlesen

            StreamReader dateiLeser = File.OpenText(dateiPfad); // die Datei öffnen
            string[] Datei = new string[150]; // eine Array für die Zeilen erstellen
            int a = 0;
            while (!dateiLeser.EndOfStream) // bis zum Ende der Datei ...
            {
                string zeile = dateiLeser.ReadLine(); // ... die nächste Zeile lesen und in einen String schreiben und ...
                Datei[a] = zeile;       //Zeilen in das Array schreiben
                a++;
            }


            dateiLeser.Close();

            //Suche nach Nummer des Land und ersetze die Farbe
            for (int i = 0; i < 85; i++)
            {
                bool enthält = Datei[i].Contains($"--{LandID}--");
                if (enthält == true)
                {
                    Datei[i] = Datei[i].Replace($"fil{farbeAlt}", $"fil{farbeNeu}");
                }
            }


            //Fülle neue Svg-Datei mit dem Array
            StreamWriter outputStreamWriter = File.CreateText(Application.StartupPath + @"/Europa(gefärbt).svg");       //Erstelle oder überschreibe die neuen Svg
            for (int i = 0; i < 150; i++)
            {
                outputStreamWriter.WriteLine(Datei[i]);
            }
            outputStreamWriter.Close();

            //Füge die neue Svg-Datei in die Picturebox(SvgImage) ein
            SVGParser.MaximumSize = new Size(SvgImage.Width, SvgImage.Height);
            selectedPath = Application.StartupPath + @"/Europa(gefärbt).svg";
            svgDocument = SVGParser.GetSvgDocument(selectedPath);
            SvgImage.Image = SVGParser.GetBitmapFromSVG(selectedPath);

        }

        private void Optionen_Button_Click(object sender, EventArgs e)  //Ruft Optionsfenster auf
        {
            Optionen option = new Optionen();
            option.Show();
            option.Focus();
        }


        public void resetFarbe()        //Methode zum reseten der Farben
        {
            String dateiPfad = Application.StartupPath + "/Europa.svg";          //Pfad der Svg einlesen

            StreamReader dateiLeser = File.OpenText(dateiPfad); // die Datei öffnen
            string[] Datei = new string[150]; // eine Array für die Zeilen erstellen
            int a = 0;
            while (!dateiLeser.EndOfStream) // bis zum Ende der Datei ...
            {
                string zeile = dateiLeser.ReadLine(); // ... die nächste Zeile lesen und in einen String schreiben und ...
                Datei[a] = zeile;           //Zeilen in das Array schreiben
                a++;
            }


            dateiLeser.Close();

            //Fülle neue Svg-Datei mit dem Array
            StreamWriter outputStreamWriter = File.CreateText(Application.StartupPath + @"/Europa(gefärbt).svg");        //Erstelle oder überschreibe die neuen Svg
            for (int i = 0; i < 150; i++)
            {
                outputStreamWriter.WriteLine(Datei[i]);
            }
            outputStreamWriter.Close();

            //Füge die neue Svg-Datei in die Picturebox(SvgImage) ein
            SVGParser.MaximumSize = new Size(SvgImage.Width, SvgImage.Height);
            selectedPath = Application.StartupPath + @"/Europa(gefärbt).svg";           
            svgDocument = SVGParser.GetSvgDocument(selectedPath);
            SvgImage.Image = SVGParser.GetBitmapFromSVG(selectedPath);
        }

        private void StartKnopf_Click(object sender, EventArgs e)  //Startet das Quiz
        {
            Zeit = Optionen.Zeit;           //Setze Zeit auf das in den Optionen angegebene
            AnzahlLänder = Optionen.Anzahl; //Setze Anzahl der Länder auf das in den Optionen angegebene

            resetFarbe();           //Resete die Farbe
            Punkte = 0;             //Punkte auf 0 gesetzt
            gestartet = true;       //Gestartet auf true gesetzt
            Bestätigen.Visible = true;      //Zeige Bestätigunsknopf
            Lösungsbox.Visible = true;      //Zeige Lösungsbox
            LandHaupstadtBox.Visible = true;    //Zeige Land/Haupstadt gesucht
            StartKnopf.Text = "Restart";        // ändere Knopfaufschrift zu "Restart" 
            wähleLand();                        //starte WähleLand()
            
            ZT.Start();     //Starte Timer

           

        }

        private void ZT_Tick(object sender, EventArgs e)
        {
            if (Zeit > 0) // Solange Timer größer 0, zähle runter
            {
                Zeit--;
                Zeitanzeige.Text = $"Timer:{Zeit}";
            }
        }

        private void Bestätigen_Click(object sender, EventArgs e)
        {

            ZT.Stop();      //Stoppe Timer
            if (Zeit == 0)      //Wenn Zeit = 0, färbe Rot
            {
                Einfärben(11, 8, Länder[aktuellesLand].getNummer());
                MessageBox.Show("Sie haben zulange gebraucht");

                Lösungsbox.Text = "";           //leere Lösungsbox

                // Setze die Zooms auf unsichtbar
                PictureFäröer.Visible = false;
                PictureAndorra.Visible = false;
                PictureLichtenstein.Visible = false;
                PictureMonaco.Visible = false;
                PictureSanMarino.Visible = false;
                PictureVatikanstadt.Visible = false;
                PictureMalta.Visible = false;


                if (AnzahlLänder > 0) //Wenn noch Länder erraten werden müssen
                {
                    wähleLand();        //starte WähleLand()
                    Zeit = Optionen.Zeit;     //Resete die Zeit
                    ZT.Start();         //Starte Timer
                }
                else
                {
                    MessageBox.Show("Ende!");    //Zeige Ende des Quiz an
                }
            }
            else
            {
                if (Landerraten == false)       //wenn Land noch nicht erraten
                {
                    if (Länder[aktuellesLand].getName() == Lösungsbox.Text)     //wenn Land richtig 
                    {
                        Einfärben(11, 9, Länder[aktuellesLand].getNummer());    //färbe Hellgrün
                        Landerraten = true;
                        LandHaupstadtBox.Text = "Hauptstadt gesucht:";     //ändere Box zu Haupstadt gesucht:
                        Lösungsbox.Text = "";                              //leere Lösungsbox

                        Punkte = Punkte + Länder[aktuellesLand].getpunkteLand();       //addiere Punkte
                        Punktlabel.Text = $"Punkte:{Punkte}";


                        //Setze die Zooms auf unsichtbar
                        PictureFäröer.Visible = false;
                        PictureAndorra.Visible = false;
                        PictureLichtenstein.Visible = false;
                        PictureMonaco.Visible = false;
                        PictureSanMarino.Visible = false;
                        PictureVatikanstadt.Visible = false;
                        PictureMalta.Visible = false;

                        //Resete die Zeit
                        Zeit = Optionen.Zeit;
                        //Starte Timer
                        ZT.Start();
                    }
                    else
                    {
                        Einfärben(11, 8, Länder[aktuellesLand].getNummer());   //wenn Land falsch färbe Rot
                        Lösungsbox.Text = "";           //leere Lösungsbox

                        // Setze die Zooms auf unsichtbar
                        PictureFäröer.Visible = false;
                        PictureAndorra.Visible = false;
                        PictureLichtenstein.Visible = false;
                        PictureMonaco.Visible = false;
                        PictureSanMarino.Visible = false;
                        PictureVatikanstadt.Visible = false;
                        PictureMalta.Visible = false;


                        if (AnzahlLänder > 0) //Wenn noch Länder erraten werden müssen
                        {
                            wähleLand();        //starte WähleLand()
                            Zeit = Optionen.Zeit;     //Resete die Zeit
                            ZT.Start();         //Starte Timer
                        }
                        else
                        {
                            MessageBox.Show("Ende!");    //Zeige Ende des Quiz an
                        }
                    }
                }
                else          //wenn Land schon erraten
                {
                    if (Länder[aktuellesLand].getHaupstadt() == Lösungsbox.Text)  //wenn Haupstadt richtig
                    {
                        Einfärben(9, 10, Länder[aktuellesLand].getNummer());        //färbe dunkelgrün
                        Lösungsbox.Text = "";                       //leere Lösungsbox
                        LandHaupstadtBox.Text = "Land gesucht:";    //ändere Box zu Land gesucht:
                        Landerraten = false;                        //setze Land erraten auf false

                        //addiere Punkte
                        Punkte = Punkte + Länder[aktuellesLand].getpunkteHauptstadt();
                        Punkte = Punkte + Länder[aktuellesLand].getpunkteBeides();
                        Punktlabel.Text = $"Punkte:{Punkte}";

                        if (AnzahlLänder > 0) //Wenn noch Länder erraten werden müssen
                        {
                            wähleLand();        //starte WähleLand()
                            Zeit = Optionen.Zeit;     //Resete die Zeit
                            ZT.Start();         //Starte Timer
                        }
                        else
                        {
                            MessageBox.Show("Ende!");    //Zeige Ende des Quiz an
                        }
                    }
                    else
                    {
                        Lösungsbox.Text = "";                       //leere Lösungsbox
                        LandHaupstadtBox.Text = "Land gesucht:";    //ändere Box zu Land gesucht:
                        Landerraten = false;                        //setze Land erraten auf false

                        if (AnzahlLänder > 0) //Wenn noch Länder erraten werden müssen
                        {
                            wähleLand();        //starte WähleLand()
                            Zeit = Optionen.Zeit;     //Resete die Zeit
                            ZT.Start();         //Starte Timer
                        }
                        else
                        {
                            MessageBox.Show("Ende!");    //Zeige Ende des Quiz an
                        }
                    }
                }
            }


            
        }


        private void wähleLand()            //wähle ein zufälliges Land aus
        {
            aktuellesLand = rnd.Next(0, 47);        //zufälliges Land
            while (Länder[aktuellesLand].getbenutzt() == true)      //Falls bereits benutz wähle nochmal
            {
                aktuellesLand = rnd.Next(0, 47);
            }
            Einfärben(1, 11, Länder[aktuellesLand].getNummer()); //Färbe das gewählte Land gelb
            Länder[aktuellesLand].setbenutzt(true);              //setze es auf benutzt
            AnzahlLänder--;                                      // ziehe von der Anzahl der zuerratenen Länder eins ab

            // Zeige bei gegeben Ländern einen gezoomten auschnitt
            if (Länder[aktuellesLand].getName()=="Färöer")
            {
                PictureFäröer.Visible = true;
            }
            if (Länder[aktuellesLand].getName() == "Monaco")
            {
                PictureMonaco.Visible = true;
            }
            if (Länder[aktuellesLand].getName() == "Andorra")
            {
                PictureAndorra.Visible = true;
            }
            if (Länder[aktuellesLand].getName() == "Liechtenstein")
            {
                PictureLichtenstein.Visible = true;
            }
            if (Länder[aktuellesLand].getName() == "Vatikanstadt")
            {
                PictureVatikanstadt.Visible = true;
            }
            if (Länder[aktuellesLand].getName() == "San Marino")
            {
                PictureSanMarino.Visible = true;
            }
            if (Länder[aktuellesLand].getName() == "Malta")
            {
                PictureMalta.Visible = true;
            }
        }
    }
}


