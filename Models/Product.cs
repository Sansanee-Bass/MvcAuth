
using System.Collections.Generic;

namespace MvsAuth.Models
{
    public class Product
    {

        public uint ProductID { get; set; }

        public uint Count { get; set; }

        public string Location { get; set; }

        public virtual ICollection<Stock> Inventory { get; set; }
    }




}