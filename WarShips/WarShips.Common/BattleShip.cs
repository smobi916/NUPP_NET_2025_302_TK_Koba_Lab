using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarShips.Common
{
    internal class BattleShip : Ship
    {

        public String Capitan { get; set; }
        public int Calibr { get; set; }
        public int NumberofGun { get; set; }
        public int NumberOfTower { get; set; }
        public object NumberOfGun { get; private set; }

        // Конструктор
        public BattleShip(string name, int hp, int armor, string capitan)
            : base(name, hp, armor)
        {
            Capitan = capitan;
        }

        // Метод
        public void FireSalvo()
        {
            Console.WriteLine($"{name} виконує залп усіма {NumberOfGun} гарматами!");
        }
    }
}
