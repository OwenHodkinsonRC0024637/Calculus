using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Calculus

{
    public partial class Form1 : Form
    {
        class row
        {
            public double time;
            public double voltage;
            public double current;
            public double voltageDerivative;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openToolStripMenuItem(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "CSV Files|*.csv";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                    {
                        string line = sr.ReadLine();
                        while (!sr.EndOfStream)
                        {
                            table.Add(new data());
                            string[] l = sr.ReadLine().Split(',');
                            table.last().time = double.Parse(l[0]);
                            table.Last().voltage = double.Parse(l[1]);
                            table.last().current = double.Parse(l[2]);
                            table.last().VoltageDerivative = double.Parse(l[3]);
                        }
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show(openFileDialog1.FileName + " failed to open.");
                }
                catch (FormatException)
                {
                    MessageBox.Show(openFileDialog1.FileName + " is not in the required format.");
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show(openFileDialog1.FileName + " is not in the required format");
                }
            }
        }
    }
}


private void sAveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

