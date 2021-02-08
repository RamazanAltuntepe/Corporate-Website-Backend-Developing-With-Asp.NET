using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Narail.Models
{
    public class ContactFormModel
    {
        [Required]
        public string ContactName { get; set; }
        [Required]
        public string ContactMail { get; set; }
        public string ContactPhone { get; set; }
        public string ContactSubject { get; set; }
        public string ContactMessage { get; set; }
    }
}
