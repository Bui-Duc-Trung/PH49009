using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderDAL
    {
        ASM2CSHARP2Context ASM2CSHARP2Context = new ASM2CSHARP2Context();
        public List<Order> GetallOrder()
        {
            return ASM2CSHARP2Context.Orders.ToList();
            ;
        }
        public Order GetbyId(int id)
        {
            return ASM2CSHARP2Context.Orders.Find(id);
        }

        public List<Order> GetallOrderIdByCustomerId(int id) 
        {
            return ASM2CSHARP2Context.Orders.Where(x => x.CustomerId == id).ToList();
        }
        public bool Create(Order order)
        {
            try
            {
                ASM2CSHARP2Context.Orders.Add(order);
                ASM2CSHARP2Context.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public bool Update(Order order)
        {
            try
            {
                var find = ASM2CSHARP2Context.Orders.Find(order.Id);
                if (find != null)
                {
                    find.OrderDate = order.OrderDate;
                    find.OrderNumber = order.OrderNumber;
                    find.CustomerId = order.CustomerId;
                    find.TotalAmount = order.TotalAmount;
                    
                    //ASM2CSHARP2Context.Products.Update(find);
                    //ASM2CSHARP2Context.SaveChanges();
                    //return true;
                }
                ASM2CSHARP2Context.Orders.Update(find);
                ASM2CSHARP2Context.SaveChanges();
                return true;

            }
            catch { return false; }

        }
        public bool Delete(int id)
        {
            try
            {
                var find = ASM2CSHARP2Context.Orders.Where(x => x.CustomerId == id).ToList();
                if (find != null)
                {
                    for (int i = 0; i < find.Count; i++)
                    {
                        ASM2CSHARP2Context.Orders.Remove(find[i]);
                        ASM2CSHARP2Context.SaveChanges();
                    }
                    
                }
                return true;
            }
            catch { return false; }
        }
    }
}
