using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProEntity
{
  
    public class Faculty
    {
        [Key]
        public int FacultyId { get; set; }
        //[Required]
        public string FacultyName { get; set; }

        public string FacultyPass { get; set; }
        public List<Course> Courses { get; set; }
        
    }
}
