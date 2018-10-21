using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class StarSystem
    {
        private List<Planet> planets;
        private Star star;
        private string name;
        public StarSystem(string[] sta)
        {
            name = sta[0];
            star = new Star(sta[1]);
            List<Planet> planets = new List<Planet>(1);
        }
        public string PlanetNum()
        {
            return Convert.ToString(planets.Count);
        }
        public string StarName()
        {
            return star.name;
        }
        public void AddPlanet(string planet)
        {
            if (planets == null)
                planets = new List<Planet> { new Planet(planet) };
            else
            planets.Add(new Planet(planet));
        }
    }
}
