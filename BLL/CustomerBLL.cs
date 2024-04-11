using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CustomerBLL
    {
        CustomerDAL CTDAL = new CustomerDAL();
        public List<Customer> Getallcustomer()
        {
            var customers = CTDAL.Getallcustomer();
            return customers;
        }

        public bool Create(Customer customer)
        {
            return CTDAL.Create(customer);
        }

        public Customer GetById(int id)
        {
            return CTDAL.GetbyId(id);
        }

        public bool Update(Customer customer)
        {
            return CTDAL.Update(customer);
        }
        public bool Delete(int id)
        {
            return CTDAL.Delete(id);
        }
    }
}
