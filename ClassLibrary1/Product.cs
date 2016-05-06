using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Product")]
    public class Product : Identificable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
