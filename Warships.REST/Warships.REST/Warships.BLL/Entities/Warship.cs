namespace Warships.BLL.Entities
{
    public class Warship
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public int YearBuilt { get; set; }
    }
}
