using Microsoft.EntityFrameworkCore;
using ProjetoHoteis.lib.Models;

namespace ProjetoHoteis.lib.Data
{
    public class HoteisContext : DbContext
    {
        public HoteisContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Estadias
            modelBuilder.Entity<Estadia>().ToTable("ht_estadias");
            modelBuilder.Entity<Estadia>().HasKey(x => x.Id);
            modelBuilder.Entity<Estadia>()
                        .HasOne(x => x.Quarto)
                        .WithMany(x => x.Estadias)
                        .HasForeignKey(x => x.IdQuarto);
            modelBuilder.Entity<Estadia>()
                        .HasOne(x => x.Responsavel)
                        .WithMany(x => x.Estadias)
                        .HasForeignKey(x => x.IdResponsavel);
            modelBuilder.Entity<Estadia>()
                        .HasMany(x => x.EstadiasXHospedes)
                        .WithOne(x => x.Estadia)
                        .HasForeignKey(x => x.IdEstadia);            
            //Hospedes
            modelBuilder.Entity<Hospede>().ToTable("ht_hospedes");
            modelBuilder.Entity<Hospede>().HasKey(x => x.Id);
            modelBuilder.Entity<Hospede>()
                        .HasMany(x => x.Estadias)
                        .WithOne(x => x.Responsavel)
                        .HasForeignKey(x => x.IdResponsavel);
            modelBuilder.Entity<Hospede>()
                        .HasMany(x => x.EstadiasXHospedes)
                        .WithOne(x => x.Hospede)
                        .HasForeignKey(x => x.IdHospede);
            //Hoteis
            modelBuilder.Entity<Hotel>().ToTable("ht_hoteis");
            modelBuilder.Entity<Hotel>().HasKey(x => x.Id);
            modelBuilder.Entity<Hotel>()
                        .HasMany(x => x.Quartos)
                        .WithOne(x => x.Hotel)
                        .HasForeignKey(x => x.IdHotel);
            modelBuilder.Entity<Hotel>()
                        .HasMany(x => x.ServicosXHoteis)
                        .WithOne(x => x.Hotel)
                        .HasForeignKey(x => x.IdHotel);
            //Quartos
            modelBuilder.Entity<Quarto>().ToTable("ht_quartos");
            modelBuilder.Entity<Quarto>().HasKey(x => x.Id);
            modelBuilder.Entity<Quarto>()
                        .HasMany(x => x.Estadias)
                        .WithOne(x => x.Quarto)
                        .HasForeignKey(x => x.IdQuarto);
            modelBuilder.Entity<Quarto>()
                        .HasOne(x => x.Tipo)
                        .WithMany(x => x.Quartos)
                        .HasForeignKey(x => x.IdTipo); 
            modelBuilder.Entity<Quarto>()
                        .HasOne(x => x.Hotel)
                        .WithMany(x => x.Quartos)
                        .HasForeignKey(x => x.IdHotel);                        
            //Servicos
            modelBuilder.Entity<Servico>().ToTable("ht_servicos");
            modelBuilder.Entity<Servico>().HasKey(x => x.Id);
            modelBuilder.Entity<Servico>()
                        .HasMany(x => x.ServicosXHoteis)
                        .WithOne(x => x.Servico)
                        .HasForeignKey(x => x.IdEstadia); 
            //ServicosXHoteis
            modelBuilder.Entity<ServicosXHoteis>().ToTable("ht_servicos_x_hoteis");
            modelBuilder.Entity<ServicosXHoteis>().HasKey(x => x.Id);
            modelBuilder.Entity<ServicosXHoteis>()
                        .HasOne(x => x.Hotel)
                        .WithMany(x => x.ServicosXHoteis)
                        .HasForeignKey(x => x.IdHotel); 
            modelBuilder.Entity<ServicosXHoteis>()
                        .HasOne(x => x.Servico)
                        .WithMany(x => x.ServicosXHoteis)
                        .HasForeignKey(x => x.IdEstadia);             
            //TiposDeQuartos
            modelBuilder.Entity<TipoDeQuarto>().ToTable("ht_tipos_quarto");
            modelBuilder.Entity<TipoDeQuarto>().HasKey(x => x.Id);
            modelBuilder.Entity<TipoDeQuarto>()
                        .HasMany(x => x.Quartos)
                        .WithOne(x => x.Tipo)
                        .HasForeignKey(x => x.IdTipo); 
            //EstadiasXHospedes
            modelBuilder.Entity<EstadiasXHospedes>().ToTable("ht_estadias_x_hospedes");
            modelBuilder.Entity<EstadiasXHospedes>().HasKey(x => x.Id);
        }
        public DbSet<Estadia> Estadias { get; set; }
        public DbSet<Hospede> Hospedes { get; set; }
        public DbSet<Hotel> Hoteis { get; set; }
        public DbSet<Quarto> Quartos { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<ServicosXHoteis> ServicosXHoteis { get; set; }
        public DbSet<TipoDeQuarto> TiposDeQuartos { get; set; }

    }
}