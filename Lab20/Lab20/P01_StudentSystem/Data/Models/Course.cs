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
    public class Course
    {
        [Column("CourseId")]
        public int Id { get; set; }

        [MaxLength(80)]
        public string Name { get; set; }

        public string? Description { get; set; }

        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set;}

        public float Price { get; set; }

        public List<Student> Students { get; set; }
        public ICollection<StudentCourse> StudentsEnrolled { get; set; }


    }
}
