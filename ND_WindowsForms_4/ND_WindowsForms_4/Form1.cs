using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ND_WindowsForms_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> pazymiaiPirmas = new List<int>();
        List<int> pazymiaiAntras = new List<int>();
        List<int> pazymiaiTrecias = new List<int>();
        int pazymys;
        double vidurkis = 0;

        
        private void btnIvestiPazymi1_Click(object sender, EventArgs e)
        {
            if (tbPazimys1.Text == "")
            {
                MessageBox.Show("Langelis turi buti uzpildytas");
                return;
            }

            try
            {
                if (!int.TryParse((tbPazimys1.Text), out pazymys))
                {
                    MessageBox.Show("Ivesti neteisingi duomenys");
                    tbPazimys1.Text = "";
                    return;
                }
                else if (int.TryParse(tbPazimys1.Text, out pazymys))
                {
                    if (pazymys < 0 || pazymys > 10)
                    {
                        MessageBox.Show("Ivesti neteisingi duomenys");
                        tbPazimys1.Text = "";
                        return;
                    }

                    pazymiaiPirmas.Add(pazymys);

                    if(pazymiaiPirmas.Count > 0)
                    {
                        label1.ForeColor = Color.Green;
                    }
                }

                tbPazimys1.Text = "";
            }
            catch
            {
                MessageBox.Show("Error");
                return;
            }
        }

        private void btnIvestiPazymi2_Click(object sender, EventArgs e)
        {
            if (tbPazimys2.Text == "")
            {
                MessageBox.Show("Langelis turi buti uzpildytas");
                return;
            }

            try
            {
                if (!int.TryParse((tbPazimys2.Text), out pazymys))
                {
                    MessageBox.Show("Ivesti neteisingi duomenys");
                    tbPazimys2.Text = "";
                    return;
                }
                else if (int.TryParse(tbPazimys2.Text, out pazymys))
                {
                    if (pazymys < 0 || pazymys > 10)
                    {
                        MessageBox.Show("Ivesti neteisingi duomenys");
                        tbPazimys2.Text = "";
                        return;
                    }

                    pazymiaiAntras.Add(pazymys);

                    if (pazymiaiPirmas.Count > 0)
                    {
                        label2.ForeColor = Color.Green;
                    }
                }

                tbPazimys2.Text = "";
            }
            catch
            {
                MessageBox.Show("Error");
                return;
            }
        }

        private void btnIvestiPazymi3_Click(object sender, EventArgs e)
        {
            if (tbPazimys3.Text == "")
            {
                MessageBox.Show("Langelis turi buti uzpildytas");
                return;
            }

            try
            {
                if (!int.TryParse((tbPazimys3.Text), out pazymys))
                {
                    MessageBox.Show("Ivesti neteisingi duomenys");
                    tbPazimys2.Text = "";
                    return;
                }
                else if (int.TryParse(tbPazimys3.Text, out pazymys))
                {
                    if (pazymys < 0 || pazymys > 10)
                    {
                        MessageBox.Show("Ivesti neteisingi duomenys");
                        tbPazimys3.Text = "";
                        return;
                    }

                    pazymiaiTrecias.Add(pazymys);
                    if (pazymiaiPirmas.Count > 0)
                    {
                        label3.ForeColor = Color.Green;
                    }
                }

                tbPazimys3.Text = "";
            }
            catch
            {
                MessageBox.Show("Error");
                return;
            }
        }

        private void btnParodyti_Click(object sender, EventArgs e)
        {
            tbOutput.Clear();

            if (pazymiaiPirmas.Count == 0 || pazymiaiAntras.Count == 0 || pazymiaiTrecias.Count == 0)
            {
                MessageBox.Show("Uzpidykite pazymiais visus semestrus");
                return;
            }

            tbOutput.AppendText("Pirmo semestro pazymiai:\r\n");

            foreach (var item in pazymiaiPirmas)
            {
                tbOutput.AppendText($" {item}");
            }

            tbOutput.AppendText("\r\n");
            vidurkis = pazymiaiPirmas.Average();
            tbOutput.AppendText($"Pirmo semestro vidurkis: {vidurkis}\r\n");

            tbOutput.AppendText("Antro semestro pazymiai:\r\n");

            foreach (var item in pazymiaiAntras)
            {
                tbOutput.AppendText($" {item}");
            }

            tbOutput.AppendText("\r\n");
            vidurkis = pazymiaiAntras.Average();
            tbOutput.AppendText($"Antro semestro vidurkis: {vidurkis}\r\n");

            tbOutput.AppendText("Trecio semestro pazymiai:\r\n");

            foreach (var item in pazymiaiTrecias)
            {
                tbOutput.AppendText($" {item}");
            }

            tbOutput.AppendText("\r\n");
            vidurkis = pazymiaiTrecias.Average();
            tbOutput.AppendText($"Trecio semestro vidurkis: {vidurkis}\r\n");
        }

    }

}
