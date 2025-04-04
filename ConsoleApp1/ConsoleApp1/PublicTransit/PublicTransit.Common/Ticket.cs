using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.PublicTransit.PublicTransit.Common
{
    internal class Ticket
    {
        public class Ticket
        {
            public Guid Id { get; set; }
            public double Price { get; set; }
            public string SerialNumber { get; set; }

            public Ticket(double price, string serialNumber)
            {
                Id = Guid.NewGuid();
                Price = price;
                SerialNumber = serialNumber;
            }

            public override string ToString()
            {
                return $"Ticket {SerialNumber}: {Price} USD";
            }
        }

    }
}
