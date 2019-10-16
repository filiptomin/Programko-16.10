using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace db2.data
{
    class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext() : base()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        public DbSet<Students> Students { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
            builder.UseSqlite(@"DataSource=myDatabase.sglite");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Students>()
                .Property(p => p.FirstName)
                .HasMaxLength(100);
            builder.Entity<Classroom>().HasData(
                new Classroom { ID = 1, Name = "P1" },
                new Classroom { ID = 2, Name = "P2" },
                new Classroom { ID = 3, Name = "P3" },
                new Classroom { ID = 4, Name = "P4" }
                );
            builder.Entity<Students>().HasData(
                
                new Students { ID = 2, FirstName = "Adam", LastName = "Plašil", ClassroomId = 1 },
                new Students { ID = 3, FirstName = "Jiří", LastName = "Růta", ClassroomId = 1 },
                new Students { ID = 4, FirstName = "Petr", LastName = "Mencl", ClassroomId = 1 }

                ); 
        }
    }
}















