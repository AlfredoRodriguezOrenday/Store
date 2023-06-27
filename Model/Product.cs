using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDSTORE.Model
{
    internal class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Size { get; set; }
        public double Price { get; set; }
        public double Available { get; set; }
        public byte[] Photo { get; set; }
        public int IdDelivery { get; set; }
    }
}
