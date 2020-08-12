using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace Shop.Models
{
    [Bind(Exclude = "ID_clothing")]
    public class Clothing
    {
        [ScaffoldColumn(false)]
        [Key]
        public int ID_clothing { get; set; }

        [DisplayName("Категория")]
        public int ID_category { get; set; }

        [Required(ErrorMessage = "Введите наименование")]
        [StringLength(160)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите цену")]
        [Range(1, 50000, ErrorMessage = "Цена должна быть в диапазоне от 1 до 50000 рублей")]
        public int Price { get; set; }

        [DisplayName("Фото")]
        [StringLength(1024)]
        public string Photo { get; set; }
        public string Photo1 { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}