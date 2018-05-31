using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLayer.Contracts;

using DataAccessLayer;
using DataAccessLayer.Entities;

namespace BusinessLayer.Services
{
    public class ProductsService : IProductsService
    {
        private readonly DatabaseContext databaseContext;
        public ProductsService()
        {
            databaseContext = new DatabaseContext();
        }
        public List<Product> GetAllProducts(string warehouse = null, string category = null)
        {
            return databaseContext.GetProducts(warehouse, category);
        }
    }
}
