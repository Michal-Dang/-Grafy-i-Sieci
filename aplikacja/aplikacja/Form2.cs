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
    public partial class Form2 : Form
    {
        Form1 f1;
        Form0 f0;
        public  int v1, v2;
        Stack<int> s1=new Stack<int>();
        public int[,] m;
        public Form2(Form1 f1, Form0 f0)
        {
            InitializeComponent();
            this.f1 = f1;
            this.f0 = f0;
        }
        public void Zerowanie(int a, int b,int[,] m, Form0 f0) //usuwanie połaczenia poprzedniego
        {
                    if (f0.Skierowany == true)
                    {
                        m[a, b] -=1;
                    }
                    else
                    {
                if (a == b)
                {
                    m[a, b] -= 1;
                }
                else
                {
                    m[a, b] -= 1;
                    m[b, a] -= 1;
                }
                    }
 
        }
        public void Macierz(int a, int b, int[,] m) //tworzenie macierzy sąsiedztwa
        {             
                    if (f0.Skierowany==true)
                        {
                
                        m[a, b] += 1;
                        }
                    else
                        {
                if (a == b)
                {
                    m[a, b] += 1;
                }
                else
                {
                    m[a, b] += 1;
                    m[b, a] += 1;
                }
                    }

            }
        public bool Check(int v1, int v2,int [,] m) //sprawdza czy połączenie już istnieje
        {
            if (f0.Skierowany == true)
            {
                if (m[v1, v2] > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (m[v1, v2] > 0 && m[v2,v1] > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static string Wyswietl(string text, int[,] m, Form0 f0)
        {
            int ElementyWiersz = 0;

            if (f0.Skierowany == true)
            {
                for (int i = 0; i < m.GetLength(0); i++)
                {
                    for (int j = 0; j < m.GetLength(0); j++)
                    {
                        if (m[i, j] > 0)
                        {
                            int tmp = m[i, j]; //liczba konkretnego połączenia
                            while (tmp>0)
                            {
                                text += i + "->" + j + "  ";
                                tmp--;
                                ElementyWiersz++;
                                if ( ElementyWiersz==2)
                                {
                                    text += " \n";
                                    ElementyWiersz = 0;
                                }
                            }
                        }
                    }
                }
            }
            else
            {

                for (int i = 0; i < m.GetLength(0); i++)
                {
                    for (int j = i; j < m.GetLength(0); j++)
                    {

                        int tmp = m[i, j]; //liczba konkretnego połączenia
                        while (tmp > 0)
                        {
                            text += i + "<->" + j + "  ";
                            tmp--;
                            ElementyWiersz++;
                            if ( ElementyWiersz == 2)
                            {
                                text += " \n";
                                ElementyWiersz = 0;
                            }
                        }
                    }
                }
            }
            return text;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            labelPolaczen.Hide();
            m = new int[Convert.ToInt32(f1.wierzcholki.Text), Convert.ToInt32(f1.wierzcholki.Text)];
            Form3 f3 = new Form3(f1, this);
            if (Convert.ToInt32(f1.krawedzie.Text) == 0)
            {
                this.Close();
                f3.Show();
            }
            label2.Text = "Liczba wszystkich połączeń dla grafu wynosi: " +f1.krawedzie.Text;
            int liczba = Convert.ToInt32(f1.wierzcholki.Text);
            liczba--;
            label3.Text = "Zakres podawanych wierzchołków musi być od 0 do " + liczba;
        }
        private int a = 1;  //liczba polaczen

    private void Dodaj_Click(object sender, EventArgs e)
        {          
            Form3 f3 = new Form3(f1,this);
            bool sprawdz = true; 
            int liczba = Convert.ToInt32(f1.wierzcholki.Text); 
            liczba--;
            for (int i = 0; i < w1.Text.Length; i++)
            {
                if (w1.Text[i] < '0' || w1.Text[i] > '9' || (w1.Text[0]=='0' && w1.Text.Length>1))
                {
                    sprawdz = false;
                }

            }
            for (int j = 0; j < w2.Text.Length; j++)
            {
                if (w2.Text[j] < '0' || w2.Text[j] > '9' || (w2.Text[0]=='0' && w2.Text.Length>1))
                {
                    sprawdz = false;
                }
            }
            if (sprawdz == false)
            {
                MessageBox.Show("Podano złe wartości!","Komunikat");
            }
            else if (string.IsNullOrEmpty(w1.Text) == true || string.IsNullOrEmpty(w2.Text) == true)
            {
                MessageBox.Show("Nie podano wszystkich wartości","Komunikat");
            }
            else
            {
                if (Convert.ToInt32(w1.Text) < 0 || Convert.ToInt32(w1.Text) > liczba || Convert.ToInt32(w2.Text) < 0 || Convert.ToInt32(w2.Text) > liczba)
                {
                    MessageBox.Show("Podana liczba jest poza zakresem");
                }
                else
                {

                    int v1 = Convert.ToInt32(w1.Text);
                    int v2 = Convert.ToInt32(w2.Text);

                    if (a <= Convert.ToInt32(f1.krawedzie.Text.Trim()))
                    {
                        s1.Push(v1);
                        s1.Push(v2);
                        Macierz(v1, v2, m);
                        labelPolaczen.Show();
                        labelPolaczen.Text = "";
                        labelPolaczen.Text = Wyswietl(labelPolaczen.Text, m, f0);
                        a++;
                    }
                    if (a > Convert.ToInt32(f1.krawedzie.Text.Trim()))
                    {
                        if (MessageBox.Show("Dodałeś już wszystkie połączenia\nCzy chcesz przejść dalej?", "Komunikat", MessageBoxButtons.YesNo)== DialogResult.No)
                        {
                            return;
                        }
                        this.Hide();
                        f3.Show();

                    }
                        wezel.Text = "Podaj " + a + " Połączenie";
                        w1.Text = "";
                        w2.Text = "";
     
                }
                }
            
            }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (s1.Count==0) 
            {
                MessageBox.Show("Brak połączeń do usunięcia","Komunikat");
            }
            else
            {
                int v2 = s1.Pop();
                int v1 = s1.Pop();
                Zerowanie(v1, v2,m,f0);
                labelPolaczen.Text = "";
                labelPolaczen.Text = Wyswietl(labelPolaczen.Text, m, f0);
                a--;
                wezel.Text = "Podaj " + a + " Połączenie";
                w1.Text = "";
                w2.Text = "";
            }
        }

        private void ButtonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            f1.Show();
        }

        private void ButtonZamknij_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
