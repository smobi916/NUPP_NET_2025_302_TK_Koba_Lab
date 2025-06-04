using WarShips.Common;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        BattleShip titan = new BattleShip("Титан", 5000, 1000, "Капітан Коваль");
        Destroyer hunter = new Destroyer("Мисливець", 3000, 500);

        // Підписка на подію
        titan.OnShipDamaged += msg => Console.WriteLine(" Подія: " + msg);

        titan.FireSalvo();
        hunter.LaunchTorpedo();

        // Виклик методу
        titan.TakeDamage(300);

        // Метод розширення
        titan.Signal();

        // Статичний метод
        Ship.DisplayShipCount();


        // Використання Troopers
        Troopers soldier = new Troopers("Ілля", 27, "Сержант");
        soldier.Report();
    }
}
