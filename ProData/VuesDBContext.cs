using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProEntity;

namespace ProData
{
    public class VuesDBContext : DbContext
    {
        public DbSet<Course> Course { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Attendence> Attendence { get; set; }

        public DbSet<PreRegistraion> Preregistration { get; set; }
        public DbSet<Report> Report { get; set; }

        public DbSet<Section> Section { get; set; }

        public DbSet<Student> Student { get; set; }

        public DbSet<Grade> Grade { get; set; }
        public DbSet<StudentSection> StudentSection { get; set; }
    }
  
}
