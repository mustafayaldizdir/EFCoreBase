using EFCoreBase.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreBase.Persistence.Seeds
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        private readonly int[] _ids;

        public CategorySeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Category> builder)
        {
           builder.HasData(
               new Category() { Id = _ids[0], Name = "Son Model" },
               new Category() { Id = _ids[1], Name = "Öncekiler" }
           );
        }
    }
}
