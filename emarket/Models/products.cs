using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace emarket.Models
{
    public class products
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "you should enter name of product")]
        [Display(Name = "Name")]
        public string name { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 3, ErrorMessage = "Enter your description")]
        [Display(Name = "Discription")]
        public string discription { get; set; }

        [FileExtensions(Extensions = "jpg,png,jpeg")]
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Product image")]
        public string image { get; set; }

        [Required]
        [Display(Name = "Price")]
        public int price { get; set; }

        
        public int category_id { get; set; }
        public virtual categories Category { get; set; }
        public IEnumerable<categories> c { get; set; }
        public object categories { get; internal set; }
    }
}