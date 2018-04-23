namespace Projekt_Europaquiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SvgImage = new System.Windows.Forms.PictureBox();
            this.ZT = new System.Windows.Forms.Timer(this.components);
            this.Optionen_Button = new System.Windows.Forms.Button();
            this.StartKnopf = new System.Windows.Forms.Button();
            this.Lösungsbox = new System.Windows.Forms.TextBox();
            this.Zeitanzeige = new System.Windows.Forms.Label();
            this.Bestätigen = new System.Windows.Forms.Button();
            this.LandHaupstadtBox = new System.Windows.Forms.Label();
            this.GrußNachricht = new System.Windows.Forms.Label();
            this.Punktlabel = new System.Windows.Forms.Label();
            this.PictureFäröer = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PictureSanMarino = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.PictureVatikanstadt = new System.Windows.Forms.PictureBox();
            this.PictureAndorra = new System.Windows.Forms.PictureBox();
            this.PictureLichtenstein = new System.Windows.Forms.PictureBox();
            this.PictureMonaco = new System.Windows.Forms.PictureBox();
            this.PictureMalta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SvgImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureFäröer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSanMarino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureVatikanstadt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAndorra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLichtenstein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMonaco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMalta)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(500, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(710, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SvgImage
            // 
            this.SvgImage.BackColor = System.Drawing.Color.White;
            this.SvgImage.Location = new System.Drawing.Point(12, 149);
            this.SvgImage.Name = "SvgImage";
            this.SvgImage.Size = new System.Drawing.Size(1200, 850);
            this.SvgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SvgImage.TabIndex = 3;
            this.SvgImage.TabStop = false;
            // 
            // ZT
            // 
            this.ZT.Interval = 1000;
            this.ZT.Tick += new System.EventHandler(this.ZT_Tick);
            // 
            // Optionen_Button
            // 
            this.Optionen_Button.Location = new System.Drawing.Point(12, 84);
            this.Optionen_Button.Name = "Optionen_Button";
            this.Optionen_Button.Size = new System.Drawing.Size(103, 24);
            this.Optionen_Button.TabIndex = 5;
            this.Optionen_Button.Text = "Optionen";
            this.Optionen_Button.UseVisualStyleBackColor = true;
            this.Optionen_Button.Click += new System.EventHandler(this.Optionen_Button_Click);
            // 
            // StartKnopf
            // 
            this.StartKnopf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartKnopf.Location = new System.Drawing.Point(12, 38);
            this.StartKnopf.Name = "StartKnopf";
            this.StartKnopf.Size = new System.Drawing.Size(103, 40);
            this.StartKnopf.TabIndex = 7;
            this.StartKnopf.Text = "Start";
            this.StartKnopf.UseVisualStyleBackColor = true;
            this.StartKnopf.Click += new System.EventHandler(this.StartKnopf_Click);
            // 
            // Lösungsbox
            // 
            this.Lösungsbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lösungsbox.Location = new System.Drawing.Point(124, 123);
            this.Lösungsbox.Name = "Lösungsbox";
            this.Lösungsbox.Size = new System.Drawing.Size(143, 24);
            this.Lösungsbox.TabIndex = 8;
            this.Lösungsbox.Visible = false;
            // 
            // Zeitanzeige
            // 
            this.Zeitanzeige.AutoSize = true;
            this.Zeitanzeige.BackColor = System.Drawing.Color.White;
            this.Zeitanzeige.Cursor = System.Windows.Forms.Cursors.Default;
            this.Zeitanzeige.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zeitanzeige.Location = new System.Drawing.Point(12, 122);
            this.Zeitanzeige.Name = "Zeitanzeige";
            this.Zeitanzeige.Size = new System.Drawing.Size(64, 24);
            this.Zeitanzeige.TabIndex = 9;
            this.Zeitanzeige.Text = "Timer:";
            // 
            // Bestätigen
            // 
            this.Bestätigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bestätigen.Location = new System.Drawing.Point(277, 112);
            this.Bestätigen.Name = "Bestätigen";
            this.Bestätigen.Size = new System.Drawing.Size(101, 34);
            this.Bestätigen.TabIndex = 10;
            this.Bestätigen.Text = "Bestätigen";
            this.Bestätigen.UseVisualStyleBackColor = true;
            this.Bestätigen.Visible = false;
            this.Bestätigen.Click += new System.EventHandler(this.Bestätigen_Click);
            // 
            // LandHaupstadtBox
            // 
            this.LandHaupstadtBox.AutoSize = true;
            this.LandHaupstadtBox.BackColor = System.Drawing.Color.White;
            this.LandHaupstadtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LandHaupstadtBox.Location = new System.Drawing.Point(121, 102);
            this.LandHaupstadtBox.Name = "LandHaupstadtBox";
            this.LandHaupstadtBox.Size = new System.Drawing.Size(100, 18);
            this.LandHaupstadtBox.TabIndex = 11;
            this.LandHaupstadtBox.Text = "Land gesucht:";
            this.LandHaupstadtBox.Visible = false;
            // 
            // GrußNachricht
            // 
            this.GrußNachricht.AutoSize = true;
            this.GrußNachricht.BackColor = System.Drawing.Color.White;
            this.GrußNachricht.Location = new System.Drawing.Point(9, 9);
            this.GrußNachricht.Name = "GrußNachricht";
            this.GrußNachricht.Size = new System.Drawing.Size(404, 13);
            this.GrußNachricht.TabIndex = 12;
            this.GrußNachricht.Text = "Willkommen bei unserem Europaquiz, wie gut kennen Sie Europa finden Sie es raus.";
            // 
            // Punktlabel
            // 
            this.Punktlabel.AutoSize = true;
            this.Punktlabel.BackColor = System.Drawing.Color.White;
            this.Punktlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Punktlabel.Location = new System.Drawing.Point(384, 125);
            this.Punktlabel.Name = "Punktlabel";
            this.Punktlabel.Size = new System.Drawing.Size(72, 20);
            this.Punktlabel.TabIndex = 13;
            this.Punktlabel.Text = "Punkte:0";
            // 
            // PictureFäröer
            // 
            this.PictureFäröer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureFäröer.Image = ((System.Drawing.Image)(resources.GetObject("PictureFäröer.Image")));
            this.PictureFäröer.Location = new System.Drawing.Point(199, 279);
            this.PictureFäröer.Name = "PictureFäröer";
            this.PictureFäröer.Size = new System.Drawing.Size(93, 87);
            this.PictureFäröer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureFäröer.TabIndex = 14;
            this.PictureFäröer.TabStop = false;
            this.PictureFäröer.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // PictureSanMarino
            // 
            this.PictureSanMarino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureSanMarino.Image = ((System.Drawing.Image)(resources.GetObject("PictureSanMarino.Image")));
            this.PictureSanMarino.Location = new System.Drawing.Point(371, 668);
            this.PictureSanMarino.Name = "PictureSanMarino";
            this.PictureSanMarino.Size = new System.Drawing.Size(97, 91);
            this.PictureSanMarino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureSanMarino.TabIndex = 16;
            this.PictureSanMarino.TabStop = false;
            this.PictureSanMarino.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 50);
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // PictureVatikanstadt
            // 
            this.PictureVatikanstadt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureVatikanstadt.Image = ((System.Drawing.Image)(resources.GetObject("PictureVatikanstadt.Image")));
            this.PictureVatikanstadt.Location = new System.Drawing.Point(320, 699);
            this.PictureVatikanstadt.Name = "PictureVatikanstadt";
            this.PictureVatikanstadt.Size = new System.Drawing.Size(103, 99);
            this.PictureVatikanstadt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureVatikanstadt.TabIndex = 18;
            this.PictureVatikanstadt.TabStop = false;
            this.PictureVatikanstadt.Visible = false;
            // 
            // PictureAndorra
            // 
            this.PictureAndorra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureAndorra.Image = ((System.Drawing.Image)(resources.GetObject("PictureAndorra.Image")));
            this.PictureAndorra.Location = new System.Drawing.Point(177, 661);
            this.PictureAndorra.Name = "PictureAndorra";
            this.PictureAndorra.Size = new System.Drawing.Size(90, 98);
            this.PictureAndorra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureAndorra.TabIndex = 19;
            this.PictureAndorra.TabStop = false;
            this.PictureAndorra.Visible = false;
            // 
            // PictureLichtenstein
            // 
            this.PictureLichtenstein.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureLichtenstein.Image = ((System.Drawing.Image)(resources.GetObject("PictureLichtenstein.Image")));
            this.PictureLichtenstein.Location = new System.Drawing.Point(332, 600);
            this.PictureLichtenstein.Name = "PictureLichtenstein";
            this.PictureLichtenstein.Size = new System.Drawing.Size(81, 93);
            this.PictureLichtenstein.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureLichtenstein.TabIndex = 20;
            this.PictureLichtenstein.TabStop = false;
            this.PictureLichtenstein.Visible = false;
            // 
            // PictureMonaco
            // 
            this.PictureMonaco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureMonaco.Image = ((System.Drawing.Image)(resources.GetObject("PictureMonaco.Image")));
            this.PictureMonaco.Location = new System.Drawing.Point(238, 639);
            this.PictureMonaco.Name = "PictureMonaco";
            this.PictureMonaco.Size = new System.Drawing.Size(98, 102);
            this.PictureMonaco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureMonaco.TabIndex = 21;
            this.PictureMonaco.TabStop = false;
            this.PictureMonaco.Visible = false;
            // 
            // PictureMalta
            // 
            this.PictureMalta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureMalta.Image = ((System.Drawing.Image)(resources.GetObject("PictureMalta.Image")));
            this.PictureMalta.Location = new System.Drawing.Point(332, 836);
            this.PictureMalta.Name = "PictureMalta";
            this.PictureMalta.Size = new System.Drawing.Size(92, 95);
            this.PictureMalta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureMalta.TabIndex = 22;
            this.PictureMalta.TabStop = false;
            this.PictureMalta.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1684, 1020);
            this.Controls.Add(this.PictureMalta);
            this.Controls.Add(this.PictureMonaco);
            this.Controls.Add(this.PictureLichtenstein);
            this.Controls.Add(this.PictureAndorra);
            this.Controls.Add(this.PictureVatikanstadt);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.PictureSanMarino);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.PictureFäröer);
            this.Controls.Add(this.Punktlabel);
            this.Controls.Add(this.GrußNachricht);
            this.Controls.Add(this.LandHaupstadtBox);
            this.Controls.Add(this.Bestätigen);
            this.Controls.Add(this.Zeitanzeige);
            this.Controls.Add(this.Lösungsbox);
            this.Controls.Add(this.StartKnopf);
            this.Controls.Add(this.Optionen_Button);
            this.Controls.Add(this.SvgImage);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SvgImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureFäröer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSanMarino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureVatikanstadt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAndorra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLichtenstein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMonaco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMalta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox SvgImage;
        private System.Windows.Forms.Timer ZT;
        private System.Windows.Forms.Button Optionen_Button;
        private System.Windows.Forms.Button StartKnopf;
        private System.Windows.Forms.TextBox Lösungsbox;
        private System.Windows.Forms.Label Zeitanzeige;
        private System.Windows.Forms.Button Bestätigen;
        private System.Windows.Forms.Label LandHaupstadtBox;
        private System.Windows.Forms.Label GrußNachricht;
        private System.Windows.Forms.Label Punktlabel;
        private System.Windows.Forms.PictureBox PictureFäröer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox PictureSanMarino;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox PictureVatikanstadt;
        private System.Windows.Forms.PictureBox PictureAndorra;
        private System.Windows.Forms.PictureBox PictureLichtenstein;
        private System.Windows.Forms.PictureBox PictureMonaco;
        private System.Windows.Forms.PictureBox PictureMalta;
    }
}

