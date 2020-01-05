using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ND_WindowsForms_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbInput.Text == "")
            {
                MessageBox.Show("Langeliai turi buti uzpildyti");
                return;
            }

            try
            {
                int skaicius = (int.Parse(tbInput.Text));
                if(skaicius % 2 != 0)
                {
                    lblSkaicius.Text = "Skaicius nelyginis";
                }
                else
                {
                    lblSkaicius.Text = "Skaicius Lyginis";
                }
            }
            catch

            {
                MessageBox.Show("Ivesti neteisingi duomenys");
            }
        }
    }
}
