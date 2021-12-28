using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restorant.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        [Display(Name = "Price")]
        public double Price { get; set; }
        [Display(Name = "Image")]
        public byte[]? Image { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category? Category { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        [Display(Name = "Category")]
        public int CategoryID { get; set; }
    }
}
