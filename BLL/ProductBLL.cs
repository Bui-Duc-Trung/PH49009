using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductBLL
    {
        private ASM2CSHARP2Context dbContextt = new ASM2CSHARP2Context();
        private DataTable dtPro = new DataTable();
        ProductDAL PRDAL = new ProductDAL();
        public List <Product> Getallproduct()
        {
            var product = PRDAL.Getallproduct();
            return product;
        }
        //public void ShowDSPro()
        //{
        //    foreach (var product in Getallproduct())
        //    {
        //        DataRow dr = dtPro.NewRow();
        //        dr["ID"] = product.Id;
        //        dr["ProductName"] = product.ProductName;
        //        dr["SupplierId"] = product.SupplierId;
        //        dr["UnitPrice"] = product.UnitPrice;
        //        dr["Package"] = product.Package;
        //        dr["IsDiscontinued"] = product.IsDiscontinued;
        //        dtPro.Rows.Add(dr);
        //    }

        //}
        public bool Create(Product product)
        {
            return PRDAL.Create(product);
        }
        
        public Product GetById(int id)
        {
            return PRDAL.GetbyId(id);
        }

        public bool Update(Product product)
        {
            return PRDAL.Update(product);
        }
        public bool Delete(int id)
        {
            return PRDAL.Delete(id);
        }
    }
    
}
