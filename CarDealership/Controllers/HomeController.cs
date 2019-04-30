
using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index()
    {
      Cars starterCar = new Cars("Add first car to the car inventory");
      return View(starterCar);
    }
    [Route("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [Route("/cars")]
    public ActionResult Create(string makeModel, string color, int mileage, int price)
    {
      Cars myCar = new Cars(makeModel, color, mileage, price);
      return View("Index", myCar);
    }
  }

}
