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
            catch (Exception)
            {
                return;
                
            }
        }

        public void DeleteProduct(int id)
        {
            try
            {
                Product deleted = db.Products.Find(id);
                if (deleted != null)
                {
                    db.Products.Remove(deleted);
                    db.SaveChanges();
                    
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {

                return;
            }
        }

        

        public void UpdateProduct(Product product)
        {
            db.Entry(product).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return;
        }
    }
}
