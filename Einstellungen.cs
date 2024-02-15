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
            Properties.Settings.Default.Difficulty = "Middel: 1-1000";
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
                f1.header();
                f1.VersucheReset();
                f1.Winsreset();
                f1.Vorherigeeingaben();
                f1.btnSettings.Text = "Einstellungen";
                f1.Resetbtn2();
                f1.btnHelp.Text = "Hilfe";
            }
            else if (cbxLanguage.Text == "English")
            {
                Properties.Settings.Default.Language = "English";
                f1.header();
                f1.VersucheReset();
                f1.Winsreset();
                f1.Vorherigeeingaben();
                f1.btnSettings.Text = "Settings";
                f1.Resetbtn2();
                f1.btnHelp.Text = "Help";
            }
            else
            {
                Properties.Settings.Default.Language = "français";
                f1.header();
                f1.VersucheReset();
                f1.Winsreset();
                f1.Vorherigeeingaben();
                f1.btnSettings.Text = "paramètres";
                f1.Resetbtn2();
                f1.btnHelp.Text = "Aide";
            }
            Properties.Settings.Default.Save();
            f1.header();
        }
    }
}
