using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace emarket.Models
{
    public class categories
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }

        public int number_of_products { get; set; }
        public ICollection<products> products { get; set; }
    }
}