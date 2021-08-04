using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ITMO.ADOnet.ZachetEF
{
    public class SampleContext : DbContext
    {
        public SampleContext() : base("MyStudents")
        { }

        public DbSet<Student> Students { get; set; }

    }

}
