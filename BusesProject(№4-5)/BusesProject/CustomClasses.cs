using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;

namespace BusesProject
{
    public interface BreakableTransport
    {
        bool CrossbarSlipped { get; set; } 
        bool IsBroken { get; set; }
        TransportInfo TransporStatus { get; set; }
    }
    public struct TransportInfo
    {
        public int BusId { get; private set; }
        public Point BusPos { get; private set; }
        public TransportInfo(int i, Point pos)
        {
            BusId = i;
            BusPos = pos;
        }
    }
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
                    IsBroken = true;
                    RepairBus(this);
                }
                if (rnd.Next(0, 100) == 1)
                {
                    CrossbarSlipped = true;
                    //PutCrossbarBack(this);
                    Thread.Sleep(400);
                    CrossbarSlipped = false;
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

        public Bus(Point location,int i)
        {
            WheelsRotation = 0;
            CrossbarSlipped = false;
            IsBroken = false;
            TransporStatus = new TransportInfo(i , location);
        }
    }
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
            while(true)
            this.DriversBus.Move();
        }
        public void Repair(BreakableTransport bus)
        {
            bus.IsBroken = false;
        }
 
        }
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
            if (Buses.Count()!=0)
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
                    BusIsRepaired(Buses[0].BusId);
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
    public class World
    {
        private bool IsWorldAlive; 
        public delegate void Change(int number);
        public event Change SizeChange;
        private List<BusDriver> Buses;
        EmergencyService MainBrigade;
        Size WorldBoundary;
        public void BrigadeCompletedRepair(int id)
        {
            Buses[id].DriversBus.IsRepaired();
        }
        public World(Size newBoundary)
        {
            WorldBoundary = newBoundary;
            MainBrigade = new EmergencyService(new Point(WorldBoundary.Width + 50, 50), WorldBoundary.Width);
            Buses = new List<BusDriver>(10);
            MainBrigade.BusIsRepaired += BrigadeCompletedRepair;
            this.SizeChange += MainBrigade.WorldBoundChanged;
            IsWorldAlive = false;
        }
        public void SizeChanged(Size size)
        {
            WorldBoundary = size;
            SizeChange(size.Width);
        }
        public void BeginTheWorld()
        {
            Thread mainbrigadethread = new Thread(MainBrigade.Start);
            mainbrigadethread.Start();
            foreach(BusDriver bus in Buses)
            {
                Thread thisbusthread = new Thread(bus.Begin);
                thisbusthread.Start();
            }
        }
        public string AddBus(Point location)
        {
            Bus newbus = new Bus(location, Buses.Count);
            newbus.RepairBus += MainBrigade.Register;
            BusDriver newbusdriver = new BusDriver(newbus);
            Buses.Add(newbusdriver);
            if (IsWorldAlive)
            {
                Thread thisbusthread = new Thread(Buses[Buses.Count].Begin);
                thisbusthread.Start();
            }
            return "Bus №" + (Buses.Count-1).ToString()+ " has been added\n";
        }
        public void DrawWorld(Graphics graphic)
        {
            graphic.Clear(Color.White);
            foreach (BusDriver bus in Buses)
            {
                Drawer.DrawBus(ref graphic, bus.DriversBus.TransporStatus, bus.DriversBus.WheelsRotation);
            }
            Drawer.DrawEmergencyService(ref graphic, MainBrigade.GetLocation());
        }
    }
    public class Drawer
    {

        public static void DrawBus(ref Graphics graphic,TransportInfo businfo, float rotation)
        {
            graphic.DrawRectangle(Pens.Black, businfo.BusPos.X - 50, businfo.BusPos.Y - 20, 100, 40);
            Drawer.DrawWheel(ref graphic, rotation, new Point(businfo.BusPos.X -30, businfo.BusPos.Y+30));
            Drawer.DrawWheel(ref graphic, rotation, new Point(businfo.BusPos.X + 30, businfo.BusPos.Y+30));
        }
         public static void DrawWheel(ref Graphics graphic,float rotation, Point ocation)
        {
            float k =rotation/180;
            float cos = (float)Math.Cos(k)*10;
            float sin = (float)Math.Sin(k)*10;
            Color col = Color.FromArgb(255, 90 + 150 * (int)(rotation / 360f), 90 + 150 * (int)(rotation / 360f), 200);
            Pen pen = new Pen(col);
            graphic.DrawEllipse(pen,ocation.X - 10, ocation.Y - 10, 20, 20);
            graphic.DrawLine(pen, ocation.X + cos, ocation.Y + sin, ocation.X - cos, ocation.Y - sin);
        }
        public static void DrawEmergencyService(ref Graphics graphic, Point location)
        {
            graphic.DrawEllipse(Pens.Black, location.X - 30, location.Y - 30, 60, 60);
        } 
    }
  
    
    

}
