using MvcSample.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcSample.Services
{
    internal interface ICustomersService
    {
        List<CustomersModel> GetAll();
        bool AddCustomer(CustomersModel model);
    }
}
