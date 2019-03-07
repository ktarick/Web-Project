using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sample.Models
{
    public class Product
    {        
        public int ProductId { get; set; }

        [Required()]
        [StringLength(40)]
        public string Name { get; set; }

        [Range(0,100)]
        public int Qty { get; set; }

        [StringLength(200)]
        public string Description { get; set; }


        public decimal Price { get; set; }
    }
}