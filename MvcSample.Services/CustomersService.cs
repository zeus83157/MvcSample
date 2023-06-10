using MvcSample.Repositories;
using MvcSample.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcSample.Services
{
    internal class CustomersService : ICustomersService
    {
        private readonly ICustomersRepository _customersRepository;

        public CustomersService(ICustomersRepository customersRepository)
        {
            _customersRepository = customersRepository;
        }

        public bool AddCustomer(CustomersModel model)
        {
            return _customersRepository.Insert(
                new Repositories.Models.CustomersData 
                {
                    Contactnum = model.Contactnum,
                    Custid = model.Custid,
                    Custnm = model.Custnm,
                    Perosnalid = model.Perosnalid
                });
        }

        public List<CustomersModel> GetAll()
        {
            return _customersRepository.GetAll().Select(x =>
            new CustomersModel
            {
                Contactnum = x.Contactnum,
                Custid = x.Custid,
                Custnm = x.Custnm,
                Perosnalid = x.Perosnalid
            }).ToList();
        }
    }
}
