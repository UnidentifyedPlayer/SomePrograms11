using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone1
{
    public class MobilePhone
    {
        private string Brand;
        private float Price;
        private float Memory;
        public MobilePhone(string brandinput, float priceinput, float memoryinput)
        {
            Brand = brandinput;
            Price = priceinput;
            Memory = memoryinput;
        }
        public string PhoneBrand
        {
            get { return Brand; }
        }
        public float PhonePrice
        {
            get { return Price; }
        }
        public float PhoneMemory
        {
            get { return Memory; }
        }
        public virtual float Evaluate()
        {
            return Memory / Price;
        }
        //public string DisplayInfo()
        //{
          //  return "Breand of the phone - " + brand + "\n Phone's price - " + Convert.ToString(price) + "\n Memory size - " + Convert.ToString(memory);
        //}
    }
}
