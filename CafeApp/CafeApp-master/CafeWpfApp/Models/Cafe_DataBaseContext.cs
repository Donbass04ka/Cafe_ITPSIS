using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CafeWpfApp
{
    public partial class Cafe_DataBaseContext : DbContext
    {
        public Cafe_DataBaseContext()
        {
        }

        public Cafe_DataBaseContext(DbContextOptions<Cafe_DataBaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dish> Dishes { get; set; } = null!;
        public virtual DbSet<DishInOrder> DishInOrders { get; set; } = null!;
        public virtual DbSet<DishesInOrder> DishesInOrders { get; set; } = null!;
        public virtual DbSet<Drink> Drinks { get; set; } = null!;
        public virtual DbSet<DrinkInOrder> DrinkInOrders { get; set; } = null!;
        public virtual DbSet<DrinksInOrder> DrinksInOrders { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; } = null!;
        public virtual DbSet<Post> Posts { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<StatusOrder> StatusOrders { get; set; } = null!;
        public virtual DbSet<StatusWorkedShift> StatusWorkedShifts { get; set; } = null!;
        public virtual DbSet<Table> Tables { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<WorkedShift> WorkedShifts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Cafe_DataBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dish>(entity =>
            {
                entity.ToTable("Dish");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DishInOrder>(entity =>
            {
                entity.ToTable("DishInOrder");

                entity.HasOne(d => d.Dish)
                    .WithMany(p => p.DishInOrders)
                    .HasForeignKey(d => d.DishId)
                    .HasConstraintName("FK_DishInOrder_Dish");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.DishInOrders)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_DishInOrder_Order");
            });

            modelBuilder.Entity<DishesInOrder>(entity =>
            {
                entity.ToTable("DishesInOrder");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Count).ValueGeneratedOnAdd();

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Drink>(entity =>
            {
                entity.ToTable("Drink");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DrinkInOrder>(entity =>
            {
                entity.ToTable("DrinkInOrder");

                entity.HasOne(d => d.Drink)
                    .WithMany(p => p.DrinkInOrders)
                    .HasForeignKey(d => d.DrinkId)
                    .HasConstraintName("FK_DrinkInOrder_Drink");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.DrinkInOrders)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_DrinkInOrder_Order");
            });

            modelBuilder.Entity<DrinksInOrder>(entity =>
            {
                entity.ToTable("DrinksInOrder");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .HasConstraintName("FK_Order_PaymentMethod");

                entity.HasOne(d => d.StatusOrder)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.StatusOrderId)
                    .HasConstraintName("FK_Order_StatusOrder");

                entity.HasOne(d => d.Table)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.TableId)
                    .HasConstraintName("FK_Order_Table");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Order_User");
            });

            modelBuilder.Entity<PaymentMethod>(entity =>
            {
                entity.ToTable("PaymentMethod");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("Post");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<StatusOrder>(entity =>
            {
                entity.ToTable("StatusOrder");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<StatusWorkedShift>(entity =>
            {
                entity.ToTable("StatusWorkedShift");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Table>(entity =>
            {
                entity.ToTable("Table");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Login)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.SecondName)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK_User_Post");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_User_Role");
            });

            modelBuilder.Entity<WorkedShift>(entity =>
            {
                entity.ToTable("WorkedShift");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.WorkedShifts)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_WorkedShift_Order");

                entity.HasOne(d => d.StatusWorkedShift)
                    .WithMany(p => p.WorkedShifts)
                    .HasForeignKey(d => d.StatusWorkedShiftId)
                    .HasConstraintName("FK_WorkedShift_StatusWorkedShift");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
