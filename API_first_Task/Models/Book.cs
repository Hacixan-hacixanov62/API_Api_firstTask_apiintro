using System.ComponentModel.DataAnnotations;

namespace API_first_Task.Models
{
    public class Book:BaseEntity
    {
        [StringLength(20)]
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}
