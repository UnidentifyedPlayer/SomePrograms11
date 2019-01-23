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
        public int PlanetCount
        {
            get { return planets.Count; }
        }
        public StarSystem(string[] systemInfo)
        {
            name = systemInfo[0];
            star = new Star(systemInfo[1]);
            List<Planet> planets = new List<Planet>(1);
        }
        public string PlanetNum()
        {
            if (planets == null)
                return "Нет планет в системе";
            else
            return Convert.ToString(planets.Count);
        }
        public string StarName()
        {
            return star.Name;
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
