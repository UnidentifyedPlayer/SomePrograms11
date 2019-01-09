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
    public partial class PhoneDataForm : Form
    {
        public PhoneDataForm()
        {
            InitializeComponent();
            
        }

         public static List<MobilePhone> firstLVList = new List<MobilePhone>(0);
        public static List<MobilePhoneL2> secondLVList = new List<MobilePhoneL2>(0);
        private void AddLvl1phone_Click(object sender, EventArgs e)
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
                lvl1PhonesGrid.Rows.Add(a.PhoneBrand, a.PhonePrice, a.PhoneMemory, a.Evaluate());
                lvl1phonesID.Items.Add(lvl1PhonesGrid.RowCount-1);
                firstLVList.Add(a);
                lvl1phonesID.SelectedIndex = 0;
            }
        }

        private void AddLvl2phone_Click(object sender, EventArgs e)
        {
            int p;
            if (!Int32.TryParse(numberOfSimsInput.Text, out p))
            {
                MessageBox.Show("Using inapropriate simbols in inputting the number of SIM's \n  is a big no-no in this program. Try agaain!");
            }
            else
            {
                int t = lvl1phonesID.SelectedIndex;
                MobilePhoneL2 a = new MobilePhoneL2(firstLVList[t].PhoneBrand, firstLVList[t].PhonePrice, firstLVList[t].PhoneMemory, p);
                lvl2PhonesGrid.Rows.Add(a.PhoneBrand, a.PhonePrice, a.PhoneMemory, a.NumberOfSims, a.Evaluate());
                secondLVList.Add(a);
            }
        }
    }
}
