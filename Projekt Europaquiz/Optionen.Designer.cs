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
            this.SuspendLayout();
            // 
            // ZeitBox
            // 
            this.ZeitBox.Location = new System.Drawing.Point(226, 93);
            this.ZeitBox.Name = "ZeitBox";
            this.ZeitBox.Size = new System.Drawing.Size(100, 20);
            this.ZeitBox.TabIndex = 0;
            this.ZeitBox.Text = "30";
            // 
            // AnzahlBox
            // 
            this.AnzahlBox.Location = new System.Drawing.Point(226, 138);
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
            this.ZeitproLand.Location = new System.Drawing.Point(126, 93);
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
            this.AnzahlLänderLabel.Location = new System.Drawing.Point(12, 140);
            this.AnzahlLänderLabel.Name = "AnzahlLänderLabel";
            this.AnzahlLänderLabel.Size = new System.Drawing.Size(208, 18);
            this.AnzahlLänderLabel.TabIndex = 3;
            this.AnzahlLänderLabel.Text = "Anzahl der zuerratenen Länder";
            // 
            // Knopf
            // 
            this.Knopf.Location = new System.Drawing.Point(145, 180);
            this.Knopf.Name = "Knopf";
            this.Knopf.Size = new System.Drawing.Size(75, 23);
            this.Knopf.TabIndex = 4;
            this.Knopf.Text = "Bestätigen";
            this.Knopf.UseVisualStyleBackColor = true;
            this.Knopf.Click += new System.EventHandler(this.Knopf_Click);
            // 
            // Optionen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(387, 261);
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
    }
}