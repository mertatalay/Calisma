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
    public class Admin : AppUser, ICategoryCrud,IProductCrud,IReport
    {
        NTierSolidContext db=new NTierSolidContext();
        public List<Category> CategoryList()
        {
            return db.Categories.ToList();
        }

        public void CreateCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public void CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> ProductList()
        {
            return db.Products.ToList();
        }

        public void UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
