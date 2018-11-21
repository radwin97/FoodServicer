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
            return RedirectToAction("Search");
        }

        [HttpGet]
        public IActionResult Search()
        {
            return View("Index", new CustomerSearchViewModel());
        }

        [HttpPost]
        public IActionResult Search(CustomerSearchViewModel viewModel)
        {
            _customerSarchManager.Manage(viewModel);
            return View("Index", viewModel);
        }

        [HttpGet]
        public IActionResult Detail(long id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateCustomerViewModel viewModel)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(long id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(UpdateCustomerViewModel viewModel)
        {
            return View();
        }
    }
}