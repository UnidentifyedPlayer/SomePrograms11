using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobilePhone1;
using MobilePhone2;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

         public static List<MobilePhone> firstLVList = new List<MobilePhone>(0);
        public static List<MobilePhoneL2> secondLVList = new List<MobilePhoneL2>(0);
        private void button1_Click(object sender, EventArgs e)
        {
            string brand = brandInput.Text;
            float pr;
            float me;
            if (!float.TryParse(memoryInput.Text, out me)||!(float.TryParse(priceInput.Text, out pr)))
            {
                MessageBox.Show("Using inapropriate simbols in inputting the amount of memory and\n the price is a big no-no in this program. Try agaain!");
            }
            else
            {
                MobilePhone a = new MobilePhone(brand, pr, me);
                lvl1PhonesGrid.Rows.Add(a.brand, a.price, a.memory, a.Evaluate());
                lvl1phonesID.Items.Add(lvl1PhonesGrid.RowCount-1);
                firstLVList.Add(a);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int p;
            if (!Int32.TryParse(numberOfSimsInput.Text, out p))
            {
                MessageBox.Show("Using inapropriate simbols in inputting the number of SIM's \n  is a big no-no in this program. Try agaain!");
            }
            else
            {
                int t = lvl1phonesID.SelectedIndex;
                MobilePhoneL2 a = new MobilePhoneL2(firstLVList[t].brand, firstLVList[t].price, firstLVList[t].memory, p);
                lvl2PhonesGrid.Rows.Add(a.brand, a.price, a.memory, a.simNumber, a.Evaluate());
                secondLVList.Add(a);
            }
        }
    }
}
