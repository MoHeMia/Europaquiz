﻿namespace Projekt_Europaquiz
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SvgImage = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ZT = new System.Windows.Forms.Timer(this.components);
            this.BT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SvgImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(489, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 132);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(6, 12);
            this.textBox1.MaximumSize = new System.Drawing.Size(800, 600);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(404, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Willkommen bei unserem Europaquiz, wie gut kennen Sie Europa finden Sie es raus.";
            // 
            // SvgImage
            // 
            this.SvgImage.BackColor = System.Drawing.Color.White;
            this.SvgImage.Location = new System.Drawing.Point(12, 149);
            this.SvgImage.Name = "SvgImage";
            this.SvgImage.Size = new System.Drawing.Size(366, 301);
            this.SvgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SvgImage.TabIndex = 3;
            this.SvgImage.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(416, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(69, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Timer: 00:00";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ZT
            // 
            this.ZT.Interval = 1000;
            // 
            // BT
            // 
            this.BT.Location = new System.Drawing.Point(416, 39);
            this.BT.Name = "BT";
            this.BT.Size = new System.Drawing.Size(69, 23);
            this.BT.TabIndex = 5;
            this.BT.Text = "Button";
            this.BT.UseVisualStyleBackColor = true;
            this.BT.Click += new System.EventHandler(this.BT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(697, 480);
            this.Controls.Add(this.BT);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.SvgImage);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SvgImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox SvgImage;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer ZT;
        private System.Windows.Forms.Button BT;
    }
}

