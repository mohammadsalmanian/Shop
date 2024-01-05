
using Microsoft.EntityFrameworkCore;
using Shops.DataLayer.Entitys.Access;
using Shops.DataLayer.Entitys.Account;
using Shops.DataLayer.Entitys.Product;
using Shops.DataLayer.Entitys.Site;

namespace Shops.DataLayer.Context
{
    public class AngularEshopDbContext : DbContext
    {
        public AngularEshopDbContext(DbContextOptions<AngularEshopDbContext> options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder option)
        //{
        //    base.OnConfiguring(option);
        //}

        #region dbset
        DbSet<User> Users { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<UserRole> UserRoles { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<ProductVisit> ProductVisits { get; set; }
        DbSet<ProductCategory> ProductCategorys { get; set; }
        DbSet<ProductSelectedCategory> ProductSelectedCategorys { get; set; }
        DbSet<ProductGallery> ProductGallerys { get; set; }
        DbSet<Slider> Sliders { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
