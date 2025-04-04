using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.PublicTransit.PublicTransit.Common
{
    internal class Vehicle
    {
        public class Vehicle
        {
            public Guid Id { get; set; }
            public string Brand { get; set; }
            public string Model { get; set; }

            public Vehicle(string brand, string model)
            {
                Id = Guid.NewGuid();
                Brand = brand;
                Model = model;
            }

            public override string ToString()
            {
                return $"{Brand} {Model}";
            }
        }

    }
}
