using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.ADONet.Zachet
{
    public class SampleContext : DbContext
    {
        public SampleContext() : base("MyPetNadzor")
        { }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<PetType> PetTypes { get; set; }
        public DbSet<Pet> Pets { get; set; }
    }
}
