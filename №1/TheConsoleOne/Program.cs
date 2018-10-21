using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary1;

namespace TheConsoleOne
{
    class Program
    {
        static string ReadData(string a)
        {
            Console.WriteLine(a);
            string t = Console.ReadLine();
            return t;
        }
        static string[] Create()
        {
            string[] names =  new string[2];
            names[0] = ReadData("Name of a new system");
            names[1] = ReadData("Name of the star of the system");
            return names;
        }
        static void Main(string[] args)
        {
            StarSystem A = new StarSystem(Create());
            int count;
            do
            {
                Console.WriteLine("Press 1 to show star's name, 2 - to add planet,/n 3 - to show the number of planets in the system, 0 - to exit");
                if (!int.TryParse(Console.ReadLine(), out count))
                    count = -1;
                switch (count)
                {
                    case 1:
                        Console.WriteLine(A.StarName());
                        break;
                    case 2:
                        Console.WriteLine("New planet's name: ");
                        A.AddPlanet(Console.ReadLine()) ;
                        break;
                    case 3:
                        Console.WriteLine(A.PlanetNum());
                        break;
                }
            }
            while (count != 0);
        }
    }
}

