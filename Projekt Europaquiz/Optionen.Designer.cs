namespace Projekt_Europaquiz
{
    partial class Optionen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ZeitBox = new System.Windows.Forms.TextBox();
            this.AnzahlBox = new System.Windows.Forms.TextBox();
            this.ZeitproLand = new System.Windows.Forms.Label();
            this.AnzahlLänderLabel = new System.Windows.Forms.Label();
            this.Knopf = new System.Windows.Forms.Button();
            this.regelknopf = new System.Windows.Forms.Button();
            this.Urkundeknopf = new System.Windows.Forms.Button();
            this.Namebox = new System.Windows.Forms.TextBox();
            this.Namelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ZeitBox
            // 
            this.ZeitBox.Location = new System.Drawing.Point(226, 148);
            this.ZeitBox.Name = "ZeitBox";
            this.ZeitBox.Size = new System.Drawing.Size(100, 20);
            this.ZeitBox.TabIndex = 0;
            this.ZeitBox.Text = "30";
            // 
            // AnzahlBox
            // 
            this.AnzahlBox.Location = new System.Drawing.Point(226, 180);
            this.AnzahlBox.Name = "AnzahlBox";
            this.AnzahlBox.Size = new System.Drawing.Size(100, 20);
            this.AnzahlBox.TabIndex = 1;
            this.AnzahlBox.Text = "10";
            // 
            // ZeitproLand
            // 
            this.ZeitproLand.AutoSize = true;
            this.ZeitproLand.BackColor = System.Drawing.Color.White;
            this.ZeitproLand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeitproLand.Location = new System.Drawing.Point(126, 150);
            this.ZeitproLand.Name = "ZeitproLand";
            this.ZeitproLand.Size = new System.Drawing.Size(94, 18);
            this.ZeitproLand.TabIndex = 2;
            this.ZeitproLand.Text = "Zeit pro Land";
            // 
            // AnzahlLänderLabel
            // 
            this.AnzahlLänderLabel.AutoSize = true;
            this.AnzahlLänderLabel.BackColor = System.Drawing.Color.White;
            this.AnzahlLänderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnzahlLänderLabel.Location = new System.Drawing.Point(12, 180);
            this.AnzahlLänderLabel.Name = "AnzahlLänderLabel";
            this.AnzahlLänderLabel.Size = new System.Drawing.Size(208, 18);
            this.AnzahlLänderLabel.TabIndex = 3;
            this.AnzahlLänderLabel.Text = "Anzahl der zuerratenen Länder";
            // 
            // Knopf
            // 
            this.Knopf.Location = new System.Drawing.Point(145, 211);
            this.Knopf.Name = "Knopf";
            this.Knopf.Size = new System.Drawing.Size(75, 23);
            this.Knopf.TabIndex = 4;
            this.Knopf.Text = "Bestätigen";
            this.Knopf.UseVisualStyleBackColor = true;
            this.Knopf.Click += new System.EventHandler(this.Knopf_Click);
            // 
            // regelknopf
            // 
            this.regelknopf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regelknopf.Location = new System.Drawing.Point(92, 30);
            this.regelknopf.Name = "regelknopf";
            this.regelknopf.Size = new System.Drawing.Size(128, 41);
            this.regelknopf.TabIndex = 5;
            this.regelknopf.Text = "Zeige Regeln";
            this.regelknopf.UseVisualStyleBackColor = true;
            this.regelknopf.Click += new System.EventHandler(this.regelknopf_Click);
            // 
            // Urkundeknopf
            // 
            this.Urkundeknopf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Urkundeknopf.Location = new System.Drawing.Point(92, 77);
            this.Urkundeknopf.Name = "Urkundeknopf";
            this.Urkundeknopf.Size = new System.Drawing.Size(128, 41);
            this.Urkundeknopf.TabIndex = 6;
            this.Urkundeknopf.Text = "Erstelle Urkunde";
            this.Urkundeknopf.UseVisualStyleBackColor = true;
            this.Urkundeknopf.Click += new System.EventHandler(this.Urkundeknopf_Click);
            // 
            // Namebox
            // 
            this.Namebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namebox.Location = new System.Drawing.Point(226, 98);
            this.Namebox.Name = "Namebox";
            this.Namebox.Size = new System.Drawing.Size(100, 22);
            this.Namebox.TabIndex = 7;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.BackColor = System.Drawing.Color.White;
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.Location = new System.Drawing.Point(227, 77);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(48, 16);
            this.Namelabel.TabIndex = 8;
            this.Namelabel.Text = "Name:";
            // 
            // Optionen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(387, 261);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.Namebox);
            this.Controls.Add(this.Urkundeknopf);
            this.Controls.Add(this.regelknopf);
            this.Controls.Add(this.Knopf);
            this.Controls.Add(this.AnzahlLänderLabel);
            this.Controls.Add(this.ZeitproLand);
            this.Controls.Add(this.AnzahlBox);
            this.Controls.Add(this.ZeitBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Optionen";
            this.Text = "Optionen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ZeitBox;
        private System.Windows.Forms.TextBox AnzahlBox;
        private System.Windows.Forms.Label ZeitproLand;
        private System.Windows.Forms.Label AnzahlLänderLabel;
        private System.Windows.Forms.Button Knopf;
        private System.Windows.Forms.Button regelknopf;
        private System.Windows.Forms.Button Urkundeknopf;
        private System.Windows.Forms.TextBox Namebox;
        private System.Windows.Forms.Label Namelabel;
    }
}