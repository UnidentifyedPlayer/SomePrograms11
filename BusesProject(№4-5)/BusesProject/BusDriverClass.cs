using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusesProject
{
    public class BusDriver
    {
        public Bus DriversBus;
        public BusDriver(Bus newbus)
        {
            DriversBus = newbus;
            //DriversBus.PutCrossbarBack += Repair;
        }
        public void Begin()
        {
            while (true)
                this.DriversBus.Move();
        }
        public void Repair(BreakableTransport bus)
        {
            bus.IsBroken = false;
        }

    }
}
