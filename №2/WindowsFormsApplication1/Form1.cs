using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary2;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

         public static List<MobilePhone> A = new List<MobilePhone>(0);
        public static List<MobilePhoneL2> Al2 = new List<MobilePhoneL2>(0);
        private void button1_Click(object sender, EventArgs e)
        {
            string Brand = textBox1.Text;
            float pr;
            float me;
            if (!float.TryParse(textBox3.Text, out me)||!(float.TryParse(textBox2.Text, out pr)))
            {
                MessageBox.Show("Using inapropriate simbols in inputting the amount of memory and\n the price is a big no-no in this program. Try agaain!");
            }
            else
            {
                MobilePhone a = new MobilePhone(Brand, pr, me);
                dataGridView1.Rows.Add(a.Brand, a.Price, a.Memory, a.Q);
                MessageBox.Show(a.DisplayInfo());
                comboBox1.Items.Add(Brand);
                A.Add(a);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float P;
            if (!float.TryParse(textBox4.Text, out P))
            {
                MessageBox.Show("Using inapropriate simbols in inputting the P \n  is a big no-no in this program. Try agaain!");
            }
            else
            {
                int t = comboBox1.SelectedIndex;
                MobilePhoneL2 a = new MobilePhoneL2(A[t].Brand, A[t].Price, A[t].Memory, P);
                dataGridView2.Rows.Add(a.Brand, a.Price, a.Memory, a.Qp);
                Al2.Add(a);
            }
        }
    }
}
