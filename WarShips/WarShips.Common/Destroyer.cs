using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WarShips.Common
{
    internal class Destroyer : Ship
    {
        public int NumberOfTorpedos { get; set; }
        public Boolean Mines { get; set; }
        public int NumberDeepBomb { get; set; }

        public Destroyer(string name, int hp, int armor)
           : base(name, hp, armor) { }

        public void LaunchTorpedo()
        {
            Console.WriteLine($"{name} запускає торпеду!");
        }
    }
}
