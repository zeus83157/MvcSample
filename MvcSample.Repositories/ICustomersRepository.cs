using MvcSample.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcSample.Repositories
{
    internal interface ICustomersRepository
    {
        List<CustomersData> GetAll();
        bool Insert(CustomersData data);
    }
}
