using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheRealSeaShipClass;
using ISeaShipable;
namespace OnWorkWithShipList
{
    class Program
    {

        private static void MainMenu()
        {
            List<IShipable> ships = new List<IShipable>(1);
            bool mainmenulooped = false;
            while (!mainmenulooped)
            {
                Console.WriteLine("Input number of action:\n 1: Add Ship. \n 2: Work with one ship \n 3: Delete Ship \n  4: Exit");
                int number = WasNumberInputted(Console.ReadLine(), ref mainmenulooped);
                if (mainmenulooped)
                {
                    switch (number)
                    {
                        case 1:
                            AircraftCarrier ship = new AircraftCarrier();
                            NewShip(ref ship);
                            ships.Add(ship);
                            break;
                        case 2:
                            Console.WriteLine("Choose a ship to work with");
                            DisplayAllShips(ref ships);
                            bool success = true;
                            int shipindex = WasNumberInputted(Console.ReadLine(), ref success);
                            if (success)
                            {
                                WorkWithShip(ships[shipindex-1]);
                            }
                            break;
                        case 3:
                            bool successed = true;
                                Console.WriteLine("input index of a ship to delete");
                                int deleteidx = WasNumberInputted(Console.ReadLine(), ref successed);
                                if (successed)
                                    ships.RemoveAt(deleteidx);
                                else
                                    Console.WriteLine("incorrect index input, try again.");
                            break;
                        case 4:
                            mainmenulooped = true;
                            break;
                        default:Console.WriteLine("Wrong number input");
                            break;
                    }
                    mainmenulooped = false;
                }
            } 
        }
        private static void DisplayAllShips(ref List<IShipable> ships)
        {
            for(int i = 0; i < ships.Count; i++)
            {
                Console.WriteLine((i + 1).ToString() + " - " + ships[i].ModelName.ToString());
            }
        }
        private static void WorkWithShip( IShipable ship)
        {
            bool shipmenulooped = true;
            while (shipmenulooped)
            {
                Console.WriteLine("Choose action: \n 1 - Add cannon \n 2 - Start moving \n 3 - Stop moving \n 4 - Fire cannons \n 5 - Exit");
                int number = WasNumberInputted(Console.ReadLine(), ref shipmenulooped);
                if (!shipmenulooped ||(number>5)||(number<1))
                {
                    shipmenulooped = true;
                    Console.WriteLine("Incorrect input for action number");
                }
                else
                    switch (number)
                    {
                        case 1: ship.Act(2);
                            break;
                        case 2: ship.Move();
                            break;
                        case 3: ship.Stop();
                            break;
                        case 4: ship.Act(1);
                            break;
                        case 5:
                            shipmenulooped = false;
                            break;
                    }
            }
        }
        private static void NewShip(ref AircraftCarrier ship)
        {
            Console.WriteLine("Enter new ship's name");
            string name = Console.ReadLine();
            bool anothreloop = false;
            while (!anothreloop)
            {
                Console.WriteLine("Enter ship's maximum cannon capacity");
                int capacity = WasNumberInputted(Console.ReadLine(), ref anothreloop);
                if (anothreloop)
                {
                     ship = new AircraftCarrier(name, capacity);
                    Console.WriteLine("Ship " + ship.ModelName.ToString() + " has been added.");
                }
                else
                {
                    Console.WriteLine("Incorrect input for cannon capacity, try again");
                }
            }

        }
        private static int WasNumberInputted(string str, ref bool successresult)
        {
            int number = 0;
            successresult = Int32.TryParse(str, out number);
            return number;
        }
        static void Main(string[] args)
        {
            MainMenu();
        }
    }
}
