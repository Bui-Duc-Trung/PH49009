using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductDAL
    {
        ASM2CSHARP2Context ASM2CSHARP2Context = new ASM2CSHARP2Context();
        public List<Product> Getallproduct()
        {
            return ASM2CSHARP2Context.Products.ToList();
            ;
        }
        public Product GetbyId(int id) 
        {
            return ASM2CSHARP2Context.Products.Find(id);
        }

        public bool Create(Product product)
        {
            try
            {
                ASM2CSHARP2Context.Products.Add(product);
                ASM2CSHARP2Context.SaveChanges();
                return true;
            }
            catch { return false; }
        }
        public bool Update(Product product) 
        { 
            try
            {
                var find = ASM2CSHARP2Context.Products.Find(product.Id);
                if (find != null)
                {
                    find.ProductName = product.ProductName;
                    find.SupplierId = product.SupplierId;
                    find.UnitPrice = product.UnitPrice;
                    find.Package = product.Package;
                    find.IsDiscontinued = product.IsDiscontinued;
                    //ASM2CSHARP2Context.Products.Update(find);
                    //ASM2CSHARP2Context.SaveChanges();
                    //return true;
                }
                ASM2CSHARP2Context.Products.Update(find);
                ASM2CSHARP2Context.SaveChanges();
                return true;

            }
            catch { return false; }

        }

        public bool Delete(int id)
        {
            try
            {
                var find = ASM2CSHARP2Context.Products.Find(id);
                if (find != null)
                {
                    ASM2CSHARP2Context.Products.Remove(find);
                    ASM2CSHARP2Context.SaveChanges();
                }
                return true;
            }
            catch { return false; }
        }
    }
}
