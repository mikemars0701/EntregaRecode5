using Microsoft.EntityFrameworkCore;
using SpacebookAPI.Model;

namespace SpacebookAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        
        }

        public DbSet<Viagem> Viagens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Viagem>().HasData(
                new Viagem { Id = 1, Destino = "Lua",  Preco = 999.99M, ViagemURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQqyNKJF0L88y06-Tp-uVoTEx7jeN2FQc5Hfabmplt5kq1ypHbKKqvWUz6qH19fNrNy2g8&usqp=CAU" },
                new Viagem { Id = 2, Destino = "Terra",  Preco = 999.99M, ViagemURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRHVfPD7xVOprUwv9cBB9Ub8R6DcQkTfj0RGNloEhvCJg&s" },
                new Viagem { Id = 3, Destino = "Marte", Preco = 999.99M, ViagemURL = "https://media.istockphoto.com/id/1300652810/photo/mars-planet-3d-render-illustration-high-detailed-surface-features.jpg?s=612x612&w=0&k=20&c=V11fm3CB2JD1nmndQRTgBK-w4NOp72DXdxiOj2b9SHk=" },
                new Viagem { Id = 4, Destino = "Jupiter",  Preco = 999.99M, ViagemURL = "https://t4.ftcdn.net/jpg/00/04/94/63/360_F_4946384_BOhNRo9oXd0KiN38sWXwIB72Rh8rzcv1.jpg" }
            );
        }

    }
}
