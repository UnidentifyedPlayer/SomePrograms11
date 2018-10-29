using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone1;

namespace MobilePhone2
{
    public class MobilePhoneL2 : MobilePhone
    {
        private int simNumber;
        public MobilePhoneL2(string x, float price, float m, int p) : base(x, price, m)
        {
            this.simNumber = p;
        }
        public int NumberOfSims
            {
            get { return simNumber; }
            }
        public override float Evaluate()
        {
            return simNumber * base.Evaluate();
        }
    }
}
