using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace Server.Data
{
    public class AppDBContext : DbContext
    {

        public DbSet<Category> Categories {get; set;}

        public DbSet<Car> Cars {get; set;}

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { } 
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //call the base verision of this method or we get an error
            base.OnModelCreating(modelBuilder);

            Category[] categoriesToSeed = new Category[3];

            for(int i = 0; i < categoriesToSeed.Length; i++)
            {
                categoriesToSeed[i] = new Category { CategoryID = i, Name = $"Category {i}", Description = $"Description {i}" };
            }

            modelBuilder.Entity<Category>().HasData(categoriesToSeed);


        }        


    }
}
