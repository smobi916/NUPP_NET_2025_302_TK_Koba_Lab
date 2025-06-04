using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarShips.Common
{
    // Делегат для події пошкодження
    public delegate void ShipDamagedHandler(string message);


    public class Ship
    {
        public int armor;
        public int hp;
        public string name;
        public int firepower;
        public int length;

        public Ship() { }


        // Статичне поле
        public static int ShipCount;

        // Подія
        public event ShipDamagedHandler OnShipDamaged;

        // Статичний конструктор
        static Ship()
        {
            ShipCount = 0;
        }

        // Звичайний конструктор
        public Ship(string name, int hp, int armor)
        {
            this.name = name;
            this.hp = hp;
            this.armor = armor;
            ShipCount++;
        }

        // Метод
        public virtual void TakeDamage(int amount)
        {
            hp -= amount;
            OnShipDamaged?.Invoke($"{name} отримав {amount} пошкодження!");
        }

        // Статичний метод
        public static void DisplayShipCount()
        {
            Console.WriteLine($"Загальна кількість кораблів: {ShipCount}");
        }
    }
}
