using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Lab22.BookShop.Data.Model
{
    [Table("Authors")]
    public class Author
    {
        [Column("AuthorID")]
        public int Id { get; set; }

        [MaxLength(50)]
        public string? FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
