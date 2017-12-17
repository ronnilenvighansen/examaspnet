using Microsoft.EntityFrameworkCore;
using ExamAspDotNet.Models.Entities;

namespace ExamAspDotNet.Models
{
    public class GameDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./ExamAspDotNet.db");
        } 
        
    }
    
}