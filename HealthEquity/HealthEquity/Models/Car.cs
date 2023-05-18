namespace HealthEquity.Models;

public class Car
{
    public int Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int Doors { get; set; }
    public string Color { get; set; }
    public decimal Price { get; set; }

    public void Update(string make, string model, int year, int doors, string color, decimal price)
    {
        Make = make;
        Model = model;
        Year = year;
        Doors = doors;
        Color = color;
        Price = price;
    }
}