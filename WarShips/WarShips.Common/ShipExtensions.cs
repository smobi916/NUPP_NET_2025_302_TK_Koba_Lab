using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarShips.Common
{
    public static class TroopersExtensions
    {
    }
    public static class ShipExtensions
    {
        // Метод розширення
        public static void Signal(this Ship ship)
        {
            Console.WriteLine(" Корабель подає сигнал тривоги!");
        }
    }
}
