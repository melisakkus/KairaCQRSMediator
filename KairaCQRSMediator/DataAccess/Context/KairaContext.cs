using KairaCQRSMediator.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace KairaCQRSMediator.DataAccess.Context
{
    public class KairaContext : DbContext
    {
        public KairaContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<PhotoGallery> PhotoGalleries { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }

    }
}
