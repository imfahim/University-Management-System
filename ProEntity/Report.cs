using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ProEntity
{
 
    public class Report
    {
        [Key]
        public int RId { get; set; }
        public int StuId { get; set; }
        public Student student { get; set; }
        public string Comment { get; set; }
    }
}
