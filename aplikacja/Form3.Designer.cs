namespace aplikacja
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelspojnosc = new System.Windows.Forms.Label();
            this.kolumna = new System.Windows.Forms.Label();
            this.wiersz = new System.Windows.Forms.Label();
            this.labelMacierz = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonZamknij = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelMaks = new System.Windows.Forms.Label();
            this.labelWynik = new System.Windows.Forms.Label();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Zatwierdz = new System.Windows.Forms.Button();
            this.panelWynik = new System.Windows.Forms.Panel();
            this.labelDrog = new System.Windows.Forms.Label();
            this.panelDown = new System.Windows.Forms.Panel();
            this.panelUp = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelWynik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.labelspojnosc);
            this.panel1.Controls.Add(this.kolumna);
            this.panel1.Controls.Add(this.wiersz);
            this.panel1.Controls.Add(this.labelMacierz);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(58, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 577);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(3, 583);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 29);
            this.panel4.TabIndex = 5;
            // 
            // labelspojnosc
            // 
            this.labelspojnosc.AutoSize = true;
            this.labelspojnosc.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelspojnosc.Location = new System.Drawing.Point(55, 461);
            this.labelspojnosc.Name = "labelspojnosc";
            this.labelspojnosc.Size = new System.Drawing.Size(128, 37);
            this.labelspojnosc.TabIndex = 4;
            this.labelspojnosc.Text = "Spojnosc";
            // 
            // kolumna
            // 
            this.kolumna.AutoSize = true;
            this.kolumna.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.kolumna.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kolumna.Location = new System.Drawing.Point(19, 114);
            this.kolumna.Name = "kolumna";
            this.kolumna.Size = new System.Drawing.Size(22, 24);
            this.kolumna.TabIndex = 3;
            this.kolumna.Text = "2";
            // 
            // wiersz
            // 
            this.wiersz.AutoSize = true;
            this.wiersz.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.wiersz.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wiersz.Location = new System.Drawing.Point(58, 85);
            this.wiersz.Name = "wiersz";
            this.wiersz.Size = new System.Drawing.Size(22, 24);
            this.wiersz.TabIndex = 2;
            this.wiersz.Text = "1";
            // 
            // labelMacierz
            // 
            this.labelMacierz.AutoSize = true;
            this.labelMacierz.BackColor = System.Drawing.Color.AliceBlue;
            this.labelMacierz.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMacierz.Location = new System.Drawing.Point(58, 114);
            this.labelMacierz.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelMacierz.Name = "labelMacierz";
            this.labelMacierz.Size = new System.Drawing.Size(243, 24);
            this.labelMacierz.TabIndex = 1;
            this.labelMacierz.Text = "Tutaj powstaje macierz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Macierz Sąsiedztwa podanego grafu\r\n";
            // 
            // buttonZamknij
            // 
            this.buttonZamknij.BackColor = System.Drawing.Color.Red;
            this.buttonZamknij.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonZamknij.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZamknij.Location = new System.Drawing.Point(1375, 637);
            this.buttonZamknij.Name = "buttonZamknij";
            this.buttonZamknij.Size = new System.Drawing.Size(110, 41);
            this.buttonZamknij.TabIndex = 2;
            this.buttonZamknij.Text = "Zamknij";
            this.buttonZamknij.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonZamknij.UseVisualStyleBackColor = false;
            this.buttonZamknij.Click += new System.EventHandler(this.ButtonZamknij_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.Location = new System.Drawing.Point(58, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 33);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Turquoise;
            this.panel3.Location = new System.Drawing.Point(12, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(49, 642);
            this.panel3.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Turquoise;
            this.panel5.Location = new System.Drawing.Point(648, 21);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(46, 642);
            this.panel5.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Turquoise;
            this.panel6.Location = new System.Drawing.Point(58, 625);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(591, 38);
            this.panel6.TabIndex = 6;
            // 
            // labelMaks
            // 
            this.labelMaks.AutoSize = true;
            this.labelMaks.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMaks.Location = new System.Drawing.Point(37, 232);
            this.labelMaks.Name = "labelMaks";
            this.labelMaks.Size = new System.Drawing.Size(675, 40);
            this.labelMaks.TabIndex = 7;
            this.labelMaks.Text = "Maksymalna ilość dróg krawędziowo-rozłącznych";
            this.labelMaks.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelWynik
            // 
            this.labelWynik.AutoSize = true;
            this.labelWynik.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWynik.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelWynik.Location = new System.Drawing.Point(317, 291);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(111, 45);
            this.labelWynik.TabIndex = 8;
            this.labelWynik.Text = "Wynik";
            // 
            // textBoxP
            // 
            this.textBoxP.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxP.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxP.Location = new System.Drawing.Point(516, 44);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(140, 35);
            this.textBoxP.TabIndex = 9;
            this.textBoxP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxK
            // 
            this.textBoxK.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxK.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxK.Location = new System.Drawing.Point(516, 109);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(140, 35);
            this.textBoxK.TabIndex = 10;
            this.textBoxK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(97, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Podaj wierzchołek początkowy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(97, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "Podaj wierzchołek końcowy";
            // 
            // Zatwierdz
            // 
            this.Zatwierdz.BackColor = System.Drawing.Color.YellowGreen;
            this.Zatwierdz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zatwierdz.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zatwierdz.Location = new System.Drawing.Point(516, 174);
            this.Zatwierdz.Name = "Zatwierdz";
            this.Zatwierdz.Size = new System.Drawing.Size(140, 35);
            this.Zatwierdz.TabIndex = 14;
            this.Zatwierdz.Text = "ZATWIERDŹ";
            this.Zatwierdz.UseVisualStyleBackColor = false;
            this.Zatwierdz.Click += new System.EventHandler(this.Zatwierdz_Click);
            // 
            // panelWynik
            // 
            this.panelWynik.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelWynik.Controls.Add(this.labelDrog);
            this.panelWynik.Controls.Add(this.panelDown);
            this.panelWynik.Controls.Add(this.labelMaks);
            this.panelWynik.Controls.Add(this.label4);
            this.panelWynik.Controls.Add(this.textBoxK);
            this.panelWynik.Controls.Add(this.Zatwierdz);
            this.panelWynik.Controls.Add(this.labelWynik);
            this.panelWynik.Controls.Add(this.label3);
            this.panelWynik.Controls.Add(this.textBoxP);
            this.panelWynik.Location = new System.Drawing.Point(740, 31);
            this.panelWynik.Name = "panelWynik";
            this.panelWynik.Size = new System.Drawing.Size(745, 577);
            this.panelWynik.TabIndex = 16;
            // 
            // labelDrog
            // 
            this.labelDrog.AutoSize = true;
            this.labelDrog.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDrog.Location = new System.Drawing.Point(55, 356);
            this.labelDrog.Name = "labelDrog";
            this.labelDrog.Size = new System.Drawing.Size(84, 28);
            this.labelDrog.TabIndex = 16;
            this.labelDrog.Text = "Droga";
            // 
            // panelDown
            // 
            this.panelDown.BackColor = System.Drawing.Color.Turquoise;
            this.panelDown.Location = new System.Drawing.Point(27, 539);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(691, 38);
            this.panelDown.TabIndex = 15;
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.Turquoise;
            this.panelUp.Location = new System.Drawing.Point(740, 21);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(745, 36);
            this.panelUp.TabIndex = 9;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Turquoise;
            this.panelLeft.Location = new System.Drawing.Point(740, 21);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(31, 587);
            this.panelLeft.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::aplikacja.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1528, 707);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Turquoise;
            this.panelRight.Location = new System.Drawing.Point(1454, 21);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(31, 587);
            this.panelRight.TabIndex = 7;
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.Honeydew;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(1233, 637);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(114, 41);
            this.buttonMenu.TabIndex = 17;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.ButtonMenu_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 690);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelUp);
            this.Controls.Add(this.buttonZamknij);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelWynik);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Wynik";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelWynik.ResumeLayout(false);
            this.panelWynik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMacierz;
        private System.Windows.Forms.Label kolumna;
        private System.Windows.Forms.Label wiersz;
        private System.Windows.Forms.Label labelspojnosc;
        private System.Windows.Forms.Button buttonZamknij;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labelMaks;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Zatwierdz;
        private System.Windows.Forms.Label labelWynik;
        private System.Windows.Forms.Panel panelWynik;
        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Label labelDrog;
    }
}