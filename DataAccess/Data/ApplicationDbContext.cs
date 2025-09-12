using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
  : base(options)
        {
        }
        public DbSet<ApplicationUser> Users => Set<ApplicationUser>();
        public DbSet<Profile> Profiles => Set<Profile>();
        public DbSet<ApplicationType> ApplicationTypes => Set<ApplicationType>();
        public DbSet<VisaApplication> VisaApplications => Set<VisaApplication>();
        public DbSet<Document> Documents => Set<Document>();
        public DbSet<Payment> Payments => Set<Payment>();
        public DbSet<Appointment> Appointments => Set<Appointment>();
        public DbSet<Notification> Notifications => Set<Notification>();

        protected override void OnModelCreating(ModelBuilder b)
        {

            b.Entity<ApplicationUser>()
                .HasOne(u => u.Profile)
                .WithOne(p => p.User)
                .HasForeignKey<Profile>(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);


            b.Entity<VisaApplication>()
                .HasOne(v => v.User)
                .WithMany(u => u.VisaApplications)
                .HasForeignKey(v => v.UserId)
                .OnDelete(DeleteBehavior.Restrict);


            b.Entity<VisaApplication>()
                .HasOne(v => v.ApplicationType)
                .WithMany(t => t.VisaApplications)
                .HasForeignKey(v => v.ApplicationTypeId)
                .OnDelete(DeleteBehavior.Restrict);


            b.Entity<VisaApplication>()
                .HasOne(v => v.AssignedOfficerUser)
                .WithMany()
                .HasForeignKey(v => v.AssignedOfficerUserId)
                .OnDelete(DeleteBehavior.SetNull);


            b.Entity<Document>()
                .HasOne(d => d.VerifiedByUser)
                .WithMany()
                .HasForeignKey(d => d.VerifiedByUserId)
                .OnDelete(DeleteBehavior.SetNull);


            b.Entity<Notification>()
                .HasOne(n => n.User)
                .WithMany(u => u.Notifications)
                .HasForeignKey(n => n.UserId)
                .OnDelete(DeleteBehavior.Cascade);


            b.Entity<Notification>()
                .HasOne(n => n.VisaApplication)
                .WithMany()
                .HasForeignKey(n => n.VisaApplicationId)
                .OnDelete(DeleteBehavior.SetNull);


            b.Entity<Payment>()
                .Property(p => p.Amount)
                .HasPrecision(18, 2);

            base.OnModelCreating(b);
        }
    }

}
