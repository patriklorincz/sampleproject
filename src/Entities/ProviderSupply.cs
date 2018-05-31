using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class ProviderSupply
    {
        public Single AcquisitionPrice { get; set; }
        public Provider Provider { get; set; }
    }
}
