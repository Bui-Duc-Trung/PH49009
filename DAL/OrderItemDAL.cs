using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderItemDAL
    {
        ASM2CSHARP2Context ASM2CSHARP2Context = new ASM2CSHARP2Context();

        public bool Create(OrderItem orderItem)
        {
            try
            {
                ASM2CSHARP2Context.OrderItems.Add(orderItem);
                ASM2CSHARP2Context.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public bool Delete(int id)
        {
            try
            {
                var find = ASM2CSHARP2Context.OrderItems.Where(x => x.OrderId == id).ToList();
                if(find != null)
                {
                    for (int i = 0; i < find.Count; i++)
                    {
                        ASM2CSHARP2Context.OrderItems.Remove(find[i]);
                        ASM2CSHARP2Context.SaveChanges();
                    }
                    
                }
                
                return true;
            }
            catch { return false; }
        }
    }
}
