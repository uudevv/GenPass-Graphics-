using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenPass_Graphics_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len_of_pass = (int)numericUpDown1.Value;
            bool symbols = checkBox1.Checked;
            Random random = new Random();

            for (int i = 0; i < len_of_pass; i++)
            {
                int value = random.Next(0,9);
                richTextBox1.Text += value.ToString();
                if (symbols == true)
                {
                    char walue = (char)random.Next(33, 125);
                    richTextBox1.Text += walue.ToString();
                }
            }
            richTextBox1.Text += "\n";

        }   


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
