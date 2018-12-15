using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProfBusWeb.Models
{
    public class ContactUsModel
    {
        [Required]
        public string Name;

        [Required]
        public string Address;

        [Required]
        public string Text;

        [Required]
        public string Phone;
    }
}
