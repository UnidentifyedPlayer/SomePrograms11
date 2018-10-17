using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibrary1;

namespace TheWFormOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StarSystem A;
        int fl = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(A.PlanetNum());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            textBox2.Visible = true;
            button4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(A.StarName());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (fl == 0)
            {
                if ((textBox2.Text != null) && (textBox1.Text != null))
                {
                    string[] a = new string[] { textBox1.Text, textBox2.Text };
                    A = new StarSystem(a);
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                    label1.Visible = false;
                    label2.Visible = false;
                    textBox2.Visible = false;
                    textBox1.Visible = false;
                    button4.Visible = false;
                    textBox2.Clear();
                    textBox1.Clear();
                    fl = 1;
                }
                else
                {
                    MessageBox.Show("Enter both System's and Star's name");
                }
            }
            else
            {
                MessageBox.Show(A.AddPlanet(textBox2.Text));
                button4.Visible = false;
                textBox2.Visible = false;
                label3.Visible = false;
                textBox2.Clear();
                textBox1.Clear();
            }
        }
    }
}
