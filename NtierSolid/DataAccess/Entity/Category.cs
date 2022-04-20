using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }

        //mapping

        public int ProductID { get; set; }
        public Product ProductName { get; set; }

    }
}
