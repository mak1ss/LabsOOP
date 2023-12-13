using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19.P01_HospitalDatabase.Data.Models
{
    [Table("Visitations")]
    public class Visitation
    {
        [Column("VisitationId")]
        public int Id { get; set; }

        public DateOnly Date {  get; set; }

        [MaxLength(250)]
        public string Comments { get; set; }

        public Patient Patient { get; set; }

        public Doctor? Doctor { get; set; }
    }
}
