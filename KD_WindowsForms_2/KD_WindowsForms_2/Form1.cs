using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KD_WindowsForms_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<double> ugisArray = new List<double>();
        List<double> svorisArray = new List<double>();

        private void btnAddToArray_Click(object sender, EventArgs e)
        {
            if(tbUgis.Text == "" || tbSvoris.Text == "")
            {
                MessageBox.Show("Langeliai turi buti uzpildyti");
                return;
            }
            try
            {
                ugisArray.Add(double.Parse(tbUgis.Text));
                svorisArray.Add(double.Parse(tbSvoris.Text));
            }
            catch
            {
                MessageBox.Show("Ivesti neteisingi duomenys");
            }
            
            tbUgis.Text = "";
            tbSvoris.Text = "";
        }

        private void btnShowArray_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ugisArray.Count; i++)
            {
                tbOutput.AppendText($"Ugis: {ugisArray.ElementAt(ugisArray.Count - 1)}" +
                    $"  Svoris: {svorisArray.ElementAt(ugisArray.Count - 1)}\r\n");
            }
        }
    }
}
