using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreBase.Persistence.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;
        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, Name = "Apple IPhone 13 Pro", UnitPrice = 13500, Stock = 100, CategoryId = _ids[0] },
                new Product { Id = 2, Name = "Apple IPhone 12 Pro", UnitPrice = 12500, Stock = 100, CategoryId = _ids[1] },
                new Product { Id = 3, Name = "Apple IPhone 11 Pro", UnitPrice = 11500, Stock = 100, CategoryId = _ids[1] },
                new Product { Id = 4, Name = "Apple IPhone 10 Pro", UnitPrice = 10500, Stock = 100, CategoryId = _ids[1] },
                new Product { Id = 5, Name = "Apple IPhone 6 Pro", UnitPrice = 9500, Stock = 100, CategoryId = _ids[1] }

                );
        }
    }
}
