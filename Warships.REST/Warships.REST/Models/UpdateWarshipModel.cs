namespace Warships.REST.Models
{
    public class UpdateWarshipModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public int? YearBuilt { get; set; }
    }
}
