using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Autor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Last_name { get; set; }
        [Required]
        public string First_name { get; set; }
        [Required]
        public string NickName { get; set; }

        public DateOnly Birthday { get; set; }
    }
}
