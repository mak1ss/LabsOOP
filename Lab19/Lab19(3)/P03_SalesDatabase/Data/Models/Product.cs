using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19_3_.P03_SalesDatabase.Data.Models
{
    public class Product
    {
        [Column("ProductId")]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public ICollection<Sale> Sales { get; set; }

        public string Description { get; set; }
    }
}
