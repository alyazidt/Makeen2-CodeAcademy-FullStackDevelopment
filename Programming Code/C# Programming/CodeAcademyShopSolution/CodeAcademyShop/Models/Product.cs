using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademyShop.Models
{
    internal class Product
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Product_Id { get; set; }

        [Required(ErrorMessage = "Please Write The Name")]
        public string Name { get; set; }

        public string? Descreption { get; set; }

        public int Quantity { get; set; }

        [DataType(DataType.Currency)]
        public int Price { get; set; }


        public bool HasDiscount { get; set; } = false;

        [ForeignKey("CategoriesId")]
        public Categories categories { get; set; }

        public int CategoriesId { get; set; }

    }
}
