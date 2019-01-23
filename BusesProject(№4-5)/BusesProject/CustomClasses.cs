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
        public int TransportId { get; private set; }
        public Point BusPos { get; private set; }
        public TransportInfo(int i, Point pos)
        {
            TransportId = i;
            BusPos = pos;
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
                Drawer.DrawBus(ref graphic, bus.DriversBus.TransporStatus, bus.DriversBus.WheelsRotation, bus.DriversBus.CrossbarSlipped);
            }
            Drawer.DrawEmergencyService(ref graphic, MainBrigade.GetLocation());
        }
    }
    public class Drawer
    {

        public static void DrawBus(ref Graphics graphic,TransportInfo businfo, float rotation, bool IsCrossbarSlipped)
        {
            graphic.DrawRectangle(Pens.Black, businfo.BusPos.X - 50, businfo.BusPos.Y - 20, 100, 40);
            Drawer.DrawWheel(ref graphic, rotation, new Point(businfo.BusPos.X -30, businfo.BusPos.Y+30));
            if(IsCrossbarSlipped)
            Drawer.DrawWheel(ref graphic, rotation, new Point(businfo.BusPos.X + 30, businfo.BusPos.Y+15));
            else
                Drawer.DrawWheel(ref graphic, rotation, new Point(businfo.BusPos.X + 30, businfo.BusPos.Y + 30));
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
