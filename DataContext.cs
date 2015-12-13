using System;
using System.IO;

using Microsoft.Data.Entity;
using Microsoft.Extensions.PlatformAbstractions;

namespace EFTest
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var path = PlatformServices.Default.Application.ApplicationBasePath;
            optionsBuilder.UseSqlite("Filename=" + Path.Combine(path, "bin", "test.db"));
        }

        public DbSet<Model1> Model1Set { get; set; }
        public DbSet<Model2> Model2Set { get; set; }
    }

    public class Model1
    {
        Guid Id { get; set; }
    }

    public class Model2
    {
        Guid Id { get; set; }
    }
}