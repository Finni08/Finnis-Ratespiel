using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grundkurs2
{
    public partial class Form1 : Form
    {
        public Random random = new Random();
        public int Zahl = 0;
        public int Obergrenze = 10;
        public int Wins = 0;
        public int loses = 0;
        public Boolean Gewonnen = false;

        public Form1()
        {
            InitializeComponent();

            ZahlFestlegen();
            lblErgebnis.Hide();
            VersucheReset();
            Winsreset();
            Vorherigeeingaben();
            header();
            Resetbtn2();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Gewonnen == true)
            {
                ZahlFestlegen();
                tbEingaben.Clear();
                Ergebnisreset();
                VersucheReset();
                Resetbtn2();
                Vorherigeeingaben();
                Gewonnen = false;
            }
            else
            {
                if (Convert.ToInt32(tbEingaben.Text) == Zahl)
                {
                    Resetbtn();
                    Winsplus();
                    losescounter();
                    Ergebnis();
                    Gewonnen = true;
                }
                else
                {
                    Ergebnis();
                    VorherigeEingaben();
                    tbEingaben.Clear();
                    lblErgebnis.Show();
                    losescounter();
                }
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Einstellungen einstellungen = new Einstellungen(this);
            einstellungen.Show();
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        public void ZahlFestlegen()
        {
            if (Properties.Settings.Default.Difficulty == "Kindergarten: 1-10")
            {
                Obergrenze = 10;
            }
            else if (Properties.Settings.Default.Difficulty == "Easy: 1-100")
            {
                Obergrenze = 100;
            }
            else if (Properties.Settings.Default.Difficulty == "Middel: 1-1000")
            {
                Obergrenze = 1000;
            }
            else if (Properties.Settings.Default.Difficulty == "Hard: 1-10000")
            {
                Obergrenze = 10000;
            }
            else if (Properties.Settings.Default.Difficulty == "Really Hard: 1-100000")
            {
                Obergrenze = 100000;
            }
            Zahl = random.Next(1, Obergrenze + 1);
        }
        public void Ergebnisreset()
        {
            lblErgebnis.Text = "";
        }
        public void VorherigeEingaben()
        {
            rtbEingaben.Text = rtbEingaben.Text + "\n" + tbEingaben.Text;
        }
        public void VersucheReset()
        {
            if (Properties.Settings.Default.Language == "Deutsch")
            {
                lblVersuche.Text = "Versuche 0";
                loses = 0;
            }
            else if (Properties.Settings.Default.Language == "English")
            {
                lblVersuche.Text = "tries 0";
                loses = 0;
            }
            else if (Properties.Settings.Default.Language == "français")
            {
                lblVersuche.Text = "Essayer 0";
                loses = 0;
            }
        }
        public void losescounter()
        {
            if (Properties.Settings.Default.Language == "Deutsch")
            {
                loses++;
                lblVersuche.Text = "Versuche " + loses.ToString();
            }
            else if (Properties.Settings.Default.Language == "English")
            {
                loses++;
                lblVersuche.Text = "Tries " + loses.ToString();
            }
            else if (Properties.Settings.Default.Language == "français")
            {
                loses++;
                lblVersuche.Text = "Essayer " + loses.ToString();
            }
        }
        public void Ergebnis()
        {
            if (Convert.ToInt32(tbEingaben.Text) == Zahl)
            {
                if (Properties.Settings.Default.Language == "Deutsch")
                {
                    lblErgebnis.Text = "Gewonnen";
                }
                else if (Properties.Settings.Default.Language == "English")
                {
                    lblErgebnis.Text = "Won";
                }
                else if (Properties.Settings.Default.Language == "français")
                {
                    lblErgebnis.Text = "Gagné";
                }
            }
            else if (Convert.ToInt32(tbEingaben.Text) > Zahl)
            {
                if (Properties.Settings.Default.Language == "Deutsch")
                {
                    lblErgebnis.Text = "Kleiner";
                }
                else if (Properties.Settings.Default.Language == "English")
                {
                    lblErgebnis.Text = "smaller";
                }
                else if (Properties.Settings.Default.Language == "français")
                {
                    lblErgebnis.Text = "Plus petit";
                }
            }
            else if (Convert.ToInt32(tbEingaben.Text) < Zahl)
            {
                if (Properties.Settings.Default.Language == "Deutsch")
                {
                    lblErgebnis.Text = "Größer";
                }
                else if (Properties.Settings.Default.Language == "English")
                {
                    lblErgebnis.Text = "bigger";
                }
                else if (Properties.Settings.Default.Language == "français")
                {
                    lblErgebnis.Text = "Plus grand";
                }
            }
        }
        public void Winsplus()
        {
            if (Properties.Settings.Default.Language == "Deutsch")
            {
                Wins++;
                lblWins.Text = "Wins " + Wins.ToString();
            }
            else if (Properties.Settings.Default.Language == "English")
            {
                Wins++;
                lblWins.Text = "Wins " + Wins.ToString();
            }
            else if (Properties.Settings.Default.Language == "français")
            {
                Wins++;
                lblWins.Text = "Victoires " + Wins.ToString();
            }
        }
        public void Resetbtn()
        {
            if (Properties.Settings.Default.Language == "Deutsch")
            {
                btnlogin.Text = "Neustart";
            }
            else if (Properties.Settings.Default.Language == "English")
            {
                btnlogin.Text = "restart";
            }
            else if (Properties.Settings.Default.Language == "français")
            {
                btnlogin.Text = "redémarrage";
            }
        }
        public void header()
        {
            if (Properties.Settings.Default.Difficulty == "Kindergarten: 1-10")
            {
                if (Properties.Settings.Default.Language == "Deutsch")
                {
                    lblheader.Text = "Errate eine Zahl zwischen 1 und 10";
                }
                else if (Properties.Settings.Default.Language == "English")
                {
                    lblheader.Text = "Guess a number between 1 and 10";
                }
                else if (Properties.Settings.Default.Language == "français")
                {
                    lblheader.Text = "Devinez un nombre compris entre 1 et 10";
                }
            }
            else if(Properties.Settings.Default.Difficulty == "Easy: 1-100")
            {
                if (Properties.Settings.Default.Language == "Deutsch")
                {
                    lblheader.Text = "Errate eine Zahl zwischen 1 und 100";
                }
                else if (Properties.Settings.Default.Language == "English")
                {
                    lblheader.Text = "Guess a number between 1 and 100";
                }
                else if (Properties.Settings.Default.Language == "français")
                {
                    lblheader.Text = "Devinez un nombre compris entre 1 et 100";
                }
            }
            else if (Properties.Settings.Default.Difficulty == "Middel: 1-1000")
            {
                if (Properties.Settings.Default.Language == "Deutsch")
                {
                    lblheader.Text = "Errate eine Zahl zwischen 1 und 1000";
                }
                else if (Properties.Settings.Default.Language == "English")
                {
                    lblheader.Text = "Guess a number between 1 and 1000";
                }
                else if (Properties.Settings.Default.Language == "français")
                {
                    lblheader.Text = "Devinez un nombre compris entre 1 et 1000";
                }
            }
            else if (Properties.Settings.Default.Difficulty == "Hard: 1-10000")
            {
                if (Properties.Settings.Default.Language == "Deutsch")
                {
                    lblheader.Text = "Errate eine Zahl zwischen 1 und 10000";
                }
                else if (Properties.Settings.Default.Language == "English")
                {
                    lblheader.Text = "Guess a number between 1 and 10000";
                }
                else if (Properties.Settings.Default.Language == "français")
                {
                    lblheader.Text = "Devinez un nombre compris entre 1 et 10000";
                }
            }
            else if (Properties.Settings.Default.Difficulty == "Really Hard: 1-100000")
            {
                if (Properties.Settings.Default.Language == "Deutsch")
                {
                    lblheader.Text = "Errate eine Zahl zwischen 1 und 100000";
                }
                else if (Properties.Settings.Default.Language == "English")
                {
                    lblheader.Text = "Guess a number between 1 and 100000";
                }
                else if (Properties.Settings.Default.Language == "français")
                {
                    lblheader.Text = "Devinez un nombre compris entre 1 et 100000";
                }
            }
        }
        public void Resetbtn2()
        {
            if (Properties.Settings.Default.Language == "Deutsch")
            {
                btnlogin.Text = "Einloggen";
            }
            else if (Properties.Settings.Default.Language == "English")
            {
                btnlogin.Text = "log in";
            }
            else if (Properties.Settings.Default.Language == "français")
            {
                btnlogin.Text = "se connecter";
            }
        }
        public void Vorherigeeingaben()
            
        {
            if (Properties.Settings.Default.Language == "Deutsch")
            {
                rtbEingaben.Text = "Vorherige Eingaben";
            }
            else if (Properties.Settings.Default.Language == "English")
            {
                rtbEingaben.Text = "previous entries";
            }
            else if (Properties.Settings.Default.Language == "français")
            {
                rtbEingaben.Text = "Entrées précédentes";
            }
        }
        public void Winsreset()
        {
            Wins = 0;
            lblWins.Text = "Wins 0";
        }
    }
}
