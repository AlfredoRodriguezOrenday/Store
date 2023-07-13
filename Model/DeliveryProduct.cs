using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDSTORE.Model
{
    /// <summary>
    /// This Class is used like a Model and his properties are used to save DeliveryProduct information.
    /// </summary>
    internal class DeliveryProduct
    {
        /// <value>Save the ID of the delivery products. </value>
        public int ID { get; set; }
        /// <value>Save the Name of the delivery products. </value>
        public string Name { get; set; }
        /// <value>Save the Company of the delivery products. </value>
        public string Company { get; set; }
        /// <value>Save the Phone Number of the Company. </value>
        public int PhoneNumber { get; set; }
        /// <value>Save the Delivery days that the company delivery the products. </value>
        public string DeliveryDays { get; set; }
    }
}
