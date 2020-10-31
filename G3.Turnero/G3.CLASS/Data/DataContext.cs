using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3.CLASS.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<TareaTurno> TareaTurnos { get; set; }
        public DbSet<Horario> Horarios { get; set; }
        public DbSet<Espejo> Espejos { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<Peluquero> Peluqueros { get; set; }
        public DbSet<Turno> Turnos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Turno>()
                .HasOptional<Peluquero>(b => b.Peluquero)
                .WithMany()
                .WillCascadeOnDelete(false);
        }
    }
}
