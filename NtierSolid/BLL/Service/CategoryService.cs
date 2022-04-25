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
    public class CategoryService:ICategoryCrud
    {

        NTierSolidContext db = new NTierSolidContext();


        public void CreateCategory(Category category)
        {
            try
            {
                db.Categories.Add(category);
                db.SaveChanges();
                return;
            }
            catch (Exception)
            {
                return;

            }
        }

        public void DeleteCategory(int id)
        {
            try
            {
                Category deleted = db.Categories.Find(id);
                if (deleted != null)
                {
                    db.Categories.Remove(deleted);
                    db.SaveChanges();
                    return;
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

        public void UpdateCategory(Category category)
        {
            db.Entry(category).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return;
        }
    }
}
