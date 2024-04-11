using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderItemBLL
    {
        OrderItemDAL OIDAL = new OrderItemDAL();
        public List<OrderItem> GetallOrderItem()
        {
            var orderitem = GetallOrderItem();
            return orderitem;
        }

        public bool Delete(int id)
        {
            return OIDAL.Delete(id);
        }
        public bool Create(OrderItem orderItem)
        {
            return OIDAL.Create(orderItem);
        }
    }
}
