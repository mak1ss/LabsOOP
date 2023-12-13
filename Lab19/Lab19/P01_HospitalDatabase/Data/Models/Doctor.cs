using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab19.P01_HospitalDatabase.Data.Models
{
    [Table("Doctors")]
    public class Doctor
    {
        [Column("DoctorId")]
        public int Id { get; set; }

        public string Name { get; set; }    

        public string Specialty { get; set; }

        public ICollection<Visitation> Visitations { get; set; }
    }
}
