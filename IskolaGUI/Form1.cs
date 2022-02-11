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

namespace IskolaGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var sor in File.ReadAllLines("nevek.txt"))
            {
                listBox1.Items.Add(sor);
            }
        }

        private void btnTörlés_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Nem jelölt ki tanulót!" , "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }

        }

        private void btnMentés_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter("c:\\valami\\nevekNEW.txt");

                foreach (var sor in listBox1.Items)
                {
                    streamWriter.WriteLine(sor);

                }
                streamWriter.Close();
                MessageBox.Show("Sikeres mentés!");
            }
            catch (Exception hiba)
            {
                MessageBox.Show(hiba.Message);
            }










            StreamWriter sw = new StreamWriter("nevekNEW.txt");

            foreach (var sor in listBox1.Items)
            {
                sw.WriteLine(sor);
               
            }
            sw.Close();
            MessageBox.Show("Sikeres mentés!");
        }
    }
}
