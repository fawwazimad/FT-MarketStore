using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FT_MarketStore.Models
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCart> ProductCarts { get; set; }
        public virtual DbSet<Rolee> Rolees { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<UserLogin> UserLogins { get; set; }
        public virtual DbSet<Userr> Userrs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("USER ID=TAH14_User282 ;PASSWORD=Test321;DATA SOURCE=94.56.229.181:3488/traindb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TAH14_USER282")
                .HasAnnotation("Relational:Collation", "USING_NLS_COMP");

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.HasKey(e => e.CardId)
                    .HasName("SYS_C00218908");

                entity.ToTable("CART");

                entity.Property(e => e.CardId)
                    .HasColumnType("NUMBER(20)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CARD_ID");

                entity.Property(e => e.TotalPrice)
                    .HasColumnType("NUMBER(20)")
                    .HasColumnName("TOTAL_PRICE");

                entity.Property(e => e.Userid)
                    .HasColumnType("NUMBER(20)")
                    .HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("SYS_C00218910");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("CATEGORY");

                entity.Property(e => e.CategoryId)
                    .HasColumnType("NUMBER(20)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CATEGORY_ID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_NAME");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_PATH");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("PRODUCT");

                entity.Property(e => e.ProductId)
                    .HasColumnType("NUMBER(20)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PRODUCT_ID");

                entity.Property(e => e.ExDate)
                    .HasColumnType("DATE")
                    .HasColumnName("EX_DATE");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_PATH");

                entity.Property(e => e.ProductInfo)
                    .HasMaxLength(999)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCT_INFO");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCT_NAME");

                entity.Property(e => e.ProductPrice)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PRODUCT_PRICE");

                entity.Property(e => e.ProductSale)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRODUCT_SALE");

                entity.Property(e => e.StoreId)
                    .HasColumnType("NUMBER(20)")
                    .HasColumnName("STORE_ID");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("SYS_C00226806");
            });

            modelBuilder.Entity<ProductCart>(entity =>
            {
                entity.HasKey(e => e.ProuctCartId)
                    .HasName("SYS_C00241781");

                entity.ToTable("PRODUCT_CART");

                entity.Property(e => e.ProuctCartId)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PROUCT_CART_ID");

                entity.Property(e => e.CartId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CART_ID");

                entity.Property(e => e.ProductId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRODUCT_ID");

                entity.HasOne(d => d.Cart)
                    .WithMany(p => p.ProductCarts)
                    .HasForeignKey(d => d.CartId)
                    .HasConstraintName("SYS_C00241783");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductCarts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("SYS_C00241782");
            });

            modelBuilder.Entity<Rolee>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("SYS_C00206725");

                entity.ToTable("ROLEE");

                entity.Property(e => e.RoleId)
                    .HasColumnType("NUMBER(20)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ROLE_ID");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ROLE_NAME");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.ToTable("STORE");

                entity.Property(e => e.StoreId)
                    .HasColumnType("NUMBER(20)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("STORE_ID");

                entity.Property(e => e.CategoryId)
                    .HasColumnType("NUMBER(20)")
                    .HasColumnName("CATEGORY_ID");

                entity.Property(e => e.StoreCity)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STORE_CITY");

                entity.Property(e => e.StoreEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STORE_EMAIL");

                entity.Property(e => e.StoreImage)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("STORE_IMAGE");

                entity.Property(e => e.StoreInfo)
                    .HasMaxLength(999)
                    .IsUnicode(false)
                    .HasColumnName("STORE_INFO");

                entity.Property(e => e.StoreName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STORE_NAME");

                entity.Property(e => e.StorePhone)
                    .HasColumnType("NUMBER(20)")
                    .HasColumnName("STORE_PHONE");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Stores)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("SYS_C00218906");
            });

            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.HasKey(e => e.LoginId)
                    .HasName("SYS_C00218912");

                entity.ToTable("USER_LOGIN");

                entity.Property(e => e.LoginId)
                    .HasColumnType("NUMBER(20)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("LOGIN_ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Passwordd)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORDD");

                entity.Property(e => e.RoleId)
                    .HasColumnType("NUMBER(20)")
                    .HasColumnName("ROLE_ID");

                entity.Property(e => e.UserId)
                    .HasColumnType("NUMBER(20)")
                    .HasColumnName("USER_ID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserLogins)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("SYS_C00218914");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("SYS_C00218913");
            });

            modelBuilder.Entity<Userr>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("SYS_C00206721");

                entity.ToTable("USERR");

                entity.Property(e => e.UserId)
                    .HasColumnType("NUMBER(20)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("USER_ID");

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FNAME");

                entity.Property(e => e.Lname)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("LNAME");

                entity.Property(e => e.UserBalance)
                    .HasPrecision(5)
                    .HasColumnName("USER_BALANCE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
