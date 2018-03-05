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

    public partial class Form1 : Form
    {
        Size originalSize;
        Point originalLocation;
        FormBorderStyle originalFormBorderStyle;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


            private void OnToggleFullScreen(object sender, EventArgs e)
        {
            if (this.Size != SystemInformation.PrimaryMonitorSize)
            {
                originalSize = this.Size;
                originalLocation = this.Location;
                originalFormBorderStyle = this.FormBorderStyle;

                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;

                this.Size = SystemInformation.PrimaryMonitorSize;
                this.Location = new Point(0, 0);
            }
            else
            {
                this.TopMost = false;
                this.Size = originalSize;
                this.Location = originalLocation;
                this.FormBorderStyle = originalFormBorderStyle;
            }
        } 

    }
 }

