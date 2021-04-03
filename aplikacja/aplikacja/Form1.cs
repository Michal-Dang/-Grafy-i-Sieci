using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikacja
{
    public partial class Form1 : Form
    {
        Form0 f0;
        List<int> placzenia = new List<int>();
        public Form1(Form0 f0)
        {
            InitializeComponent();
            this.f0 = f0;
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (f0.Skierowany == true)
            {
                labelgraf.Text = "Tworzenie Grafu \n Skierowanego";
            }
            else
            {
                labelgraf.Text = "Tworzenie Grafu \n Nieskierowanego";
            }
        }

        private void Zatwierdz_Click(object sender, EventArgs e)
        {

            bool sprawdz = true;
            for (int i = 0; i < wierzcholki.Text.Length; i++)
            {
                if (wierzcholki.Text[i]<'0' || wierzcholki.Text[i] > '9' || wierzcholki.Text[0]=='0')
                {
                    sprawdz = false;
                }

            }
            for (int j = 0; j < krawedzie.Text.Length; j++)
            {
                if (krawedzie.Text[j] < '0' || krawedzie.Text[j] > '9' || (krawedzie.Text[0]=='0' && krawedzie.Text.Length>1))
                {
                    sprawdz = false;
                }
            }
            if (sprawdz == false)
            {
                MessageBox.Show("Podano złe wartości!", "Komunikat");
            }
            else if (string.IsNullOrEmpty(wierzcholki.Text)==true || string.IsNullOrEmpty(krawedzie.Text)==true )
            {
                MessageBox.Show("Nie podano wszystkich wartości", "Komunikat");
            }
            else
            {

                Form2 f2 = new Form2(this,f0);
                this.Hide();
                f2.Show();
            }
        }

        private void ButtonZamknij_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
            f0.Show();
        }
    }
}
