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
    public partial class Help : Form
    {
        Form1 f1;
        public Help(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }
    }
}
