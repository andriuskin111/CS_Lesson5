using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ND_WindowsForms_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double tempC;
        double tempK;
        double tempF;
        double tempR;
        private void button1_Click(object sender, EventArgs e)
        {
            if(!double.TryParse(tbInput.Text, out tempC))
            {
                MessageBox.Show("Ivesti neteisingi duomenys");
                return;
            }

            tempC = double.Parse(tbInput.Text);
            tempK = tempC + 273.16;
            tempF = tempC * 9 / 5 + 32;
            tempR = tempC * 0.8;

            tbOutput.Clear();
            tbOutput.AppendText($"TEMPERATURA\r\n");
            tbOutput.AppendText($"Celsijais: {tempC}\r\n");
            tbOutput.AppendText($"Kelvinais: {tempK}\r\n");
            tbOutput.AppendText($"Fahrenheitais: {tempF}\r\n");
            tbOutput.AppendText($"Reomiurais: {tempR}\r\n");
        }
    }
}
