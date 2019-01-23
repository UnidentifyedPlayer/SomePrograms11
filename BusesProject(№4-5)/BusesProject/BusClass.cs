using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;

namespace BusesProject
{
    public class Bus : BreakableTransport
    {
        public delegate void Action(BreakableTransport obj);
        //public event Action PutCrossbarBack;
        public event Action RepairBus;
        public TransportInfo TransporStatus { get; set; }
        public bool CrossbarSlipped { get; set; }
        public bool IsBroken { get; set; }
        public int WheelsRotation { get; set; }
        public void Move()
        {
            if (!CrossbarSlipped && !IsBroken)
            {
                Random rnd = new Random();
                WheelsRotation += 12;
                if (WheelsRotation == 360)
                    WheelsRotation = 0;
                if ((rnd.Next(0, 100) == 1))
                {
                    this.IsBroken = true;
                    RepairBus(this);
                }
                if (rnd.Next(0, 100) == 1)
                {
                    this.CrossbarSlipped = true;
                    //PutCrossbarBack(this);
                    Thread.Sleep(400);
                    this.CrossbarSlipped = false;
                }
                Thread.Sleep(50);
            }
        }
        public void IsRepaired()
        {
            IsBroken = false;
        }

        public void WheelRolling()
        {
            throw new NotImplementedException();
        }

        public Bus(Point location, int i)
        {
            WheelsRotation = 0;
            CrossbarSlipped = false;
            IsBroken = false;
            TransporStatus = new TransportInfo(i, location);
        }
    }
}
