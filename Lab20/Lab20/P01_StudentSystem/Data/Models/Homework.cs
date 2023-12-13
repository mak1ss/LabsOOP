using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20.P01_StudentSystem.Data.Models
{
    public enum ContentType
    {
        Application, Pdf, Zip
    }
    public class Homework
    {
        [Column("HomeworkId")]
        public int Id { get; set; }

        [Unicode(false)]
        public string Content { get; set; }

        public ContentType ContentType { get; set; }

        public DateTime SubmissionTime { get; set; }

        public int StudentId { get; set; }
        public int CourseId {  get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
