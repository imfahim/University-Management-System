using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProEntity
{
    public class StudentSection
    {
        [Key]
        public int StuSec { get; set; }

        public int StuId { get; set; }
        public Student student { get; set; }

        public int SecId { get; set; }
        public Section section { get; set; }
    }
}
