using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingSWheels.Models;

namespace TrainingSWheels.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Skill> Skills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>().HasData(
                new Skill {Id = 1, Name = "FireBall", Damage = 30 },
                new Skill {Id = 2, Name = "FrostBall", Damage = 35 },
                new Skill {Id = 3, Name = "EarthBall", Damage = 50 }
                );
        }
    }
}
