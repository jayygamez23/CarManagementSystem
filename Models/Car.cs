namespace CarManagementSystem.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string LicensePlate { get; set; }
        public float Price { get; set; }
        public bool isSold { get; set; }
        public Car()
        {
            
        }
    }
}
