using MvcSample.Repositories.EFDbContext;
using MvcSample.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcSample.Repositories
{
    public class CustomersRepository : ICustomersRepository
    {
        private readonly CustomerInfoContext _Context;
        public CustomersRepository(CustomerInfoContext context)
        {
            _Context = context;
        }
        public List<CustomersData> GetAll()
        {
            return _Context.Customers.Select(x =>
            new CustomersData
            {
                Contactnum = x.Contactnum,
                Custid = x.Custid,
                Custnm = x.Custnm,
                Perosnalid = x.Perosnalid
            }).ToList();
        }

        public bool Insert(CustomersData data)
        {
            _Context.Customers.Add(
                new Customers
                {
                    Contactnum = data.Contactnum,
                    Custid = data.Custid,
                    Custnm = data.Custnm,
                    Perosnalid = data.Perosnalid
                });
            return _Context.SaveChanges() > 0;
        }
    }
}
