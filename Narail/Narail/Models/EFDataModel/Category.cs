using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Narail.Models.EFDataModel
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
