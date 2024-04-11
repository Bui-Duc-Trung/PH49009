using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SupplierDAL
    {
        ASM2CSHARP2Context _context;

        public SupplierDAL()
        {
            _context = new ASM2CSHARP2Context();
        }

        public List<Supplier> GetAllSupplier() 
        {
            return _context.Suppliers.ToList();
        }

       public Supplier GetById(int id)
        {
            return _context.Suppliers.Find(id);
        }
    }
}
