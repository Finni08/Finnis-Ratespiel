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
    public partial class Einstellungen : Form
    {

        Form1 f1;
        public Einstellungen(Form1 f1)
        {
            this.f1 = f1;
            InitializeComponent();
        }

        private void btnKindergarten_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Language == "Deutsch")
            {
                f1.lblheader.Text = "Errate eine Zahl zwischen 1 und 10";
            }
            else if (Properties.Settings.Default.Language == "English")
            {
                f1.lblheader.Text = "Guess a number between 1 and 10";
            }
            else
            {
                f1.lblheader.Text = "Devinez un nombre compris entre 1 et 10";
            }
            Properties.Settings.Default.Difficulty = "Kindergarten: 1-10";
            f1.Obergrenze = 10;
            f1.ZahlFestlegen();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Language == "Deutsch")
            {
                f1.lblheader.Text = "Errate eine Zahl zwischen 1 und 100";
            }
            else if (Properties.Settings.Default.Language == "English")
            {
                f1.lblheader.Text = "Guess a number between 1 and 100";
            }
            else
            {
                f1.lblheader.Text = "Devinez un nombre compris entre 1 et 100";
            }
            Properties.Settings.Default.Difficulty = "Easy: 1-100";
            f1.Obergrenze = 100;
            f1.ZahlFestlegen();
        }

        private void btnMiddle_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Language == "Deutsch")
            {
                f1.lblheader.Text = "Errate eine Zahl zwischen 1 und 1000";
            }
            else if (Properties.Settings.Default.Language == "English")
            {
                f1.lblheader.Text = "Guess a number between 1 and 1000";
            }
            else
            {
                f1.lblheader.Text = "Devinez un nombre compris entre 1 et 1000";
            }
            Properties.Settings.Default.Difficulty = "Middel: 1-1000";
            f1.Obergrenze = 1000;
            f1.ZahlFestlegen();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Language == "Deutsch")
            {
                f1.lblheader.Text = "Errate eine Zahl zwischen 1 und 10000";
            }
            else if (Properties.Settings.Default.Language == "English")
            {
                f1.lblheader.Text = "Guess a number between 1 and 10000";
            }
            else
            {
                f1.lblheader.Text = "Devinez un nombre compris entre 1 et 10000";
            }
            Properties.Settings.Default.Difficulty = "Hard: 1-10000";
            f1.Obergrenze = 10000;
            f1.ZahlFestlegen();
        }

        private void btnReallyHard_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Language == "Deutsch")
            {
                f1.lblheader.Text = "Errate eine Zahl zwischen 1 und 100000";
            }
            else if (Properties.Settings.Default.Language == "English")
            {
                f1.lblheader.Text = "Guess a number between 1 and 100000";
            }
            else
            {
                f1.lblheader.Text = "Devinez un nombre compris entre 1 et 100000";
            }
            Properties.Settings.Default.Difficulty = "Really Hard: 1-100000";
            f1.Obergrenze = 100000;
            f1.ZahlFestlegen();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLanguage.Text == "Deutsch")
            {
                Properties.Settings.Default.Language = "Deutsch";
                btnKindergarten.Text = "Kindergarten: 1-10";
                btnEasy.Text = "Einfach: 1-100";
                btnMiddle.Text = "Mittel: 1-1000";
                btnHard.Text = "Schwer: 1-10000";
                btnReallyHard.Text = "Sehr Schwer: 1-100000";
                f1.lblVersuche.Text = "Versuche 0";
                f1.lblWins.Text = "Wins 0";
                f1.rtbEingaben.Text = "Vorherige Eingaben";
                f1.btnSettings.Text = "Einstellungen";
                f1.btnlogin.Text = "Einloggen";
                f1.btnHelp.Text = "Hilfe";
            }
            else if (cbxLanguage.Text == "English")
            {
                Properties.Settings.Default.Language = "English";
                btnKindergarten.Text = "Kindergarten: 1-10";
                btnEasy.Text = "Easy: 1-100";
                btnMiddle.Text = "Middel: 1-1000";
                btnHard.Text = "Hard: 1-10000";
                btnReallyHard.Text = "Really Hard: 1-100000";
                f1.lblVersuche.Text = "tries 0";
                f1.lblWins.Text = "Wins 0";
                f1.rtbEingaben.Text = "previous entries";
                f1.btnSettings.Text = "Settings";
                f1.btnlogin.Text = "log in";
                f1.btnHelp.Text = "Help";
            }
            else
            {
                Properties.Settings.Default.Language = "français";
                btnKindergarten.Text = "Maternelle: 1-10";
                btnEasy.Text = "Simple: 1-100";
                btnMiddle.Text = "Moyenne: 1-1000";
                btnHard.Text = "Difficile: 1-10000";
                btnReallyHard.Text = "Très difficile: 1-100000";
                f1.lblVersuche.Text = "essayer 0";
                f1.lblWins.Text = "Victoires 0";
                f1.rtbEingaben.Text = "entrées précédentes";
                f1.btnSettings.Text = "paramètres";
                f1.btnlogin.Text = "se connecter";
                f1.btnHelp.Text = "Aide";
            }
            if (Properties.Settings.Default.Language == "Deutsch")
            {
                if (Properties.Settings.Default.Difficulty == "Kindergarten: 1-10")
                {
                    f1.lblheader.Text = "Errate eine Zahl zwischen 1 und 10";
                }
                else if (Properties.Settings.Default.Difficulty == "Easy: 1-100")
                {
                    f1.lblheader.Text = "Errate eine Zahl zwischen 1 und 100";
                }
                else if (Properties.Settings.Default.Difficulty == "Middel: 1-1000")
                {
                    f1.lblheader.Text = "Errate eine Zahl zwischen 1 und 1000";
                }
                else if (Properties.Settings.Default.Difficulty == "Hard: 1-10000")
                {
                    f1.lblheader.Text = "Errate eine Zahl zwischen 1 und 10000";
                }
                else
                {
                    f1.lblheader.Text = "Errate eine Zahl zwischen 1 und 100000";
                }
            }
            else if (Properties.Settings.Default.Language == "English")
            {
                if (Properties.Settings.Default.Difficulty == "Kindergarten: 1-10")
                {
                    f1.lblheader.Text = "Guess a number between 1 and 10";
                }
                else if (Properties.Settings.Default.Difficulty == "Easy: 1-100")
                {
                    f1.lblheader.Text = "Guess a number between 1 and 100";
                }
                else if (Properties.Settings.Default.Difficulty == "Middel: 1-1000")
                {
                    f1.lblheader.Text = "Guess a number between 1 and 1000";
                }
                else if (Properties.Settings.Default.Difficulty == "Hard: 1-10000")
                {
                    f1.lblheader.Text = "Guess a number between 1 and 10000";
                }
                else
                {
                    f1.lblheader.Text = "Guess a number between 1 and 100000";
                }
            }
            else if(Properties.Settings.Default.Language == "français")
            {
                if (Properties.Settings.Default.Difficulty == "Kindergarten: 1-10")
                {
                    f1.lblheader.Text = "Devinez un nombre compris entre 1 et 10";
                }
                else if (Properties.Settings.Default.Difficulty == "Easy: 1-100")
                {
                    f1.lblheader.Text = "Devinez un nombre compris entre 1 et 100";
                }
                else if (Properties.Settings.Default.Difficulty == "Middel: 1-1000")
                {
                    f1.lblheader.Text = "Devinez un nombre compris entre 1 et 1000";
                }
                else if (Properties.Settings.Default.Difficulty == "Hard: 1-10000")
                {
                    f1.lblheader.Text = "Devinez un nombre compris entre 1 et 10000";
                }
                else
                {
                    f1.lblheader.Text = "Devinez un nombre compris entre 1 et 100000";
                }
            }
            Properties.Settings.Default.Save();
        }
    }
}
