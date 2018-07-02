using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProEntity;

namespace Presentation.Models
{
    public class ForStudent
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Semester {get;set;}
        public string credit { get; set; }
        public List<Course> course { get; set; }

        public int SecId { get; set; }
        public string SecName { get; set; }
        public List<Section> section { get; set; }

        public int gradeId { get; set; }
        public double grade { get; set; }
        public List<Grade> gr { get; set; }


    }
}