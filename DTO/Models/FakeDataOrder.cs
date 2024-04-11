using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public class FakeDataOrder
    {
        public string name {  get; set; }
        
        public int quantity { get; set; }

        public int productId { get; set; }

        public int ID { get; set; }

        public decimal price { get; set; }

        public FakeDataOrder()
        {
            
        }

        public FakeDataOrder(string name, int quantity, int productId, int iD, decimal price)
        {
            this.name = name;
            this.quantity = quantity;
            this.productId = productId;
            ID = iD;
            this.price = price;
        }
    }
}
