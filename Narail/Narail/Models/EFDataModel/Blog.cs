using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Narail.Models.EFDataModel
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string BlogName { get; set; }
        public string BlogImage { get; set; }
        public string BlogContent { get; set; }
        public DateTime SaveDate { get; set; }
        public string Author { get; set; }
        public List<Category> Categories { get; set; }
    }
}
