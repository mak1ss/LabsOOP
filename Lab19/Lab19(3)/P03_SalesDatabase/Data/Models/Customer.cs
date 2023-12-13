using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19_3_.P03_SalesDatabase.Data.Models
{
    public class Customer
    {
        [Column("CustomerId")]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }

        [Unicode(false)]
        [MaxLength(80)]
        public string Email { get; set; }
        public string CreditCardNumber { get; set; }

        public ICollection<Sale> Sales { get; set; }
    }
}
