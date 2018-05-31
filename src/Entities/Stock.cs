using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Stock
    {
        public int Quantity { get; set; }
        public Single Price { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}
