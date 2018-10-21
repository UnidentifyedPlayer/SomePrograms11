using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone1
{
    public  class MobilePhone
    {
        public string brand;
        public float price;
        public float memory;
        public MobilePhone(string brandinput, float priceinput, float memoryinput)
        {
            brand = brandinput;
            price = priceinput;
            memory = memoryinput;
        }
        public virtual float Evaluate()
        {
            return memory / price;
        }
        //public string DisplayInfo()
        //{
          //  return "Breand of the phone - " + brand + "\n Phone's price - " + Convert.ToString(price) + "\n Memory size - " + Convert.ToString(memory);
        //}
    }
}
