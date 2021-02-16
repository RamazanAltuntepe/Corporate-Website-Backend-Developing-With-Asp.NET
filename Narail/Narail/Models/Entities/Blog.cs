using System;

namespace Narail.Models.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        public string BlogName { get; set; }
        public string BlogImage { get; set; }
        public string BlogContent { get; set; }
        public DateTime SaveDate { get; set; }
        public string BlogAuthor { get; set; }
        public string BlogCategory { get; set; }
    }
}
