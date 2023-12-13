using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19_3_.P03_SalesDatabase.Data.Models
{
    public class Store
    {
        [Column("StoreId")]
        public int Id { get; set; }
        [MaxLength(80)]
        public string Name { get; set; }    
    }
}
