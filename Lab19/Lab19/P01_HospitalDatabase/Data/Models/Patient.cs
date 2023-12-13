using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Lab19.P01_HospitalDatabase.Data.Models
{
    [Table("Patients")]
    public class Patient
    {
        [Column("PatientId")]
        public int Id { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]

        public string LastName { get; set; }
        [MaxLength(250)]
        public string Address { get; set; }
        [Unicode(false)]
        [MaxLength(80)]
        public string Email { get; set; }
        public bool HasInsurance { get; set; }

        public List<Medicament> medicaments { get; set; } = new List<Medicament>();

        public ICollection<PatientMedicament> Prescriptions { get; set; } = new List<PatientMedicament>();

    }
}
