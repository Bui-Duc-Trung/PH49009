using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderBLL
    {
        OrderDAL ORDERDAL = new OrderDAL();
        public List<Order> GetallOrder()
        {
            var product = ORDERDAL.GetallOrder();
            return product;
        }

        public Order GetById(int id)
        {
            return ORDERDAL.GetbyId(id);
        }

        public List<Order> GetallOrderIdByCusId(int id)
        {
            return ORDERDAL.GetallOrderIdByCustomerId(id);
        }
        public bool Create(Order order)
        {
            return ORDERDAL.Create(order);
        }
        public bool Update(Order order)
        {
            return ORDERDAL.Update(order);
        }
        public bool Delete(int id)
        {
            return ORDERDAL.Delete(id);
        }
    }
}
