using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Client
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string CompanyAbbreviation { get; set; }
    }
}