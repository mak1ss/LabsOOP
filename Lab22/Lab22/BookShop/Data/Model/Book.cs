using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22.BookShop.Data.Model
{
    public enum EditionType
    {
        Normal, Promo, Gold
    }

    public enum AgeRestriction
    {
        Minor, Teen, Adult
    }

    [Table("Books")]
    public class Book
    {
        [Column("BookId")]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        public DateOnly? ReleaseDate { get; set; }
        public int Copies { get; set; }
        public float Price { get; set; }

        public EditionType EditionType { get; set; }
        public AgeRestriction AgeRestriction { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }
    }
}
