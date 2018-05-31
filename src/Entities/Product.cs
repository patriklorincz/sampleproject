using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }


        public Category ProductCategory { get; set; }
        public List<ProviderSupply> Providers { get; set; }
        public List<Stock> Stocks { get; set; } 
    }
}
