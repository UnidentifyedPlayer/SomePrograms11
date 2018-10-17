using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public  class MobilePhone
    {
        public string Brand;
        public float Price;
        public float Memory;
        public MobilePhone(string x, float price, float m)
        {
            Brand = x;
            Price = price;
            Memory = m;
        }
        public float Q
        {
            get { return ( Memory / Price); }
        }
        public string DisplayInfo()
        {
            string pr = Convert.ToString(Price);
            string me = Convert.ToString(Memory);
            return "Breand of the phone - " + Brand + "\n Phone's price - " + pr + "\n Memory size - " + me;
        }
    }
    public  class MobilePhoneL2 : MobilePhone
    {
        public float P;
        public MobilePhoneL2(string x, float price, float m, float p) :base(x, price, m)
        {
            this.P = p;
        }
        public float Qp
        {
            get { return (P * Q); }
        }
    }
}
