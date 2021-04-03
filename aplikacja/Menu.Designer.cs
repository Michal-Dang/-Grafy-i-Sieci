namespace aplikacja
{
    partial class Menu
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
            this.tlo = new System.Windows.Forms.PictureBox();
            this.tytul = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonNieskierowany = new System.Windows.Forms.Button();
            this.buttonskierowany = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonZamknij = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tlo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlo
            // 
            this.tlo.Image = global::aplikacja.Properties.Resources.image;
            this.tlo.Location = new System.Drawing.Point(0, 0);
            this.tlo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlo.Name = "tlo";
            this.tlo.Size = new System.Drawing.Size(2037, 870);
            this.tlo.TabIndex = 0;
            this.tlo.TabStop = false;
            this.tlo.Click += new System.EventHandler(this.tlo_Click);
            // 
            // tytul
            // 
            this.tytul.BackColor = System.Drawing.Color.Transparent;
            this.tytul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tytul.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tytul.ForeColor = System.Drawing.Color.LawnGreen;
            this.tytul.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tytul.Location = new System.Drawing.Point(347, 0);
            this.tytul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tytul.Name = "tytul";
            this.tytul.Size = new System.Drawing.Size(1387, 446);
            this.tytul.TabIndex = 1;
            this.tytul.Text = "Algorytm poszukiwania maksymalnej liczby dróg krawędziowo-rozłącznych między dwom" +
    "a dowolnymi wierzchołkami grafu spójnego";
            this.tytul.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonNieskierowany);
            this.panel1.Controls.Add(this.buttonskierowany);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(495, 453);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 308);
            this.panel1.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1063, 31);
            this.panel5.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(36, 308);
            this.panel2.TabIndex = 8;
            // 
            // buttonNieskierowany
            // 
            this.buttonNieskierowany.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonNieskierowany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNieskierowany.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNieskierowany.Location = new System.Drawing.Point(688, 142);
            this.buttonNieskierowany.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNieskierowany.Name = "buttonNieskierowany";
            this.buttonNieskierowany.Size = new System.Drawing.Size(293, 112);
            this.buttonNieskierowany.TabIndex = 2;
            this.buttonNieskierowany.Text = "Nieskierowany";
            this.buttonNieskierowany.UseVisualStyleBackColor = false;
            this.buttonNieskierowany.Click += new System.EventHandler(this.ButtonNieskierowany_Click);
            // 
            // buttonskierowany
            // 
            this.buttonskierowany.BackColor = System.Drawing.Color.Aqua;
            this.buttonskierowany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonskierowany.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonskierowany.Location = new System.Drawing.Point(76, 142);
            this.buttonskierowany.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonskierowany.Name = "buttonskierowany";
            this.buttonskierowany.Size = new System.Drawing.Size(296, 112);
            this.buttonskierowany.TabIndex = 1;
            this.buttonskierowany.Text = "Skierowany";
            this.buttonskierowany.UseVisualStyleBackColor = false;
            this.buttonskierowany.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(372, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz graf";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Location = new System.Drawing.Point(1521, 453);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(36, 308);
            this.panel4.TabIndex = 9;
            // 
            // buttonZamknij
            // 
            this.buttonZamknij.BackColor = System.Drawing.Color.Red;
            this.buttonZamknij.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonZamknij.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZamknij.Location = new System.Drawing.Point(1839, 784);
            this.buttonZamknij.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonZamknij.Name = "buttonZamknij";
            this.buttonZamknij.Size = new System.Drawing.Size(147, 50);
            this.buttonZamknij.TabIndex = 7;
            this.buttonZamknij.Text = "Zamknij";
            this.buttonZamknij.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonZamknij.UseVisualStyleBackColor = false;
            this.buttonZamknij.Click += new System.EventHandler(this.ButtonZamknij_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Location = new System.Drawing.Point(495, 730);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1063, 31);
            this.panel3.TabIndex = 3;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2016, 849);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonZamknij);
            this.Controls.Add(this.tytul);
            this.Controls.Add(this.tlo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form0_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tlo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox tlo;
        private System.Windows.Forms.Label tytul;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonNieskierowany;
        private System.Windows.Forms.Button buttonskierowany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonZamknij;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
    }
}