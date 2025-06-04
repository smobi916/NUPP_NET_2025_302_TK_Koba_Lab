    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    namespace WarShips.Common
    {
        internal class Troopers 
        {
            public String Name { get; set; }
            public int Age { get; set; }
            public String Rank { get; set; }

            public Troopers(string name, int age, string rank)
            {
                Name = name;
                Age = age;
                Rank = rank;
            }
        }
    }
