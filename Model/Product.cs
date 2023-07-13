using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDSTORE.Model
{
    /// <summary>
    /// This Class is used like a Model and his properties are used to save Product information.
    /// </summary>
    internal class Product
    {
        /// <value>Save the ID of the products. </value>
        public int ID { get; set; }
        /// <value>Save the Name of the products. </value>
        public string Name { get; set; }
        /// <value>Save the Description of the products. </value>
        public string Description { get; set; }
        /// <value>Save the Size of the products. </value>
        public double Size { get; set; }
        /// <value>Save the Price of the products. </value>
        public double Price { get; set; }
        /// <value>Save the Amount available of the products. </value>
        public double Available { get; set; }
        /// <value>Save a Photo of the product. </value>
        public byte[] Photo { get; set; }
        /// <value>Save the Id of the Delivery. </value>
        public int IdDelivery { get; set; }
    }
}
