using Microsoft.AspNetCore.Mvc;
using MvcSample.Models.ViewModels;
using MvcSample.Services;
using MvcSample.Services.Models;

namespace MvcSample.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomersService _CustomersService;
        public CustomerController(ICustomersService customersService)
        {
            _CustomersService = customersService;
        }
        public IActionResult Index()
        {
            var model = _CustomersService.GetAll()
                .Select(x =>
               new CustomerViewModel
               {
                   Contactnum = x.Contactnum,
                   Custid = x.Custid,
                   Custnm = x.Custnm,
                   Perosnalid = x.Perosnalid
               }).ToList();
            return View(model);
        }
        public IActionResult Create(CustomerViewModel model)
        {
            if (ModelState.IsValid)
            {
                _CustomersService.AddCustomer(
                new CustomersModel
                {
                    Custid = Guid.NewGuid(),
                    Contactnum = model.Contactnum,
                    Custnm = model.Custnm,
                    Perosnalid = model.Perosnalid
                });
                ModelState.Clear();
            }
            return View();
        }
    }
}
