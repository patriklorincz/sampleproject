using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayer.Entities;

namespace BusinessLayer.Contracts
{
    public interface IProductsService
    {
        List<Product> GetAllProducts(string warehouse = null, string category = null);
    }
}
