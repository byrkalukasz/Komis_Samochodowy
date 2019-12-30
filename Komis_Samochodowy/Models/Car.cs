namespace Komis_Samochodowy.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string Millage { get; set; }
        public string EngineSize { get; set; }
        public string Fuel { get; set; }
        public string Power { get; set; }
        public string Description { get; set; }
        public decimal Prize { get; set; }
        public string FotoURL { get; set; }
        public string MiniPhotoUrl { get; set; }
        public bool WeekCar { get; set; }
    }
}
