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
            combolanguage();
            Kindergartenbtn();
            Easybtn();
            Middlebtn();
            Hardbtn();
            ReallyHardbtn();
        }

        private void btnKindergarten_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Difficulty = "Kindergarten: 1-10";
            f1.Obergrenze = 10;
            f1.ZahlFestlegen();
            f1.header();
            Properties.Settings.Default.Save();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.Difficulty = "Easy: 1-100";
            f1.Obergrenze = 100;
            f1.ZahlFestlegen();
            f1.header();
            Properties.Settings.Default.Save();
        }

        private void btnMiddle_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Difficulty = "Medium: 1-1000";
            f1.Obergrenze = 1000;
            f1.ZahlFestlegen();
            f1.header();
            Properties.Settings.Default.Save();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Difficulty = "Hard: 1-10000";
            f1.Obergrenze = 10000;
            f1.ZahlFestlegen();
            f1.header();
            Properties.Settings.Default.Save();
        }

        private void btnReallyHard_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Difficulty = "Really Hard: 1-100000";
            f1.Obergrenze = 100000;
            f1.ZahlFestlegen();
            f1.header();
            Properties.Settings.Default.Save();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLanguage.Text == "Deutsch")
            {
                Properties.Settings.Default.Language = "Deutsch";
            }
            else if (cbxLanguage.Text == "English")
            {
                Properties.Settings.Default.Language = "English";
            }
            else
            {
                Properties.Settings.Default.Language = "français";
            }
            f1.header();
            f1.VersucheReset();
            f1.Winsreset();
            f1.Vorherigeeingaben();
            f1.Settingslanguage();
            f1.Resetbtn2();
            f1.Helplanguage();
            Kindergartenbtn();
            Easybtn();
            Middlebtn();
            Hardbtn();
            ReallyHardbtn();
            Properties.Settings.Default.Save();
        }
        public void combolanguage()
        {
            if (Properties.Settings.Default.Language == "Deutsch")
            {
                cbxLanguage.Text = "Deutsch";
            }
            else if (Properties.Settings.Default.Language == "English")
            {
                cbxLanguage.Text = "English";
            }
            else if (Properties.Settings.Default.Language == "français")
            {
                cbxLanguage.Text = "français";
            }
        }
        public void Kindergartenbtn()
        {
            if (Properties.Settings.Default.Language == "Deutsch")
            {
                btnKindergarten.Text = "Kindergarten: 1-10";
            }
            else if (Properties.Settings.Default.Language == "English")
            {
                btnKindergarten.Text = "kindergarten: 1-10";
            }
            else if (Properties.Settings.Default.Language == "français")
            {
                btnKindergarten.Text = "Jardin d'enfants: 1-10";
            }
        }
        public void Easybtn()
        {
            if (Properties.Settings.Default.Language == "Deutsch")
            {
                btnEasy.Text = "Einfach: 1-100";
            }
            else if (Properties.Settings.Default.Language == "English")
            {
               btnEasy.Text = "Easy: 1-100";
            }
            else if (Properties.Settings.Default.Language == "français")
            {
                btnEasy.Text = "Simplement: 1-100";
            }
        }
        public void Middlebtn()
        {
            if (Properties.Settings.Default.Language == "Deutsch")
            {
                btnMiddle.Text = "Mittel: 1-1000";
            }
            else if (Properties.Settings.Default.Language == "English")
            {
                btnMiddle.Text = "Medium: 1-1000";
            }
            else if (Properties.Settings.Default.Language == "français")
            {
                btnMiddle.Text = "Milieu: 1-1000";
            }
        }
        public void Hardbtn()
        {
            if (Properties.Settings.Default.Language == "Deutsch")
            {
                btnHard.Text = "Schwer: 1-10000";
            }
            else if (Properties.Settings.Default.Language == "English")
            {
                btnHard.Text = "Hard: 1-10000";
            }
            else if (Properties.Settings.Default.Language == "français")
            {
                btnHard.Text = "Difficile: 1-10000";
            }
        }
        public void ReallyHardbtn()
        {
            if (Properties.Settings.Default.Language == "Deutsch")
            {
                btnReallyHard.Text = "Sehr Schwer: 1-100000";
            }
            else if (Properties.Settings.Default.Language == "English")
            {
                btnReallyHard.Text = "Really Hard: 1-100000";
            }
            else if (Properties.Settings.Default.Language == "français")
            {
                btnReallyHard.Text = "Très difficile: 1-100000";
            }
        }
    }
}
