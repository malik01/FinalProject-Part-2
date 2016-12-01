namespace Final_Project_Part1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MaggiewalaContext : DbContext
    {
        public MaggiewalaContext()
            : base("name=MaggiewalaConnection")
        {
        }

        public virtual DbSet<Add_Ons> Add_Ons { get; set; }
        public virtual DbSet<Dessert> Desserts { get; set; }
        public virtual DbSet<Maggie_Time> Maggie_Time { get; set; }
        public virtual DbSet<Soup> Soups { get; set; }
        public virtual DbSet<Starter> Starters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Add_Ons>()
                .Property(e => e.Item)
                .IsUnicode(false);

            modelBuilder.Entity<Add_Ons>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Add_Ons>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Dessert>()
                .Property(e => e.Item)
                .IsUnicode(false);

            modelBuilder.Entity<Dessert>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Dessert>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Dessert>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Maggie_Time>()
                .Property(e => e.Item)
                .IsUnicode(false);

            modelBuilder.Entity<Maggie_Time>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Maggie_Time>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Maggie_Time>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Soup>()
                .Property(e => e.Item)
                .IsUnicode(false);

            modelBuilder.Entity<Soup>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Soup>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Soup>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Starter>()
                .Property(e => e.Item)
                .IsUnicode(false);

            modelBuilder.Entity<Starter>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Starter>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Starter>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);
        }
    }
}
