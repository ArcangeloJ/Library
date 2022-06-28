using System.ComponentModel.DataAnnotations;

namespace Library
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Nationality { get; set; }
        public string? Bio { get; set; }

    }
}
