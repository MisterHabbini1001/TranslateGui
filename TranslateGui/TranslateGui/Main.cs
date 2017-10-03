using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranslateGui
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Translate_Click(object sender, EventArgs e) // Microsoft Translate button
        {
            if (textBox1.Text == "" && comboBox1.Text == "")
            {
                MessageBox.Show("Text to be translated and language to be translated to are empty.");
            }

            else if (textBox1.Text == "")
            {
                MessageBox.Show("Text to be translated to is empty.");
            }

            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Language to be translated to is empty.");
            }
            
            else
            { 
                string translate_result = TranslateMS.Main.fetch(textBox1.Text, comboBox1.Text);
                textBox2.Text = translate_result;
            }           
        }
    }
}
