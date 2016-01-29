using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_7_3
{
    class MobileContext : DbContext
    {
        public MobileContext()
            : base("EF_lesson_7_3")
        { }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Smartphone> Smarts { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Phone>()
            .Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Phones");
            });
            modelBuilder.Entity<Smartphone>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Smarts");
            });
        }
    }
}
