using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class StarSystem
    {
        private List<Planet> planets;
        private Star Star;
        private string Name;
        public StarSystem(string[] sta)
        {
            Name = sta[0];
            Star = new Star(sta[1]);
            List<Planet> planets = new List<Planet>(1);
        }
        public string PlanetNum()
        {
            string y = "There are " + Convert.ToString(planets.Count) + " planets in this system!";
            return y;
        }
        public string StarName()
        {
            return "Name of this system's star is " + Star.Name;
        }
        public string AddPlanet(string planet)
        {
            if (planets == null)
                planets = new List<Planet> { new Planet(planet) };
            else
            planets.Add(new Planet(planet));
            return "Planet " + planet + " has been added to your star system!";
        }
    }
}
