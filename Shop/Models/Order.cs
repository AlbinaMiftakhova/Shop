using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Shop.Models
{
    [Bind(Exclude = "OrderId")]
    public partial class Order
    {
        [ScaffoldColumn(false)]
        public int OrderId { get; set; }

        [ScaffoldColumn(false)]
        public System.DateTime OrderDate { get; set; }

        [ScaffoldColumn(false)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Введите имя")]
        [DisplayName("Имя")]
        [StringLength(160)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Введите фамилию")]
        [DisplayName("Фамилия")]
        [StringLength(160)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Введите адрес")]
        [DisplayName("Адрес")]
        [StringLength(70)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Введите город")]
        [DisplayName("Город")]
        [StringLength(40)]
        public string City { get; set; }

        [Required(ErrorMessage = "Введите регион")]
        [DisplayName("Регион")]
        [StringLength(40)]
        public string State { get; set; }

        [Required(ErrorMessage = "Введите индекс")]
        [DisplayName("Индекс")]
        [StringLength(10)]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Введите страну")]
        [DisplayName("Страна")]
        [StringLength(40)]
        public string Country { get; set; }

        [Required(ErrorMessage = "Введите телефон")]
        [DisplayName("Телефон")]
        [StringLength(24)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Введите адрес электронной почты")]
        [DisplayName("Электронная почта")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = "Электронная почта недействительна.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public decimal Total { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}