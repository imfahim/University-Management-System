using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProEntity
{
    
    public class PreRegistraion
    {
        [Key]
        public int PreRegId { get; set; }
        public int StudentId { get; set; }
        public Student student { get; set; }
        public int CourseId { get; set; }
        public Course course { get; set; }
        public int SecId { get; set; }
        public Section section { get; set; }
        public string Semester { get; set; }

        public int TotalCredit { get; set; }
    }
}
