using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.PublicTransit.PublicTransit.Common
{
    internal class Bus
    {
        private string v1;
        private string v2;
        private int v3;
        private string v4;
        private double v5;

        public Bus(string v1, string v2, int v3, string v4, double v5)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
        }

        public class Bus : Vehicle
        {
            public int Capacity { get; set; }
            public string Root { get; set; }
            public double FuelConsumption { get; set; }

            // Статичне поле
            private static int BusCount = 0;

            // Статичний конструктор
            static Bus()
            {
                BusCount = 0;
            }

            // Конструктор
            public Bus(string brand, string model, int capacity, string root, double fuelConsumption)
                : base(brand, model)
            {
                Capacity = capacity;
                Root = root;
                FuelConsumption = fuelConsumption;
                BusCount++;
            }

            // Статичний метод
            public static int GetBusCount() => BusCount;

            // Метод розширення
            public static void DisplayDetails(this Bus bus)
            {
                Console.WriteLine($"Bus: {bus.Brand} {bus.Model}, Capacity: {bus.Capacity}, Root: {bus.Root}, Fuel Consumption: {bus.FuelConsumption}L/100km");
            }
        }

    }
}
