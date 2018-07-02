using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProEntity
{

    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        //[Required]
        public string CourseName { get; set; }
        //[Required]

        public string Semester { get; set; }

        public int credit { get; set; }
    }
}
