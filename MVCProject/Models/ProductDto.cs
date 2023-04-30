using MessagePack;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace MVCProject.Models
{
    public class ProductDto
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int ProductId { get; set; }

        public string ProductName { get; set; } 

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

    }
}
