using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SupplierBLL
    {
        public SupplierDAL _suplierDAL = new SupplierDAL();
        //SupplierDAL _suplierDAL;

        //public SupplierBLL()
        //{
        //    _suplierDAL = new SupplierDAL();
        //}

        public List<Supplier> GetAllSupplier()
        {
            return _suplierDAL.GetAllSupplier();
        }

        public Supplier GetById(int id)
        {
            return _suplierDAL.GetById(id);
        }
    }
}
