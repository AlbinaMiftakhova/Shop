using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Cart
    {
        [Key]
        public int RecordId { get; set; }
        public string CartId { get; set; }
        public int ID_clothing { get; set; }
        public int Count { get; set; }
        public System.DateTime DateCreated { get; set; }
        public virtual Clothing Clothing { get; set; }
    }

}