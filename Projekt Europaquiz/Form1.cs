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
            selectedPath = "D:\\Europaquiz\\Europa.svg";
            svgDocument = SVGParser.GetSvgDocument(selectedPath);
            SvgImage.Image =SVGParser.GetBitmapFromSVG(selectedPath);
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BT_Click(object sender, EventArgs e)
        {
            
        }

        private void Optionen_Button_Click(object sender, EventArgs e)
        {
            Optionen option = new Optionen();
            option.Show();
            option.Focus();
        }
    }
}


