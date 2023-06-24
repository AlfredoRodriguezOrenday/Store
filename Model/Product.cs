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
        public double Cantidad { get; set; }
        public double Price { get; set; }
        public double Abadible { get; set; }
        public int IdDelivery { get; set; }
    }
}
