using ConsoleApp1.PublicTransit.PublicTransit.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.PublicTransit.PublicTransit.Console
{
    internal class Program
    {
        static void Main()
        {
            var busService = new CrudService<Bus>();

            // Створення кількох автобусів
            Bus bus1 = new Bus("Mercedes", "Sprinter", 30, "Route A", 10.5);
            var bus2 = new Bus("Volvo", "9400", 50, "Route B", 15.2);

            busService.Create(bus1);
            busService.Create(bus2);

            // Виведення всіх автобусів
            object value = Console.WriteLine("All Buses:");
            foreach (var bus in busService.ReadAll())
            {
                bus.DisplayDetails();
            }

            // Збереження даних у файл
            busService.Save("buses.json");

            // Завантаження з файлу
            var loadedService = new CrudService<Bus>();
            loadedService.Load("buses.json");

            object value1 = Console.WriteLine("\nLoaded Buses:");
            foreach (var bus in loadedService.ReadAll())
            {
                bus.DisplayDetails();
            }
        }
    }
}
