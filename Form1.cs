using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public Form1()
        {
            InitializeComponent();

            ZahlFestlegen();
            lblErgebnis.Hide();
            VersucheReset();
            lblWins.Text = "Wins 0";
            rtbEingaben.Text = "Vorherige Eingaben";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (lblErgebnis.Text == "Gewonnen")
            {
                ZahlFestlegen();
                tbEingaben.Clear();
                Zurücksetzendeutsch();
                VersucheReset();
            }
            else if (lblErgebnis.Text == "Won")
            {
                ZahlFestlegen();
                tbEingaben.Clear();
                Zurücksetzenenglish();
                VersucheReset();
            }
            else if (lblErgebnis.Text == "Gagné")
            {
                ZahlFestlegen();
                tbEingaben.Clear();
                Zurücksetzenfrançais();
                VersucheReset();
            }
            else
            {
                if (Convert.ToInt32(tbEingaben.Text) == Zahl)
                {
                    if (Properties.Settings.Default.Language == "Deutsch")
                    {
                        btnlogin.Text = "Neustart";
                        Wins++;
                        lblWins.Text = "Wins " + Wins.ToString();
                        losescounter();
                        Ergebnis();
                    }
                    else if (Properties.Settings.Default.Language == "English")
                    {
                        btnlogin.Text = "restart";
                        Ergebnis();
                        Wins++;
                        lblWins.Text = "Wins " + Wins.ToString();
                        losescounter();
                    }
                    else
                    {
                        btnlogin.Text = "redémarrage";
                        Wins++;
                        lblWins.Text = "Victoires " + Wins.ToString();
                        losescounter();
                        Ergebnis();
                    }
                }
                else if (Convert.ToInt32(tbEingaben.Text) != Zahl)
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

        public void ZahlFestlegen()
        {
            Zahl = random.Next(1, Obergrenze + 1);
        }
        public void Zurücksetzendeutsch()
        {
            btnlogin.Text = "Einloggen";
            lblErgebnis.Text = "";
            rtbEingaben.Text = "Vorherige Eingaben";
        }
        public void Zurücksetzenenglish()
        {
            lblErgebnis.Text = "";
            rtbEingaben.Text = "previous entries";
            btnlogin.Text = "log in";
        }
        public void Zurücksetzenfrançais()
        {
            lblErgebnis.Text = "";
            rtbEingaben.Text = "Entrées précédentes";
            btnlogin.Text = "se connecter";
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
    }
}
