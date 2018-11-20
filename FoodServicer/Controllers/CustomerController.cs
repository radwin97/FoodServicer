using FoodServicer.Library.Interfaces;
using FoodServicer.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace FoodServicer.Controllers
{
    //[ValidateAntiForgeryToken]
    public class CustomerController : Controller
    {
        private readonly ICustomerSearchManager _customerSarchManager;

        public CustomerController(ICustomerSearchManager customerSarchManager)
        {
            _customerSarchManager = customerSarchManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new CustomerSearchViewModel());
        }

        [HttpPost]
        public IActionResult Search(CustomerSearchViewModel viewModel)
        {
            _customerSarchManager.Manage(viewModel);
            return View("Index", viewModel);
        }

        public IActionResult Detail(long id)
        {
            return View();
        }


        public IActionResult Update(long id)
        {
            return View();
        }


        public IActionResult Insert(long id)
        {
            return View();
        }
    }
}