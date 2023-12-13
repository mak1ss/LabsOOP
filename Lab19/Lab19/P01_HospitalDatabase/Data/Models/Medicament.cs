using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19.P01_HospitalDatabase.Data.Models
{
    [Table("Medicaments")]
    public class Medicament
    {
        [Column("MedicamentId")]
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Patient> patients { get; set; } = new List<Patient>();
        public ICollection<PatientMedicament> Prescriptions { get; set; } = new List<PatientMedicament>();

    }
}
