using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {   

        private static  List<DogViewModel> dogs=new List<DogViewModel>();
        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel()
            {
                Name = "zip",
                Age = 1
            };
            return View(dogs);
        }

        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }

        public IActionResult CreateDog( DogViewModel dogviewModel)
        {
            // return View("Index" );
            dogs.Add(dogviewModel);
            return RedirectToAction(nameof(Index)); 
        }

        

        public String Hello()
        {
            return "whoese there?";

        }
    }
}
