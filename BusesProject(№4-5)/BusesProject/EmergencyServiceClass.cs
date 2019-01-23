using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;

namespace BusesProject
{
    public class EmergencyService
    {

        public delegate void Action(int busid);
        public event Action BusIsRepaired;
        private List<TransportInfo> Buses;
        private Point ServiscePos;
        private object locker = new object();
        public int LeftWorldBound { get; private set; }
        public void Start()
        {
            while (true)
                this.Repair();
        }
        public Point GetLocation()
        {
            return ServiscePos;
        }

        private void Repair()
        {
            if (Buses.Count() != 0)
            {
                lock (locker)
                {
                    ServiscePos.Y = Buses[0].BusPos.Y;
                    while (Buses[0].BusPos.X + 50 < ServiscePos.X)
                    {
                        Thread.Sleep(5);
                        ServiscePos.X -= 3;
                    }
                    Thread.Sleep(500);
                    BusIsRepaired(Buses[0].TransportId);
                    Buses.RemoveAt(0);
                    while (ServiscePos.X - 50 < LeftWorldBound)
                    {
                        ServiscePos.X += 3;
                        Thread.Sleep(5);
                    }
                }
            }
        }
        public EmergencyService(Point loc, int width)
        {
            ServiscePos = loc;
            Buses = new List<TransportInfo>(10);
            WorldBoundChanged(width);
        }
        public void Register(BreakableTransport obj)
        {
            Buses.Add(obj.TransporStatus);
        }
        public void WorldBoundChanged(int leftbound)
        {
            LeftWorldBound = leftbound;
        }
    }
}
