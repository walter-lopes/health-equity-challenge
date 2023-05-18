using HealthEquity.Models;

namespace HealthEquity.Services;

public class CarService
{
    private List<Car> cars;

    public CarService()
    {
        cars = new List<Car>()
        {
            new Car { Id = 1, Make = "Audi", Model = "R8", Year = 2018, Doors = 2, Color = "Red", Price = 79995 },
            new Car { Id = 2, Make = "Tesla", Model = "3", Year = 2018, Doors = 4, Color = "Black", Price = 54995 },
            new Car { Id = 3, Make = "Porsche", Model = "911 991", Year = 2020, Doors = 2, Color = "White", Price = 155000 },
            new Car { Id = 4, Make = "Mercedes-Benz", Model = "GLE 63S", Year = 2021, Doors = 5, Color = "Blue", Price = 83995 },
            new Car { Id = 5, Make = "BMW", Model = "X6 M", Year = 2020, Doors = 5, Color = "Silver", Price = 62995 }
        };
    }

    public List<Car> GetAllCars()
    {
        return cars;
    }

    public Car? GetCarById(int id)
    {
        return cars.FirstOrDefault(c => c.Id == id) ?? null;
    }

    public void AddCar(Car car)
    {
        car.Id = cars.Max(c => c.Id) + 1;
        cars.Add(car);
    }

    public void UpdateCar(Car car)
    {
        var existingCar = cars.FirstOrDefault(c => c.Id == car.Id);
        if (existingCar == null) return;
        existingCar.Make = car.Make;
        existingCar.Model = car.Model;
        existingCar.Year = car.Year;
        existingCar.Doors = car.Doors;
        existingCar.Color = car.Color;
        existingCar.Price = car.Price;
    }

    public void DeleteCar(int id)
    {
        var car = cars.FirstOrDefault(c => c.Id == id);
        if (car != null)
        {
            cars.Remove(car);
        }
    }
}