using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol_OOP2
{
    public partial class Form1 : Form
    {
        NakladniAuto konstruktor;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                konstruktor = new NakladniAuto(textBox1.Text, Int32.Parse(textBox2.Text));
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Zadej hodnoty podle zadání!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                konstruktor.NalozNaklad(int.Parse(textBox3.Text));

            }
            catch
            {
                MessageBox.Show("Zadej hodnoty podle zadání!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                konstruktor.VylozNaklad(int.Parse(textBox3.Text));
            }
            catch
            {
                MessageBox.Show("Zadej hodnoty podle zadání!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(konstruktor.ToString());
        }
    }
}
