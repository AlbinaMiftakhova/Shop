using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Category
    {
        [Key]
        public int ID_category { get; set; }
        public string Name { get; set; }
        public List<Clothing> Clothes { get; set; }
    }
}