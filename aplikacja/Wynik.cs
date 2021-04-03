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
    public partial class Wynik : Form
    {
        Graf f1;
        Połączenia f2;
        public int[,] M;
        Stack<int> stos = new Stack<int>();
        public Wynik(Graf f1, Połączenia f2)
        {
            InitializeComponent();
            this.f1 = f1;
            this.f2 = f2;
            M = f2.m;
        
        }

        public static int[,] Napraw(int[,] m, int[,] tmp)  //przywrocenie macierzy sasiedztwa przed znalezieniem drogi                                                                                                          
        {                                                  
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(0); j++)
                {
                    if (tmp[i, j] == 1)
                    {
                        m[i, j] = 1;
                    }
                }
            }
            return m;
        }

        public static bool Spojnosc(int[,] m, int v)  //sprawdzenie czy dana macierz jest spojna
        {                                               
            Stack<int> stos = new Stack<int>();
            bool[] odwiedzony = new bool[m.GetLength(0)];
            stos.Push(v);
            while (stos.Count > 0)
            {
                v = stos.Pop();
                if (!odwiedzony[v])
                {
                    odwiedzony[v] = true;
                    for (int i = m.GetLength(0) - 1; i >= 0; i--)
                    {
                        if (m[v, i] != 0 && !odwiedzony[i])
                        {
                            stos.Push(i);
                        }
                    }
                }
            }
            for (int j = 0; j < odwiedzony.Length; j++)
            {
                if (odwiedzony[j] == false)
                {
                    return false;
                }
            }
            return true;
        }
        static bool BFS(int[,] macierz, ref int[] rodzice, int n, int start, int koniec) 
        {
         
            bool[] odwiedzone = new bool[n];
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);
            odwiedzone[start] = true;
            while (queue.Count > 0)
            {
                int u = queue.Dequeue();
                for (int i = 0; i < n; i++)
                {
                    if (!odwiedzone[i] && macierz[u, i] > 0)
                    {
                        queue.Enqueue(i);
                        odwiedzone[i] = true;
                        rodzice[i] = u;
                    }
                }
            }
            return odwiedzone[koniec];
        }
        static int RozlaczneDrogi(int[,] macierz, int n, int start, int koniec, int[,] tmp, Stack<int> stos) 
        {
            int[] rodzice = new int[n];
            int drog = 0;
            
            

            while (BFS(macierz, ref rodzice, n, start, koniec))
            {
                drog++;
                int koniec_tmp = koniec;
                do
                {
                    stos.Push(koniec_tmp);                  
                    macierz[rodzice[koniec_tmp], koniec_tmp] -= 1;
                    tmp[rodzice[koniec_tmp], koniec_tmp] += 1;
                    koniec_tmp = rodzice[koniec_tmp];
                } while (koniec_tmp != start);
                stos.Push(koniec_tmp);
                stos.Push(-1);
            }
              
            return drog;
        }

        public string Wyswietl(string text, int[,] m)        // Wyświetlanie macierzy sasiedztwa
        {                                                   // Wyświetla maksymalnie 14 wierzchołków
            for (int i = 0; i < m.GetLength(0) && i <14; i++)
            {
         
                for (int j = 0; j < m.GetLength(0) && j<15; j++)
                {
                    string liczba = Convert.ToString(m[i, j]);

                    text += liczba;
                    if (j+1<m.GetLength(0) && j<9)
                    {
                        text += "   ";
                    }
                    else if(j + 1 < m.GetLength(0) && j>=9)
                    {
                        text += "    ";
                    }
                    
                }
                text = text + "\n";
            }
            return text;
        }
        public void Form3_Load(object sender, EventArgs e)
        {
                
            labelMacierz.Text = "";
            wiersz.Text = "";
            kolumna.Text = "";
            labelDrog.Hide();
            labelMacierz.Text =Wyswietl(labelMacierz.Text, M); 
            for (int i = 0; i < M.GetLength(0) && i <14; i++)  // tworzenie indeksow macierz sasiedztwa
            {
                wiersz.Text += i;
                kolumna.Text += i + "\n";
                if (i+1<M.GetLength(0) && i < 9)
                {
                    wiersz.Text += "   ";
                }
                else if (i + 1 < M.GetLength(0) && i>=9)
                {
                    wiersz.Text += "  ";
                }
            }
            if (Spojnosc(M, f2.v1) == false)
            {
                labelspojnosc.Text = "Graf NIE jest spójny!\nNie można wykonać algorytmu\nSpróbuj jeszcze raz utworzyć graf";
                panelWynik.Hide();
                panelUp.Hide();
                panelLeft.Hide();
                panelRight.Hide();
                panelDown.Hide();
            }
            else labelspojnosc.Text = "Graf jest spójny";
           
        }

        private void ButtonZamknij_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Zatwierdz_Click(object sender, EventArgs e)  // Wczytywanie początku i koćca wierzchołka
        {
            int n = Convert.ToInt32(f1.wierzcholki.Text);
 

            bool sprawdz = true;
            for (int i = 0; i < textBoxP.Text.Length; i++)
            {
                if (textBoxP.Text[i] < '0' || textBoxP.Text[i] > '9' || (textBoxP.Text[0] == '0' && textBoxP.Text.Length > 1))
                {
                    sprawdz = false;
                }

            }
            for (int j = 0; j < textBoxK.Text.Length; j++)
            {
                if (textBoxK.Text[j] < '0' || textBoxK.Text[j] > '9' || (textBoxK.Text[0] == '0' && textBoxK.Text.Length > 1))
                {
                    sprawdz = false;
                }
            }
            if (sprawdz == false)
            {
                MessageBox.Show("Podano złe wartości!", "Komunikat");
            }
            else if (string.IsNullOrEmpty(textBoxP.Text) == true || string.IsNullOrEmpty(textBoxK.Text) == true)
            {
                MessageBox.Show("Nie podano wszystkich wartości", "Komunikat");
            }
            else
            {
               
                int[,] tmp = new int[n, n];
                int p = Convert.ToInt32(textBoxP.Text);
                int k = Convert.ToInt32(textBoxK.Text);
                int wierzcholek = Convert.ToInt32(f1.wierzcholki.Text);
                if (p < 0 || p >= wierzcholek || k < 0 || k >= wierzcholek)
                {
                    MessageBox.Show("Podana liczba jest poza zakresem", "Komunikat");
                }
                else
                {
                    if (p == k)
                    {
                        if (M[p, k] > 0)
                        {
                            labelWynik.Text = Convert.ToString(M[p, k]);
                        }
                        else
                        {
                            labelWynik.Text = "0";
                        }
                    }
                    else {
                        int drog = RozlaczneDrogi(M, n, p, k, tmp, stos);
                        labelWynik.Text = Convert.ToString(drog);
                        panelWynik.Show();
                        M = Napraw(M, tmp);
                        labelDrog.Show();
                        labelDrog.Text = "";
                        int liczba = 0;
                        if (stos.Count() > 0)   //wyświetlanie danej drogi za pomocą stosu
                        {
                            stos.Pop();
                        }
                        while (stos.Count() > 0)
                        {

                            if (stos.Peek() != -1)
                            {
                                labelDrog.Text += stos.Pop();
                                if (stos.Count() > 0 && stos.Peek() != -1)
                                {
                                    labelDrog.Text += "->";
                                }
                            }
                            else
                            {
                                stos.Pop();
                                labelDrog.Text += "; ";
                                liczba++;
                            }
                            if (liczba == 4)
                            {
                                labelDrog.Text += "\n";
                                liczba = 0;
                            }
                        }
                    }
                }

            }
        }

        private void ButtonMenu_Click(object sender, EventArgs e) 
        {
            Menu f0=new Menu();
            this.Close();
            f0.Show();
        }
    }
}
