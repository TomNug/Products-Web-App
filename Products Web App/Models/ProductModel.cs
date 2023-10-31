using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Products_Web_App.Models
{
    public class ProductModel
    {
        [DisplayName("Id number")]
        public int Id { get; set; }
        [DisplayName("Product")]
        public string Name { get; set; }
        [DisplayName("RRP")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [DisplayName("Description")]
        public string Description { get; set; }
    }
}
