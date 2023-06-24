using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDSTORE.Model
{
    internal class DeliveryProduct
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public int PhoneNumber { get; set; }
        public string DeliveryDays { get; set; }
    }
}
