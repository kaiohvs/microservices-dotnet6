using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext() { }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Product> products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Camisa JurassyPark",
                Description = "Uma linda camisa do jurassipark preta com vermelho",
                Price = 69.8,
                CatagoryName = "Camisa",
                ImageUrl = "Test",
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Capacete dart veider",
                Description = "Uma capacete do dart veider pequeno da cor preta",
                Price = 169.8,
                CatagoryName = "Capacete",
                ImageUrl = "Test",
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Boneco storm",
                Description = "Um boneco de 1.10 branco do tropper storm",
                Price = 269.8,
                CatagoryName = "Boneco",
                ImageUrl = "Test",
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Camisa gamer",
                Description = "Uma linda camisa gamer preta",
                Price = 69.8,
                CatagoryName = "Camisa",
                ImageUrl = "Test",
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Camisa spacex",
                Description = "Uma linda camisa da spacex branca com a manga azul",
                Price = 69.8,
                CatagoryName = "Camisa",
                ImageUrl = "Test",
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Camisa coffer",
                Description = "Uma linda camisa da coffer amarelada",
                Price = 69.8,
                CatagoryName = "Camisa",
                ImageUrl = "Test",
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Moletom cobra kay",
                Description = "Um lindo moletom preto da serie cobra kay",
                Price = 100,
                CatagoryName = "Moleton",
                ImageUrl = "Test",
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "filme stall tack",
                Description = "Uma linda camisa do jurassipark preta com vermelho",
                Price = 69.8,
                CatagoryName = "Camisa",
                ImageUrl = "Test",
            });
            

        }

    }
}
