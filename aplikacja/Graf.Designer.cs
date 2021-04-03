namespace aplikacja
{
    partial class Graf
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelgraf = new System.Windows.Forms.Label();
            this.Zatwierdz = new System.Windows.Forms.Button();
            this.krawedzie = new System.Windows.Forms.TextBox();
            this.wierzcholki = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonZamknij = new System.Windows.Forms.Button();
            this.tlo = new System.Windows.Forms.PictureBox();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelgraf);
            this.panel1.Controls.Add(this.Zatwierdz);
            this.panel1.Controls.Add(this.krawedzie);
            this.panel1.Controls.Add(this.wierzcholki);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(345, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 438);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Location = new System.Drawing.Point(785, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(27, 438);
            this.panel3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(27, 438);
            this.panel2.TabIndex = 9;
            // 
            // labelgraf
            // 
            this.labelgraf.AutoSize = true;
            this.labelgraf.BackColor = System.Drawing.Color.Transparent;
            this.labelgraf.Font = new System.Drawing.Font("Yu Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelgraf.Location = new System.Drawing.Point(162, 28);
            this.labelgraf.Name = "labelgraf";
            this.labelgraf.Size = new System.Drawing.Size(341, 183);
            this.labelgraf.TabIndex = 5;
            this.labelgraf.Text = "Tworzenie \r\nGrafu jakiego\r\n\r\n";
            this.labelgraf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Zatwierdz
            // 
            this.Zatwierdz.BackColor = System.Drawing.Color.YellowGreen;
            this.Zatwierdz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zatwierdz.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zatwierdz.Location = new System.Drawing.Point(532, 350);
            this.Zatwierdz.Name = "Zatwierdz";
            this.Zatwierdz.Size = new System.Drawing.Size(160, 34);
            this.Zatwierdz.TabIndex = 4;
            this.Zatwierdz.Text = "ZATWIERDŹ";
            this.Zatwierdz.UseVisualStyleBackColor = false;
            this.Zatwierdz.Click += new System.EventHandler(this.Zatwierdz_Click);
            // 
            // krawedzie
            // 
            this.krawedzie.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krawedzie.Location = new System.Drawing.Point(532, 282);
            this.krawedzie.Name = "krawedzie";
            this.krawedzie.Size = new System.Drawing.Size(160, 41);
            this.krawedzie.TabIndex = 3;
            this.krawedzie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wierzcholki
            // 
            this.wierzcholki.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wierzcholki.Location = new System.Drawing.Point(532, 209);
            this.wierzcholki.Name = "wierzcholki";
            this.wierzcholki.Size = new System.Drawing.Size(160, 41);
            this.wierzcholki.TabIndex = 2;
            this.wierzcholki.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(59, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Podaj liczbę krawędzi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(59, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj liczbę wierzchołków: ";
            // 
            // buttonZamknij
            // 
            this.buttonZamknij.BackColor = System.Drawing.Color.Red;
            this.buttonZamknij.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonZamknij.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZamknij.Location = new System.Drawing.Point(1376, 637);
            this.buttonZamknij.Name = "buttonZamknij";
            this.buttonZamknij.Size = new System.Drawing.Size(110, 41);
            this.buttonZamknij.TabIndex = 3;
            this.buttonZamknij.Text = "Zamknij";
            this.buttonZamknij.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonZamknij.UseVisualStyleBackColor = false;
            this.buttonZamknij.Click += new System.EventHandler(this.ButtonZamknij_Click);
            // 
            // tlo
            // 
            this.tlo.BackColor = System.Drawing.Color.Transparent;
            this.tlo.Image = global::aplikacja.Properties.Resources.image;
            this.tlo.Location = new System.Drawing.Point(0, 0);
            this.tlo.Name = "tlo";
            this.tlo.Size = new System.Drawing.Size(1528, 707);
            this.tlo.TabIndex = 1;
            this.tlo.TabStop = false;
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(1234, 637);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(114, 41);
            this.buttonMenu.TabIndex = 7;
            this.buttonMenu.Text = "Cofnij";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel5.Location = new System.Drawing.Point(345, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(812, 25);
            this.panel5.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Location = new System.Drawing.Point(345, 446);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(812, 25);
            this.panel4.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 690);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonZamknij);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tlo);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Graf";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox tlo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Zatwierdz;
        public System.Windows.Forms.TextBox krawedzie;
        public System.Windows.Forms.TextBox wierzcholki;
        private System.Windows.Forms.Button buttonZamknij;
        private System.Windows.Forms.Label labelgraf;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
    }
}

