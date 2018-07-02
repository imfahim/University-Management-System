using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProEntity
{
   
    public class Section
    {
        [Key]
        public int SecId { get; set; }
        public string SecName { get; set; }

        public int FacultyId { get; set; }
        public Faculty faculty { get; set; }

        public int? CourseId { get; set; }
        public Course course { get; set; }

        public List<Student> student { get; set; }

    }
}
