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

    public partial class Form0 : Form
    {
        public bool Skierowany;
        public Form0()
        {
            InitializeComponent();
        }

        private void Form0_Load(object sender, EventArgs e)
        {
            tytul.Parent = tlo;
            tytul.BackColor = Color.Transparent;
            wykonawcy.Parent = tlo;
            wykonawcy.BackColor = Color.Transparent;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Skierowany = true;
            Form1 form1 = new Form1(this);
            this.Hide();
            form1.Show();
        }

        private void ButtonNieskierowany_Click(object sender, EventArgs e)
        {
            Skierowany = false;
            Form1 form1 = new Form1(this);
            this.Hide();
            form1.Show();
        }

        private void ButtonZamknij_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
