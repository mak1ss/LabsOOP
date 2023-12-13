using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20.P01_StudentSystem.Data.Models
{
    public class Student
    {
        [Column("StudentId")]
        public int Id { get; set; }

        [MaxLength(80)]
        public string Name { get; set; }

        [Unicode(false)]
        [Length(10, 10)]
        public string? Phone { get; set; }

        public List<Course> Courses { get; set; }

        public ICollection<StudentCourse> RegisteredOn;


        public DateOnly? Birthday;
    }
}
