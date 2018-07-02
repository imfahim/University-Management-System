using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProEntity
{
 
    public class Attendence
    {
        [Key]
        public int AttId { get; set; }
        public int CourseId { get; set; }
        public Course course { get; set; }
        public int StudentId { get; set; }
        public Student student { get; set; }
        
        public int SecId { get; set; }
        public Section section { get; set; }
        public int Attend { get; set; }
        public DateTime Date { get; set; }

        
        public int AttendCounter { get; set; }

    }
}
