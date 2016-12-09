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
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }


    }
}
