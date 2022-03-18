using EFCoreBase.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreBase.Persistence.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;
        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, Name = "Apple IPhone 13 Pro", UnitPrice = 13500, Stock = 100, CategoryId = _ids[0],StartDate = DateTime.Now,EndDate = DateTime.Now  },
                new Product { Id = 2, Name = "Apple IPhone 12 Pro", UnitPrice = 12500, Stock = 100, CategoryId = _ids[1],StartDate = DateTime.Now,EndDate = DateTime.Now  },
                new Product { Id = 3, Name = "Apple IPhone 11 Pro", UnitPrice = 11500, Stock = 100, CategoryId = _ids[1], StartDate = DateTime.Now, EndDate = DateTime.Now },
                new Product { Id = 4, Name = "Apple IPhone 10 Pro", UnitPrice = 10500, Stock = 100, CategoryId = _ids[1], StartDate = DateTime.Now, EndDate = DateTime.Now },
                new Product { Id = 5, Name = "Apple IPhone 6 Pro", UnitPrice = 9500, Stock = 100, CategoryId = _ids[1],StartDate = DateTime.Now,EndDate = DateTime.Now }

                );
        }
    }
}
