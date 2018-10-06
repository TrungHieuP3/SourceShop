namespace Models.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ShopDbContext : DbContext
    {
        public ShopDbContext()
            : base("name=ShopDbContext")
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Grant> Grants { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<Reply> Replies { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bill>()
                .Property(e => e.BillID)
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .Property(e => e.CusID)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.CateID)
                .IsUnicode(false);

            modelBuilder.Entity<Comment>()
                .Property(e => e.ComID)
                .IsUnicode(false);

            modelBuilder.Entity<Comment>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Comment>()
                .HasMany(e => e.Replies)
                .WithRequired(e => e.Comment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CusID)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Grant>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Grant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.BillID)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.ProID)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProID)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.UrlImg)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.CateID)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Ratings)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rating>()
                .Property(e => e.RatID)
                .IsUnicode(false);

            modelBuilder.Entity<Rating>()
                .Property(e => e.ProID)
                .IsUnicode(false);

            modelBuilder.Entity<Rating>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Reply>()
                .Property(e => e.ComID)
                .IsUnicode(false);

            modelBuilder.Entity<Reply>()
                .Property(e => e.CusID)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CusID)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Passwd)
                .IsUnicode(false);
        }
    }
}
