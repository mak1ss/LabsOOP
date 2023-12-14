using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22.BookShop.Data.Model
{
    [Table("Categories")]
    public class Category
    {
        [Column("CategoryId")]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        public ICollection<BookCategory> CategoriesBook { get; set; }
    }
}
