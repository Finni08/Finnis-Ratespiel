using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grundkurs2
{
    public partial class Help : Form
    {
        Form1 f1;
        public Help(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
            helptext();
        }
        public void helptext()
        {
           if (Properties.Settings.Default.Language == "Deutsch")
            {
                tbhelp.Text = "Dies ist das Offizielle Ratespiel von Finni\r\n\r\n\r\nUnterstützer Seeloewen aka Louis9\r\n\r\nSchaut gerne bei ihm vorbei den er hat mich erst zu zum programmieren gebracht";
            }
           else if (Properties.Settings.Default.Language == "English")
            {
                tbhelp.Text = "This is Finni's Official Guessing Game\r\n\r\nSupporters Seeloewen aka Louis9\r\n\r\nFeel free to visit him, because he first brought me to programming";
            }
           else if (Properties.Settings.Default.Language == "français")
            {
                tbhelp.Text = "C’est le jeu de devinettes officiel de Finni\r\n\r\nSupporters Seelöewen alias Louis9\r\n\r\nN’hésitez pas à lui rendre visite, car c’est lui qui m’a initié à la programmation\r\n";
            }
        }
    }
}
