namespace WarShips.Common
{
    internal static class TroopersExtensionsHelpers
    {
        public static void Report(this Troopers trooper)
        {
            Console.WriteLine($"Ім'я: {trooper.Name}, Вік: {trooper.Age}, Ранг: {trooper.Rank}");
        }
    }
}