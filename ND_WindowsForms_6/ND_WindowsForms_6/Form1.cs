using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ND_WindowsForms_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double ugis;
        double svoris;
        double kmi;
        private void btnSkaiciuoti_Click(object sender, EventArgs e)
        {
            if(tbUgis.Text == "" || tbSvoris.Text == "")
            {
                MessageBox.Show("Langeliai turi buti uzpildyti");
                return;
            }

            if(!double.TryParse(tbUgis.Text, out ugis) || !double.TryParse(tbSvoris.Text, out svoris))
            {
                MessageBox.Show("Ivesti neteisingi duomenys");
                return;
            }

            ugis = double.Parse(tbUgis.Text);
            svoris = double.Parse(tbSvoris.Text);
            kmi = svoris / (ugis * ugis);

            tbOutput.Clear();
            tbOutput.Text = ($"{kmi}");
        }
    }
}
