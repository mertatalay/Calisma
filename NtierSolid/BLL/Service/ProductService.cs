using BLL.Interface;
using DataAccess.Context;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class ProductService : IProductCrud
    {
        NTierSolidContext db = new NTierSolidContext();
        public void CreateProduct(Product product)
        {
            try
            {
                db.Products.Add(product);
                db.SaveChanges();
                return;
            }
            catch (System.Exception ex)
            {
                return;
                
            }
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> ProductList()
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
