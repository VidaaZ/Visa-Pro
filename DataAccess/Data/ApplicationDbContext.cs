using Domain.Entity;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Agency> Agencies => Set<Agency>();
        public DbSet<Country> Countries => Set<Country>();
        public DbSet<Party> Parties => Set<Party>();
        public DbSet<Individual> Individuals => Set<Individual>();
        public DbSet<Legal> Legals => Set<Legal>();
        public DbSet<User> Users => Set<User>();
        public DbSet<UserParty> UserParties => Set<UserParty>();
        public DbSet<VisaType> VisaTypes => Set<VisaType>();

        protected override void OnModelCreating(ModelBuilder b)
        {
            b.Entity<Party>()
                .HasDiscriminator<PartyType>(p => p.Type)
                .HasValue<Individual>(PartyType.Individual)
                .HasValue<Legal>(PartyType.Legal);

            b.Entity<Agency>()
                .HasOne(a => a.Country)
                .WithMany()
                .HasForeignKey(a => a.CountryId)
                .OnDelete(DeleteBehavior.Restrict);

            b.Entity<UserParty>()
                .HasKey(up => new { up.UserId, up.PartyId });

            b.Entity<UserParty>()
                .HasOne(up => up.User)
                .WithMany(u => u.UserParties)
                .HasForeignKey(up => up.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            b.Entity<UserParty>()
                .HasOne(up => up.Party)
                .WithMany(p => p.UserParties)
                .HasForeignKey(up => up.PartyId)
                .OnDelete(DeleteBehavior.Cascade);

            b.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            base.OnModelCreating(b);
        }
    }
}
