using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace gitEx2.Models
{
    public partial class PayScaleContext : DbContext
    {
        public PayScaleContext()
        {
        }

        public PayScaleContext(DbContextOptions<PayScaleContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pay> Pays { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-3IFULNF;database=PayScale;trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pay>(entity =>
            {
                entity.HasKey(e => e.PayBand)
                    .HasName("PK__pay__66B0F53F96620629");

                entity.ToTable("pay");

                entity.Property(e => e.PayBand).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
