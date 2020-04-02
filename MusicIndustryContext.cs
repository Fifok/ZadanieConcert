namespace ZadanieConcrete
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using ZadanieConcrete.Models;

    public class MusicIndustryContext : DbContext
    {
        public DbSet<Band> Bands { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        public MusicIndustryContext()
            : base("name=MusicIndustryModel")
        {
            Database.Log = Console.WriteLine;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Band>()
                .HasOptional<Address>(x => x.Address)
                .WithRequired(x => x.Band);

            modelBuilder.Entity<Address>()
                .HasKey(x => x.BandId);

            modelBuilder.Entity<City>()
                    .HasMany<Event>(x => x.Events)
                    .WithRequired(x => x.City);

            modelBuilder.Entity<Event>()
                .HasMany<Ticket>(x => x.Tickets)
                .WithRequired(x => x.Event);
        }
    }

  
}