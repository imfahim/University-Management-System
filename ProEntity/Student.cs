using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProEntity
{

    public class Student
    {
        [Key]
        public int StuId { get; set; }
        public string StuPass{get ;set; }

        public string StuName { get; set; }
        public double AttendancePercentage { get; set; }
        public double Cgpa { get; set; }
        List<Section> section { get; set; }



    }
}
