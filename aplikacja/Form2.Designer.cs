namespace aplikacja
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCofanie = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.w2 = new System.Windows.Forms.TextBox();
            this.w1 = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.wezel = new System.Windows.Forms.Label();
            this.buttonZamknij = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPolaczen = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::aplikacja.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(-12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1528, 707);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.buttonCofanie);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.w2);
            this.panel1.Controls.Add(this.w1);
            this.panel1.Controls.Add(this.buttonDodaj);
            this.panel1.Controls.Add(this.wezel);
            this.panel1.Location = new System.Drawing.Point(389, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 508);
            this.panel1.TabIndex = 2;
            // 
            // buttonCofanie
            // 
            this.buttonCofanie.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCofanie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCofanie.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCofanie.Location = new System.Drawing.Point(619, 405);
            this.buttonCofanie.Name = "buttonCofanie";
            this.buttonCofanie.Size = new System.Drawing.Size(140, 72);
            this.buttonCofanie.TabIndex = 14;
            this.buttonCofanie.Text = "Usuń Poprzednik";
            this.buttonCofanie.UseVisualStyleBackColor = false;
            this.buttonCofanie.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Location = new System.Drawing.Point(0, 483);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 25);
            this.panel2.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(804, 25);
            this.panel5.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(137, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(565, 61);
            this.label4.TabIndex = 7;
            this.label4.Text = "Łączenie wierzchołków";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(41, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(574, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "Zakres podawanych wierzchołków jest od ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(41, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Musisz podać połączeń";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "-";
            // 
            // w2
            // 
            this.w2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w2.Location = new System.Drawing.Point(452, 361);
            this.w2.Name = "w2";
            this.w2.Size = new System.Drawing.Size(100, 39);
            this.w2.TabIndex = 3;
            this.w2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // w1
            // 
            this.w1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w1.Location = new System.Drawing.Point(284, 360);
            this.w1.Name = "w1";
            this.w1.Size = new System.Drawing.Size(98, 39);
            this.w1.TabIndex = 2;
            this.w1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodaj.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodaj.Location = new System.Drawing.Point(349, 424);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(135, 37);
            this.buttonDodaj.TabIndex = 1;
            this.buttonDodaj.Text = "DODAJ";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // wezel
            // 
            this.wezel.AutoSize = true;
            this.wezel.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wezel.Location = new System.Drawing.Point(251, 288);
            this.wezel.Name = "wezel";
            this.wezel.Size = new System.Drawing.Size(340, 45);
            this.wezel.TabIndex = 0;
            this.wezel.Text = "Podaj 1 Połączenie";
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Location = new System.Drawing.Point(389, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(27, 508);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Location = new System.Drawing.Point(1166, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(27, 508);
            this.panel4.TabIndex = 13;
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(1231, 637);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(114, 41);
            this.buttonMenu.TabIndex = 14;
            this.buttonMenu.Text = "Cofnij";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.ButtonMenu_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.labelPolaczen);
            this.panel6.Location = new System.Drawing.Point(27, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(265, 650);
            this.panel6.TabIndex = 15;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel9.Location = new System.Drawing.Point(0, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(25, 647);
            this.panel9.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel8.Location = new System.Drawing.Point(3, 629);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(265, 21);
            this.panel8.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(31, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Lista połączeń";
            // 
            // labelPolaczen
            // 
            this.labelPolaczen.AutoSize = true;
            this.labelPolaczen.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPolaczen.Location = new System.Drawing.Point(40, 69);
            this.labelPolaczen.Name = "labelPolaczen";
            this.labelPolaczen.Size = new System.Drawing.Size(141, 31);
            this.labelPolaczen.TabIndex = 0;
            this.labelPolaczen.Text = "Połączenia";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel7.Location = new System.Drawing.Point(27, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(265, 21);
            this.panel7.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel10.Location = new System.Drawing.Point(267, 12);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(25, 650);
            this.panel10.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 690);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonZamknij);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label wezel;
        private System.Windows.Forms.TextBox w2;
        private System.Windows.Forms.TextBox w1;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonZamknij;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonCofanie;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labelPolaczen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel10;
    }
}