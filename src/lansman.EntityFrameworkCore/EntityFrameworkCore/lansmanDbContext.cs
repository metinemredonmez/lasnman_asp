using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using lansman.Authorization.Roles;
using lansman.Authorization.Users;
using lansman.MultiTenancy;
using lansman.Product;
using lansman.Comment;

namespace lansman.EntityFrameworkCore
{
    public class lansmanDbContext : AbpZeroDbContext<Tenant, Role, User, lansmanDbContext>
    {
        public  DbSet<Product.Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Category.Category> Categories { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<Comment.Comment> Comments { get; set; }
        public DbSet<CommentImage> CommentImages { get; set; }
        public lansmanDbContext(DbContextOptions<lansmanDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.UserAddresses)
                .WithOne(ua => ua.User)
                .HasForeignKey(ua => ua.UserId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
