using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    class Star
    {
        private string name;
        public string Name
        {
            get { return name; }
        }
        public Star(string starname)
        {
            name = starname;
        }
    }
}
