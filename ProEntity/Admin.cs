using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProEntity
{

    public class Admin
    {
       [Key]
        public int AdminId { get; set; }
        
        public string APassword { get; set; }
    }
}
