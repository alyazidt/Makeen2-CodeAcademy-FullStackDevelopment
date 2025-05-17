using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademyShop.Models
{
    internal class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        [ForeignKey("Product_Id")]
        public Product product { get; set; }
        public int Product_Id { get; set; }

        public List<Product> products = new List<Product> { };

    }
}
