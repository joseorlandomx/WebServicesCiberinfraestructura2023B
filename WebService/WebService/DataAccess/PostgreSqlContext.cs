using Microsoft.EntityFrameworkCore;
using WebService.Models;

namespace WebService.DataAccess
{
    //Herencia de la libreria de Postgre
    public class PostgreSqlContext : DbContext
    { //declaracion de propiedades para utilizar objetos de catalumno
        public DbSet<catalumno> catalumno { get; set; }

        //Declaracion del constructor y modificadores de acceso

        public PostgreSqlContext(DbContextOptions<PostgreSqlContext> options) : base(options) {
        
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
