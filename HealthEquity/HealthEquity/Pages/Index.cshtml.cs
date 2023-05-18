using HealthEquity.Models;
using HealthEquity.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HealthEquity.Pages;

public class IndexModel : PageModel
{
    private CarService service = new CarService();

    public List<Car> Cars { get; set; } = new List<Car>();
    public GuessResult GuessResult = new GuessResult();

    public void OnGet()
    {
        Cars = new CarService().GetAllCars();
        
    }
    
    public IActionResult OnPostGuessPrice(int carId, int guess)
    {
        var car = service.GetCarById(carId);
        if (car == null) return Page();
        var difference = Math.Abs(car.Price - guess);

        if (difference <= 5000)
        {
            TempData["WellDoneMessage" + car.Id] = "Great job!";
        }
        return RedirectToPage("Index");
    }
}

public class GuessResult
{
    public string Message { get; set; }
    public string Color { get; set; }
}