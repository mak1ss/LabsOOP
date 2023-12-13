using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19_3_.P03_SalesDatabase.Data.Models
{
    public class Sale
    {
        [Column("SaleId")]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Product Product { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public Customer Customer { get; set; }
        public Store Store { get; set; }
    }
}
