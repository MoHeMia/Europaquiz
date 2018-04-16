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




            string pfad = Application.StartupPath + @"/LänderPunkte.txt";
            // Textdatei öffnen, Umlaute richtig lesen
            StreamReader DateiLesen = new StreamReader(pfad, Encoding.Default);
            // Solange Dateiende nicht erreicht
            while (!DateiLesen.EndOfStream)
            {
                //eine Zeile aus der Textdatei lesen
                string zeile = DateiLesen.ReadLine();
                string[] daten = zeile.Split(';');
                                                

            }
            // Datei schließen
            DateiLesen.Close();
        }




       




        private void Einfärben(int farbeAlt,int farbeNeu,int LandID)
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
            Einfärben(1,8,1);
        }
    }
}


