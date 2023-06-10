using Microsoft.AspNetCore.Mvc;
using MvcSample.Models.ViewModels;
using MvcSample.Services;

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
                .Select( x => 
                new CustomerViewModel
                {
                    Contactnum = x.Contactnum,
                    Custid = x.Custid,
                    Custnm = x.Custnm,
                    Perosnalid= x.Perosnalid
                }).ToList();
            return View(model);
        }
    }
}
