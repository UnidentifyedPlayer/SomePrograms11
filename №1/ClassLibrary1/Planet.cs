using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Planet
    {
        private List<Moon> moons;
        public string Name;
        public Planet(string name)
        {
            Name = name;
        }
        public void AddMoon(string[] newmoon) 
        {
            for (int i = 0; i < newmoon.GetLength(0); i++)
            {
                Moon a = new Moon(newmoon[i]);
                moons.Add(a);
            }
        }
    }
}
