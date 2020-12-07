using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DbModel
{
    public partial class AmsContext : DbContext
    {
        public AmsContext()
        {
        }

        public AmsContext(DbContextOptions<AmsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<StatusMap> StatusMaps { get; set; }
        public virtual DbSet<StatusMapEvent> StatusMapEvents { get; set; }
        public virtual DbSet<vStatusMap> vStatusMaps { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

 
            modelBuilder.Entity<StatusMap>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<StatusMapEvent>(entity =>
            {
                entity.HasKey(e => new { e.StatusMapId, e.CurrentStatusCodeId, e.EventId, e.NextStatusCodeId })
                    .HasName("PK_System.StatusMapEvent");

           
                entity.HasOne(d => d.Event)
                    .WithMany(p => p.StatusMapEvents)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventId");

              
                entity.HasOne(d => d.StatusMap)
                    .WithMany(p => p.StatusMapEvents)
                    .HasForeignKey(d => d.StatusMapId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatusMapId");
            });

            modelBuilder.Entity<vStatusMap>(entity =>
            {
                entity.ToView("vStatusMap", "Core");

                entity.Property(e => e.CurrentStatusCode).IsUnicode(false);

                entity.Property(e => e.NextStatusCode).IsUnicode(false);
            });

          
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
