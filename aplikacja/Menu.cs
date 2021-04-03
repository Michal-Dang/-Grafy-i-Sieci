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

    public partial class Menu : Form
    {
        public bool Skierowany;
        public Menu()
        {
            InitializeComponent();
        }

        private void Form0_Load(object sender, EventArgs e)
        {
            
            tytul.Parent = tlo;
            tytul.BackColor = Color.Transparent;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Skierowany = true;
            Graf form1 = new Graf(this);
            this.Hide();
            form1.Show();
        }

        private void ButtonNieskierowany_Click(object sender, EventArgs e)
        {
            Skierowany = false;
            Graf form1 = new Graf(this);
            this.Hide();
            form1.Show();
        }

        private void ButtonZamknij_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void tlo_Click(object sender, EventArgs e)
        {

        }
    }
}
