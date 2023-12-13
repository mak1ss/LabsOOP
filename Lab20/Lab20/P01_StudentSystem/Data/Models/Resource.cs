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
    public enum ResourceType
    {
        Video, Presentation, Document, Other
    }
    public class Resource
    {
        [Column("ResourceId")]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        [Unicode(false)]
        public string Url { get; set; }

        public ResourceType ResourceType { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
