using System.Data.Entity;
using Model.Models;

namespace Data
{
    public class ShopOnlineDbContext : DbContext
    {
        public ShopOnlineDbContext() : base("ShopOnlineConnection")
        {
            // Khi load bảng cha thì sẽ không tự động load thêm bảng con nữa
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<PostCategory> PostCategories { set; get; }
        public DbSet<PostTag> PostTags { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<ProductCategory> ProductCategories { set; get; }
        public DbSet<ProductTag> ProductTags { set; get; }
        public DbSet<Slide> Slides { set; get; }
        public DbSet<SupportOnline> SupportOnlines { set; get; }
        public DbSet<SystemConfig> SystemConfigs { set; get; }
        public DbSet<Tag> Tags { set; get; }
        public DbSet<VisitorStatistic> VisitorStatistics { set; get; }

        // Phương thức ghi đè, sẽ chạy khi chạy entity framework
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
