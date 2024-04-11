using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerDAL
    {
        ASM2CSHARP2Context ASM2CSHARP2Context = new ASM2CSHARP2Context();
        public List<Customer> Getallcustomer()
        {
            return ASM2CSHARP2Context.Customers.ToList();
            ;
        }
        public bool Create(Customer customer)
        {
            try
            {
                ASM2CSHARP2Context.Customers.Add(customer);
                ASM2CSHARP2Context.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public bool Update(Customer customer) 
        {
            try
            {
                var find = ASM2CSHARP2Context.Customers.Find(customer.Id);
                if (find != null)
                {
                    find.FirstName = customer.FirstName;
                    find.LastName = customer.LastName;
                    find.City = customer.City;
                    find.Country = customer.Country;
                    find.Phone = customer.Phone;
                    //ASM2CSHARP2Context.Products.Update(find);
                    //ASM2CSHARP2Context.SaveChanges();
                    //return true;
                }
                ASM2CSHARP2Context.Customers.Update(find);
                ASM2CSHARP2Context.SaveChanges();
                return true;

            }
            catch { return false; }
        }

        public Customer GetbyId(int id)
        {
            return ASM2CSHARP2Context.Customers.Find(id);
        }

        public bool Delete(int id)
        {
            try
            {
                var find = ASM2CSHARP2Context.Customers.Find(id);
                if (find != null)
                {
                    ASM2CSHARP2Context.Customers.Remove(find);
                    ASM2CSHARP2Context.SaveChanges();
                }
                return true;
            }
            catch { return false; }
        }
    }
}
